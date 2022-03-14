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
    public partial class ProductEachSalesReport : KryptonForm
    {
        ProductSalesReports prod = new ProductSalesReports();

        public ProductEachSalesReport()
        {
            InitializeComponent();
        }

        private void ProductEachSalesReport_Load(object sender, EventArgs e)
        {

        }

        //GET THE MULITPLE PRODUCT DATA
        private void getProductsReport()
        {
            try
            {

                prod.datt.Clear();
                prod.fromDate = dateFrom.Value.ToString("yyyy-MM-dd");
                prod.toDate = dateTo.Value.ToString("yyyy-MM-dd");
                prod.getProductsReport(); //get the product
                dataGridViewMultiple.DataSource = prod.datt;
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }
        }

        //calculate all the totals
        public void calcMultipleTotalAmount()
        {
            //calculate the datagridview total amount
            double sum = 0;
            for (int i = 0; i < dataGridViewMultiple.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridViewMultiple.Rows[i].Cells[4].Value);
            }

            //this format the numbers to make it easier to read
            lblTotalAmountMultiple.Text = String.Format("₵ {0:n}", sum);
        }

        private void btnSearchMultiple_Click(object sender, EventArgs e)
        {
            getProductsReport();
            calcMultipleTotalAmount();
        }
    }
}
