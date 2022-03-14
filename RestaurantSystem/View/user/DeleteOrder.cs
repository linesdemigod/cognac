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
    public partial class DeleteOrder : KryptonForm
    {
        ManageOrder order = new ManageOrder();
        Orders restore = new Orders();
        int scroll;

        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {

            getOrdersData();
            comboLimit.SelectedIndex = 0;
        }

       


        //method to put the data to the gridviewdata
        public void getOrdersData()
        {
            //order.billID = txtSearchBillNumber.Text;
            order.limit = 10;
            order.getOrder();
            dataGridViewOrders.DataSource = order.dt;
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewOrders.Columns[e.ColumnIndex].HeaderText == "Action")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        string id;
                        id = Convert.ToString(dataGridViewOrders.Rows[e.RowIndex].Cells["BillColumn"].Value);
                        order.id = id;

                        if (order.id == id)
                        {
                            //call the deleteUser method in the manageuser class
                            order.deleteOrder();
                            MessageBox.Show("Bill deleted");

                        }


                        getOrdersData();

                    }
                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
        }

        private void txtSearchBillNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {

                search();
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            scroll = order.scroll;
            scroll = scroll - order.limit;
            if (scroll <= 0)
            {
                scroll = 0;
            }
            order.ds.Clear();
            order.dta.Fill(order.ds, scroll, order.limit, "orders");
            //order.getOrder();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            scroll = order.scroll;
           
            scroll = scroll + order.limit;
            if (scroll > 50)
            {
                scroll = 50;
            }
            order.ds.Clear();
            order.dta.Fill(order.ds, scroll, order.limit, "orders");
            //order.getOrder();
        }

        private void comboLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.limit = Convert.ToInt32(comboLimit.Text);
            order.getOrder();
            //getOrdersData();
        }

        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void search()
        {
            string str = txtSearchBillNumber.Text.Trim().Replace("'", "\\");
            DataView dv = order.dt.DefaultView;
            dv.RowFilter = string.Format("ord_bill_number LIKE '%" + str + "%'");
            dataGridViewOrders.DataSource = dv.ToTable();
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getOrdersData();
        }
    }
}
