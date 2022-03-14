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
    public partial class ManageCustomer : KryptonForm
    {
        //INSTANCE OF THE CUSTOMERS CLASS
        Customers cust = new Customers();

        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
           
            getCustomers(); //call the method to get all the customers to the datagrid
        }

        //get the customers to the datagrid
        #region GET ALL CUSTOMERS
        private void getCustomers()
        {
            cust.dt.Clear();
            cust.getCustomers();
            dataGridViewCustomer.DataSource = cust.dt;
        }
        #endregion

        //perform delete or update
        #region DATAGRID CELL CLICK
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewCustomer.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewCustomer.Rows[e.RowIndex].Cells["ID"].Value);
                        cust.id = id.ToString();
                        if (Convert.ToInt32(cust.id) > 0)
                        {
                            //call the deleteUser method in the managecategory class
                            cust.deleteCustomer();
                            MessageBox.Show("Customer deleted");
                        }

                    }
                }


                //code for the update
                if (dataGridViewCustomer.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    string id, firstname, lastname, telephone, address;

                    id = dataGridViewCustomer.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    firstname = dataGridViewCustomer.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
                    lastname = dataGridViewCustomer.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                    telephone = dataGridViewCustomer.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                    address = dataGridViewCustomer.Rows[e.RowIndex].Cells["Address"].Value.ToString();

                    UpdateCustomer user = new UpdateCustomer(id, firstname, lastname, telephone, address);
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw new Exception("Somethin went wrong");
            }
        }
        #endregion


        //refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getCustomers();
        }

        #region Search
        public void search()
        {
            //handle sql injection
            string str = txtSearch.Text.Trim().Replace("'", "\\");

            DataView dv = cust.dt.DefaultView;
            dv.RowFilter = string.Format("cust_fname LIKE '%" + str + "%'");
            dataGridViewCustomer.DataSource = dv.ToTable();
        }
        #endregion

        //search 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
