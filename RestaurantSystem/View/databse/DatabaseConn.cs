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

namespace RestaurantSystem.View.databse
{
    public partial class DatabaseConn : Form
    {
        Database db = new Database();

        public DatabaseConn()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
           
        }

        

        private void checkConnection()
        {
            try
            {
                db.saveConnectionString("RestaurantSystem.Properties.Settings.foodjointConnectionString", db.connection);
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
        }

        private void saveDBConnection()
        {
            try
            {
               
                    Properties.Settings.Default.dbSource = txtServer.Text;
                    Properties.Settings.Default.port = txtPort.Text;
                    Properties.Settings.Default.user = txtUserID.Text;
                    Properties.Settings.Default.db = txtDatabasae.Text;
                    Properties.Settings.Default.ssl = txtSSL.Text;
                    Properties.Settings.Default.password = txtPassword.Text;

                    Properties.Settings.Default.Save();
                    checkConnection();
                    MessageBox.Show("Saved");
             
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to save?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {

                saveDBConnection();
            } else
            {
                return;
            }
        }
    }
}
