using ComponentFactory.Krypton.Toolkit;
using RestaurantSystem.Controller;
using RestaurantSystem.View.report;
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
    public partial class Totalreport : KryptonForm
    {
        TotalReport report = new TotalReport();
        Dashboard dash = new Dashboard();

        public Totalreport()
        {
            InitializeComponent();
        }

        private void Totalreport_Load(object sender, EventArgs e)
        {
           
        }
       



        //for employee sales report
        private void btnSales_Click(object sender, EventArgs e)
        {
            Salesreportgraph report = new Salesreportgraph();
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employeereport report = new Employeereport();
            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eachproductreport report = new Eachproductreport();
            report.ShowDialog();
        }

        private void btnSalesProductsReport_Click(object sender, EventArgs e)
        {
            
              ProductSalesReport user = new ProductSalesReport();
              user.ShowDialog();
            
        }

        private void btnEachProductSalesReport_Click(object sender, EventArgs e)
        {
            ProductEachSalesReport user = new ProductEachSalesReport();
            user.ShowDialog();
        }
    }
}
