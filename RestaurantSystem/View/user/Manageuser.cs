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
    public partial class Manageuser : KryptonForm
    {
        //Instance of manageuser class
        ManageUser manageUser = new ManageUser();

        public Manageuser()
        {
            InitializeComponent();
        }

        //when the form load to refresh the table
        private void Manageuser_Load(object sender, EventArgs e)
        {
            getUsersData();
            setupUserAccess();
        }

        //validate Admin and manager
        public void setupUserAccess()
        {
            //instances of the permission class
            UserPermissions per = new UserPermissions();

            //the role the user logged in
            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

            //instance of the userpermission class
            per.getPermission();

            foreach (DataRow row in per.dt.Rows)
            {
                //assign the result to the a variable
                bool permission = Convert.ToBoolean(row["per_value"].ToString());
                string name = row["per_name"].ToString();
                int role = Convert.ToInt32(row["role_id"]);

                //check if the user logged and the priviledge given
                if (userLoggedInRole == role && name == "delete user")
                {
                    dataGridViewMagUser.Columns["DeleteColumn"].Visible = permission;

                }

                if (userLoggedInRole == role && name == "update user")
                {
                    dataGridViewMagUser.Columns["UpdateColumn"].Visible = permission;

                }

                if (userLoggedInRole == role)
                {
                    dataGridViewMagUser.Columns["PasswordColumn"].Visible = false;

                }

            }
                

        }


        //method to put the data to the gridviewdata
        public void getUsersData()
        {
            manageUser.rol = Form1.Login_role;

            manageUser.getUsers();
            
            dataGridViewMagUser.DataSource = manageUser.dt;
        }

        


        private void dataGridViewMagUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewMagUser.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewMagUser.Rows[e.RowIndex].Cells["IDColumn"].Value);
                        manageUser.id = id.ToString();
                        if (Convert.ToInt32(manageUser.id) > 0)
                        {
                            //call the deleteUser method in the manageuser class
                            manageUser.deleteUser();
                            MessageBox.Show("User account deleted");

                           
                        }

                    }
                }


                //code for the update
                if (dataGridViewMagUser.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    string id, role, fname, lname, phone, gender, username, password;

                    id = dataGridViewMagUser.Rows[e.RowIndex].Cells["IDColumn"].Value.ToString();
                    role = dataGridViewMagUser.Rows[e.RowIndex].Cells["RoleColumn"].Value.ToString();
                    fname = dataGridViewMagUser.Rows[e.RowIndex].Cells["FirstnameColumn"].Value.ToString();
                    lname = dataGridViewMagUser.Rows[e.RowIndex].Cells["LastnameColumn"].Value.ToString();
                    phone = dataGridViewMagUser.Rows[e.RowIndex].Cells["PhoneColumn"].Value.ToString();
                    gender = dataGridViewMagUser.Rows[e.RowIndex].Cells["GenderColumn"].Value.ToString();
                    username = dataGridViewMagUser.Rows[e.RowIndex].Cells["UsernameColumn"].Value.ToString();
                    password = dataGridViewMagUser.Rows[e.RowIndex].Cells["PasswordColumn"].Value.ToString();

                    Updateuser user = new Updateuser(id, role, fname, lname, phone, gender, username, password);
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Error User002: Something went wrong");
            }

        }

       

        private void Manageuser_Activated(object sender, EventArgs e)
        {
            getUsersData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getUsersData();
        }

        private void dataGridViewMagUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

       
    }
}
