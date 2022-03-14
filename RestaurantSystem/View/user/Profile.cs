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
    public partial class Profile : KryptonForm
    {
        Profiles profile = new Profiles();

        public Profile()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
                Create();
           
           
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            labelGender.Text = Form1.Login_gender;
            labelFirstName.Text = Form1.Login_fname;
            labelLastName.Text = Form1.Login_lname;
            labelPhone.Text = Form1.Login_phone;
            labelUsername.Text = Form1.Login_username;
            labelRole.Text = Form1.L_role;
        }


        

        public void Create()
        {
            //assign the properties of the AddProduct class to the textbox and trim user input
            profile.password = txtPassword.Text.Trim();
            profile.id = Form1.Login_username;
            txtConfirmPassword.Text.Trim();
           

            //assign uidExist to the method in AddUsers class
            bool passwordSame = profile.password_verification();
            string oldPassword = profile.oldPassword;

            if (profile.password == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all field");
                return;
            }

            if (profile.password != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
                return;
            }

            if (profile.password.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more");
                return;
            }

            //check if username exist
            if (oldPassword != txtOldPassword.Text)
            {
                MessageBox.Show("Old Password is incorrect");
                return;
            }

            //call the method in the AddProduct class
            profile.updatePassword();
            MessageBox.Show("Password Updated");

            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtOldPassword.Text = "";
        }

        
    }
}
