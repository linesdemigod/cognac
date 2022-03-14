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
    public partial class EntireSalesReports : Form
    {
        public EntireSalesReports()
        {
            InitializeComponent();
        }

        private void EntireSalesReports_Load(object sender, EventArgs e)
        {
           

            this.reportViewer1.RefreshReport();
        }

        private void getData()
        {
            try
            {

                // TODO: This line of code loads data into the 'DataSetEntireSaleReport.orders' table. You can move, or remove it, as needed.
                this.ordersTableAdapter.Fill(this.DataSetEntireSaleReport.orders, dateFrom.Value, dateTo.Value);
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
