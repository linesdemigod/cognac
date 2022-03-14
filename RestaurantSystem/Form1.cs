using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FoxLearn.License;
using RestaurantSystem.Controller;
using RestaurantSystem.View;
using RestaurantSystem.View.license;
using RestaurantSystem.View.databse;
using System.IO;

namespace RestaurantSystem
{
    public partial class Form1 : KryptonForm
    {
        // Instance of the class
        Login user = new Login();

        //transfer to another form
        public static string Login_username { get; set; }
        public static string L_role { get; set; }
        public static string Login_phone { get; set; }
        public static string Login_gender { get; set; }
        public static string Login_fname { get; set; }
        public static string Login_lname { get; set; }
        public static string Login_role { get; set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        const int ProductCode = 1;
        string licenseDuration;

        //check the if the key exist
        private void checkLicenseKeyExists()
        {
            string fileLocation = string.Format(@"{0}\Key.lic", Application.StartupPath);

            if (!File.Exists(fileLocation))
            {
                MessageBox.Show("Register the application to use it");
            } else
            {
                checkLicenseKey(); //call the function here
            }
        }

        //get the license key and check if it is valid or not 
        private void checkLicenseKey()
        {
            string productID = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(productID);
            LicenseInfo lic = new LicenseInfo();
            //Get license information from license file
            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;

         
                //Check valid
                if (km.ValidKey(ref productKey))
                {
                    KeyValuesClass kv = new KeyValuesClass();
                    //Decrypt license key
                    if (km.DisassembleKey(productKey, ref kv))
                    {
                        //lblProductName.Text = "Cognac";
                        string productKeys = productKey;
                        if (kv.Type == LicenseType.TRIAL)
                        {
                            licenseDuration = string.Format("{0}", (kv.Expiration - DateTime.Now.Date).Days);
                            if (Convert.ToInt32(licenseDuration) < 0)
                            {

                                lblLicense.Text = "Your License has expired, Please contact the developer";

                                return;
                            }

                            //login when the license is not expired
                            login();
                        }
                        else
                        {
                            licenseDuration = "Full";
                            //login when the license is full
                            login();
                        }
                } 
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //checkLicenseKey();
            checkLicenseKeyExists();
        }

        private void login()
        {
            try
            {
                //ASSIGN THE VARIABLE TO THE USER INPUT
                user.username = txtUser.Text.Trim();
                user.password = txtPass.Text.Trim();
                bool verify = user.user_verification();

                //Validate if the textbox is empty
                if (user.username == "" || user.password == "")
                {

                    MessageBox.Show("Fill all field");
                }
                else
                {

                    if (verify)
                    {
                        //MessageBox.Show("Successfully login");
                        int role = user.role;
                        Login_role = user.role.ToString();
                        Login_username = user.username;
                        Login_fname = user.fname;
                        Login_lname = user.lname;
                        Login_phone = user.phone;
                        Login_gender = user.gender;

                        #region login logic
                        /*if (role == 1)
                        {
                            Admindasboard admindash = new Admindasboard();
                            admindash.Show();
                            this.Hide();
                            L_role = "Super Admin";
                        }
                        else if (role == 2)
                        {
                            Admindasboard manager = new Admindasboard();
                            manager.Show();
                            this.Hide();
                            L_role = "Manager";
                        }
                        else if (role == 3)
                        {
                            Waiterdashboard waiter = new Waiterdashboard();
                            waiter.Show();
                            this.Hide();
                            L_role = "Cashier";
                        } */
                        #endregion
                        Loadingbar load = new Loadingbar();
                        load.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error");
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkLicenseKey();
            }
        }

        private void chkBoxSHowPassword_CheckedChanged(object sender, EventArgs e)
        {
            showHidePassword();
        }

        private void showHidePassword()
        {
            if (chkBoxSHowPassword.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = '\0';
                chkBoxSHowPassword.Text = "Hide Password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                chkBoxSHowPassword.Text = "Show Password";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Backups backup = new Backups();

            backup.createFolder();
            backup.backup();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkLogin frm = new NetworkLogin();
            frm.ShowDialog();
        }

        
        
        //Open License
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();
            frm.ShowDialog();
        }


    }
}
