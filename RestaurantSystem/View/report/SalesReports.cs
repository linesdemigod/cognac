using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View.report
{
    public partial class SalesReports : Form
    {
        public SalesReports()
        {
            InitializeComponent();
        }

        private void SalesReports_Load(object sender, EventArgs e)
        {
           

            this.reportViewer1.RefreshReport();
        }

        private void getData()
        {
            try
            {

                // TODO: This line of code loads data into the 'DataSetSalesReport.SaleReport' table. You can move, or remove it, as needed.
                this.SaleReportTableAdapter.Fill(this.DataSetSalesReport.SaleReport, dateFrom.Value, dateTo.Value);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                MessageBox.Show("Connection Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
