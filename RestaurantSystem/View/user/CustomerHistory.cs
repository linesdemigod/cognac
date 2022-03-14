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
    public partial class CustomerHistory : KryptonForm
    {
        //INSTANCE OF THE CUSTOMERS CLASS
        Customers cust = new Customers();

        public CustomerHistory()
        {
            InitializeComponent();
        }

        private void CustomerHistory_Load(object sender, EventArgs e)
        {
            getCustomers();
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

        //get all customer order
        //function to get the values of the sales using the ord_bill_number
        private void getCusterOrders()
        {

            try
            {
                if (dataGridViewCustomer.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewCustomer.Rows)
                    {
                        if (row.Selected == true)
                        {
                            cust.id = Convert.ToString(row.Cells["ID"].Value);
                            cust.getAllCustomerOrders();
                            dataGridViewOrder.DataSource = cust.dat;

                            lblCustName.Text = (row.Cells["Firstname"].Value.ToString() + " " + row.Cells["Lastname"].Value.ToString());


                        }

                    }
                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);

            }

        }

        //display order with receipt number on the datagrid
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.Rows.Count != 0 || dataGridViewOrder != null)
            {

                getCusterOrders();
                calcTotalAmount();

            }
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code for the update
                if (dataGridViewOrder.Columns[e.ColumnIndex].HeaderText == "Action")
                {

                    string id, vat, disc,subtotal, net, name;

                    id = dataGridViewOrder.Rows[e.RowIndex].Cells["IDCust"].Value.ToString();
                    vat = dataGridViewOrder.Rows[e.RowIndex].Cells["VAT"].Value.ToString();
                    disc = dataGridViewOrder.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
                    subtotal = dataGridViewOrder.Rows[e.RowIndex].Cells["Gross"].Value.ToString();
                    net = dataGridViewOrder.Rows[e.RowIndex].Cells["Net"].Value.ToString();
                    name = lblCustName.Text;
                   

                    CustomerHistoryProduct user = new CustomerHistoryProduct(id, vat, disc, subtotal, net, name);
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }
        }

        //calculate the total sum of each column
        //calculate all the totals
        public void calcTotalAmount()
        {
            //calculate the datagridview total amount
            double net = 0;
            double vat = 0;
            double discount = 0;
            double gross = 0;
            for (int i = 0; i < dataGridViewOrder.Rows.Count; i++)
            {
                gross += Convert.ToDouble(dataGridViewOrder.Rows[i].Cells[2].Value);
                vat += Convert.ToDouble(dataGridViewOrder.Rows[i].Cells[3].Value);
                discount += Convert.ToDouble(dataGridViewOrder.Rows[i].Cells[4].Value);
                net += Convert.ToDouble(dataGridViewOrder.Rows[i].Cells[5].Value);
            }

            //this format the numbers to make it easier to read
            lblGrandTotal.Text = String.Format("₵ {0:n}", net);
            lblSubTotal.Text = String.Format("₵ {0:n}", gross);
            lblVat.Text = String.Format("₵ {0:n}", vat);
            lblDiscount.Text = String.Format("₵ {0:n}", discount);

        }
    }
}
