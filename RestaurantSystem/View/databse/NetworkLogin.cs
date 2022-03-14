using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View.databse
{
    public partial class NetworkLogin : Form
    {
        public NetworkLogin()
        {
            InitializeComponent();
        }

        private void NetworkLogin_Load(object sender, EventArgs e)
        {

        }

        private void login()
        {
           string id = Properties.Settings.Default.netID;
            string pwd = Properties.Settings.Default.netPassword;
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all field");
               
            } else
            {
                if (id == txtUser.Text && pwd == txtPassword.Text)
                {
                    DatabaseConn frm = new DatabaseConn();
                    frm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
            }

           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
