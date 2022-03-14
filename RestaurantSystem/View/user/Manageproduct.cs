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
    public partial class Manageproduct : KryptonForm
    {
        //Instance of manageuser class
        ManageProduct manageProduct = new ManageProduct();

        public Manageproduct()
        {
            InitializeComponent();

            //refresh the winform after successfully updating the account
            getProductData();

            setupUserAccess();
        }


        //validate Admin and manager
        public void setupUserAccess()
        {

            //instances of the permission class
            UserPermissions per = new UserPermissions();

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

           
            //call the method in the Userpermissions class
            per.getPermission();

            //loop through the resultset from the database
            foreach (DataRow row in per.dt.Rows)
            {
                //assign the result to the a variable
                bool permission = Convert.ToBoolean(row["per_value"].ToString());
                string name = row["per_name"].ToString();
                int role = Convert.ToInt32(row["role_id"]);

                //check if the user logged and the priviledge given
                if (userLoggedInRole == role && name == "update product")
                {
                    dataGridViewProduct.Columns["Update"].Visible = permission;
                    
                }

                if (userLoggedInRole == role && name == "delete product")
                {
                    dataGridViewProduct.Columns["Delete"].Visible = permission;

                }
                

            }

        }

        //method to put the data to the gridviewdata
        public void getProductData()
        {

            manageProduct.getProduct();
            dataGridViewProduct.DataSource = manageProduct.dt;

        }



        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewProduct.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value);
                        manageProduct.id = id.ToString();
                        if (Convert.ToInt32(manageProduct.id) > 0)
                        {
                            //call the deleteUser method in the manageuser class
                            manageProduct.deleteProduct();
                            MessageBox.Show("Product deleted");
                            getProductData();
                        }

                    }
                }


                //code for the update
                if (dataGridViewProduct.Columns[e.ColumnIndex].HeaderText == "Update")
                {

                    string id, category, item, description;

                    id = dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    category = dataGridViewProduct.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                    item = dataGridViewProduct.Rows[e.RowIndex].Cells["Item"].Value.ToString();
                    description = dataGridViewProduct.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                    Updateproduct user = new Updateproduct(id, category, item, description);
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error prod cell: Something went wrong");
            }

        }

        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void search()
        {
            //handle sql injection
            string str = txtProductSearch.Text.Trim().Replace("'", "\\");

            DataView dv = manageProduct.dt.DefaultView;
            dv.RowFilter = string.Format("pro_name LIKE '%" + str + "%'");
            dataGridViewProduct.DataSource = dv.ToTable();
        }
        #endregion

        private void btnRefreshes_Click(object sender, EventArgs e)
        {
            getProductData();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
