using ComponentFactory.Krypton.Toolkit;
using RestaurantSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View.user
{
    public partial class Adduser : KryptonForm
    {

        AddUser user = new AddUser();

        public Adduser()
        {
            InitializeComponent();
            
        }

        private void Adduser_Load(object sender, EventArgs e)
        {
            getRoleData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                //Invoke function in this class
                Create();


            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
        }

        //method to put the data to the combobox
        public void getRoleData()
        {
            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

            if (userLoggedInRole == 2)
            {
                comboRole.Items.Add("Cashier");
               
            } else
            {
                user.getRole();
                comboRole.DataSource = user.dt;
                comboRole.DisplayMember = "role";
                comboRole.ValueMember = "role_id";
            }
            
        }

        public void Create()
        {
            //assign the properties of the AddUsers class to the textbox and trim user input
            user.firstName = txtFirstName.Text.Trim();
            user.lastName = txtLastName.Text.Trim();
            user.telephone = txtTelephone.Text.Trim();
            user.gender = comboGender.Text.Trim();
            user.username = txtUsername.Text.Trim();
            user.password = txtPassword.Text.Trim();
            user.role = comboRole.Text.Trim();

            //assign uidExist to the method in AddUsers class
            bool uidExist = user.uidExist();


            //check if the textboxes are empty
            if (user.firstName == "" || user.lastName == "" || user.telephone == "" || user.gender == "" || user.username == "" || user.password == "" || user.role == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }

            //check if the passwords are the same
            if (user.password != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
                return;
            }

            if (user.password.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more");
                return;
            }

            //check if username exist
            if (uidExist == true)
            {
                MessageBox.Show("Username Exist, please choose new username");
                return;
            }

            //call the method in the AddUsers class
            user.createUser();
            MessageBox.Show("New user created");

            //clear textbox after successful insert
            user.firstName = txtFirstName.Text = "";
            user.lastName = txtLastName.Text = "";
            user.telephone = txtTelephone.Text = "";
            user.gender = comboGender.Text = "";
            user.username = txtUsername.Text = "";
            user.password = txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            user.role = comboRole.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //clear textbox after successful insert
            user.firstName = txtFirstName.Text = "";
            user.lastName = txtLastName.Text = "";
            user.telephone = txtTelephone.Text = "";
            user.gender = comboGender.Text = "";
            user.username = txtUsername.Text = "";
            user.password = txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            user.role = comboRole.Text = "";
        }

        //accept only numbers
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
