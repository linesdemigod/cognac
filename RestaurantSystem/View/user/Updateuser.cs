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
    public partial class Updateuser : KryptonForm
    {
        //Instance of manageuser class
        ManageUser manageUser = new ManageUser();

        //variable for the columns
        string code, firstName, lastName, telephone, sex, uid, pwd, group;

        //accept only numbers
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Do you want to update? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    updateUser();
          
                }
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro User 001: Something went wrong");
            }
        }

        //when the forms loads
        private void Updateuser_Load(object sender, EventArgs e)
        {

            loadUserInfo();
            setupUserAccess();
        }


        //validate Admin and manager
        public void setupUserAccess()
        {

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

            //Instance of the AddUser class
            AddUser user = new AddUser();

            switch (userLoggedInRole)
            {
                case 2:
                    txtPassword.Visible = false;
                    kryptonLabel5.Visible = false;
                    comboRole.Items.Add("Cashier");
                    

                    break;
                default:
                    user.getRole();
                    comboRole.DataSource = user.dt;
                    comboRole.DisplayMember = "role";
                    comboRole.ValueMember = "role_id";
                    break;
            }

        }

        //load the values from the datagridview to the various textbox and combobox
        private void loadUserInfo()
        {
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtTelephone.Text = telephone;
            comboGender.Text = sex;
            txtUsername.Text = uid;
            txtPassword.Text = pwd;
            comboRole.Text = group;
            txtId.Text = code;
        }
        
        //passed parameter because of the function in Manageuser
        public Updateuser(string id, string role, string fname, string lname, string phone, string gender, string username, string password)
        {
            InitializeComponent();

            code = id;
            group = role;
            firstName = fname;
            lastName = lname;
            telephone = phone;
            sex = gender;
            uid = username;
            pwd = password;
           

        }

        

        //method to validate before updating the user
        public void updateUser()
        {
            manageUser.firstName = txtFirstName.Text;
            manageUser.lastName = txtLastName.Text;
            manageUser.telephone = txtTelephone.Text;
            manageUser.gender = comboGender.Text;
            manageUser.username = txtUsername.Text;
            manageUser.password = txtPassword.Text;
            manageUser.role = comboRole.Text;
            manageUser.id = txtId.Text;

            //check if the textboxes are empty
            if (manageUser.firstName == "" || manageUser.lastName == "" || manageUser.telephone == "" || manageUser.gender == "" || manageUser.username == "" || manageUser.role == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }

           /* if (manageUser.password != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
                return;
            }
            */
            if (manageUser.password.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more");

                return;
            }

            manageUser.updateUser();
            MessageBox.Show("Account updated successfully");
            
            //clear textbox after successful insert
            manageUser.firstName = txtFirstName.Text = "";
            manageUser.lastName = txtLastName.Text = "";
            manageUser.telephone = txtTelephone.Text = "";
            manageUser.gender = comboGender.Text = "";
            manageUser.username = txtUsername.Text = "";
            manageUser.password = txtPassword.Text = "";
            //txtConfirmPassword.Text = "";
            manageUser.role = comboRole.Text = "";
            manageUser.id = txtId.Text = "";
        }
        
    }
}
