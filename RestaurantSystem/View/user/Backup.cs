using ComponentFactory.Krypton.Toolkit;
using RestaurantSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View.user
{
    public partial class Backup : KryptonForm
    {
        Backups backup = new Backups();

        public Backup()
        {
            InitializeComponent();
        }


        private void Backup_Load(object sender, EventArgs e)
        {
            setupUserAccess();
        }

        //validate Admin and manager
        public void setupUserAccess()
        {

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

            switch (userLoggedInRole)
            {
                case 2:
                    btnRestore.Enabled = false;

                    break;
                case 3:
                    btnRestore.Enabled = false;

                    break;
                default:

                    break;
            }

        }

        //backup the database when the buton is click
        private void btnBackup_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to backup? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {

                backup.createFolder();
                backup.backup();
                MessageBox.Show("Successful");

            }
            
        }
        

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Do you want to restore? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    backup.restore();
                    MessageBox.Show("Successful");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
