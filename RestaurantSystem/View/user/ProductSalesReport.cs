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
    public partial class ProductSalesReport : KryptonForm
    {
        ProductSalesReports prod = new ProductSalesReports();

        public ProductSalesReport()
        {
            InitializeComponent();
        }

        private void ProductSalesReport_Load(object sender, EventArgs e)
        {
            //hide the id column in the datagrid
            //dataGridViewAutoComplete.Columns["ID"].Visible = false;
            //hide the customer datagridview
            dataGridViewAutoComplete.Visible = false;
        }

        //textcomplete auto complete
        #region AUTOCOMPLETE
        //autocomplete
        /*private void autoComple()
        {
            try
            {

                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();


               prod.getProduct();

               foreach (DataRow row in prod.dat.Rows)
                {

                    string newLine = Environment.NewLine;
                    string prod = row["pro_name"].ToString();

                    coll.Add(prod );

                }

               txtSearch.AutoCompleteCustomSource = coll;
            }
            catch (Exception)
            {

               
            }
        }

    */

        #endregion

        #region show customer names
        private void datagridAutocomplete()
        {
            prod.dat.Clear();
            prod.product = txtSearch.Text.Trim().Replace("'","///");
            prod.getProduct();
            dataGridViewAutoComplete.DataSource = prod.dat;

            //hide the id column in the datagrid
            dataGridViewAutoComplete.Columns["ID"].Visible = false;
        }
        #endregion

        //customer datagrid validate
        #region Customer Datagrid
        private void validateCustomerDatagrid()
        {
            
                if (txtSearch.Text != "" || txtSearch.Text != null)
                {
                    dataGridViewAutoComplete.Visible = true;

                    datagridAutocomplete(); //call the search customer function

                }

                if (txtSearch.Text == "" || String.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridViewAutoComplete.Visible = false;
                    dataGridViewAutoComplete.DataSource = null;
                    dataGridViewAutoComplete.Rows.Clear();
                    dataGridViewAutoComplete.Refresh();


                    return;
                }
            
           
        }
        #endregion

        //GET THE PRODUCT DATE
        private void getProductReport()
        {
            try
            {

                prod.dt.Clear();
                prod.fromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
                prod.toDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
                prod.product = txtSearch.Text;
                prod.getProductReport(); //get the product
                dataGridViewProductReport.DataSource = prod.dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }
        }

        //calculate all the totals
        public void calcTotalAmount()
        {
            //calculate the datagridview total amount
            double sum = 0;
            for (int i = 0; i < dataGridViewProductReport.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[4].Value);
            }

            //this format the numbers to make it easier to read
            lblGrandTotal.Text = String.Format("₵ {0:n}", sum);
        }


       


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                validateCustomerDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter the product");
                return;
            }
            getProductReport();
            calcTotalAmount();
        }

        private void dataGridViewAutoComplete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewAutoComplete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //assign the value to the label and textbox
                    //txtAutoComplete.Text = (dataGridViewAutoComplete.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtSearch.Text = (dataGridViewAutoComplete.Rows[e.RowIndex].Cells[1].Value.ToString());

                    dataGridViewAutoComplete.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("customer: Something went wrong");

            }
        }

        private void dataGridViewAutoComplete_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridViewAutoComplete.Visible = false;
        }
    }

}
