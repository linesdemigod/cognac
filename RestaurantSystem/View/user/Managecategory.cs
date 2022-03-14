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
    public partial class Managecategory : KryptonForm
    {
        //Instance of managecategory class
        ManageCategory manageCat = new ManageCategory();

        public Managecategory()
        {
            InitializeComponent();
        }


        private void Managecategory_Load(object sender, EventArgs e)
        {
            getCategoryData();
            setupUserAccess();
        }


        //validate Admin and manager
        public void setupUserAccess()
        {

            //instances of the permission class
            UserPermissions per = new UserPermissions();

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

            per.getPermission();

            foreach (DataRow row in per.dt.Rows)
            {
                //assign the result to the a variable
                bool permission = Convert.ToBoolean(row["per_value"].ToString());
                string name = row["per_name"].ToString();
                int role = Convert.ToInt32(row["role_id"]);

                //check if the user logged and the priviledge given
                if (userLoggedInRole == role && name == "delete cat")
                {
                    dataGridViewCat.Columns["DeleteColumn"].Visible = permission;

                }

                if (userLoggedInRole == role && name == "update cat")
                {
                    dataGridViewCat.Columns["UpdateColumn"].Visible = permission;

                }
            }
            
        }


        //method to put the data to the gridviewdata
        public void getCategoryData()
        {
            //dataGridViewCat.DataSource = null;
            manageCat.getCategory();
            dataGridViewCat.DataSource = manageCat.dt;
        }

        private void dataGridViewCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewCat.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewCat.Rows[e.RowIndex].Cells["IDColumn"].Value);
                        manageCat.id = id.ToString();
                        if (Convert.ToInt32(manageCat.id) > 0)
                        {
                            //call the deleteUser method in the managecategory class
                            manageCat.deleteCategory();
                            MessageBox.Show("Category deleted");
                        }

                    }
                }


                //code for the update
                if (dataGridViewCat.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    string id, categoryName;

                    id = dataGridViewCat.Rows[e.RowIndex].Cells["IDColumn"].Value.ToString();
                    categoryName = dataGridViewCat.Rows[e.RowIndex].Cells["CategoryColumn"].Value.ToString();

                    Updatecategory user = new Updatecategory(id, categoryName );
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Error Cat002: Something went wrong");
            }

        }

      

        private void Managecategory_Activated(object sender, EventArgs e)
        {
            getCategoryData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getCategoryData();
        }

        
    }
}
