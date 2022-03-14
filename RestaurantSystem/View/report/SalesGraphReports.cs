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

namespace RestaurantSystem.View.report
{
    public partial class SalesGraphReports : KryptonForm
    {

        DashboardGraph graph = new DashboardGraph();
        TotalReport report = new TotalReport();

        public SalesGraphReports()
        {
            InitializeComponent();
        }

        private void SalesGraphReports_Load(object sender, EventArgs e)
        {
            getBestSellingItem();
            getChartResult();
            getWorstSellingItem();
            totalSales();
            getAllExpenses();

            getProfit();

        }

        private void getChartResult()
        {

            try
            {
                graph.getChartResult();

                foreach (DataRow row in graph.dt.Rows)
                {
                    string item = row["Item"].ToString();
                    string qty = row["Qty"].ToString();


                    chartProduct.Series["Items"].Points.AddXY(item, qty);
                }
                
               
            }
            catch (Exception)
            {

                MessageBox.Show("Error:something went wrong");
            }
            
        }

        private void getBestSellingItem()
        {
            try
            {

            graph.getBestSellingItem();
            lblBestItem.Text = graph.product;
            }
            catch (Exception)
            {

                MessageBox.Show("Error bestselling: Something went wrong");
            }
        }

        private void getWorstSellingItem()
        {
            try
            {
                graph.getWorstSellingItem();
                lblWorstItem.Text = graph.product;
            }
            catch (Exception)
            {

                MessageBox.Show("Error bestselling: Something went wrong");
            }
            
        }


        private void totalSales()
        {
            try
            {
                //get the total report
                report.getTotalSalesReport();
                double income = Convert.ToDouble(report.totalSales);
                lblTotalSales.Text = String.Format("₵ {0:n}", income);
                lblIncome.Text = String.Format("{0:n}", income);

                //get the daily sales
                report.getDailySalesReport();
                lblDailySales.Text = String.Format("₵ {0:n}", report.dailySales);

                //get the weekly sales
                report.getWeeklySalesReport();
                lblWeeklySales.Text = String.Format("₵ {0:n}", report.weeklySales);

                //get the monthly sales
                report.getMonthlySalesReport();
                lblMonthlySales.Text = String.Format("₵ {0:n}", report.monthlySales);
            }
            catch (Exception ex)
            {

               Console.Write(ex.Message);
            }


        }

        //get all the expenses
        private void getAllExpenses()
        {
            try
            {

                graph.getTotalExpenses();
                double expense = Convert.ToDouble(graph.totalExpenses);
                lblTotalExpenses.Text = String.Format("{0:#,###0}", expense);
            }
            catch (ArgumentNullException ex)
            {

                throw new ArgumentNullException("error", ex.Message);
            }

            
        }

        private void getProfit()
        {
            try
            {

            double result = Convert.ToDouble(lblIncome.Text) - Convert.ToDouble(lblTotalExpenses.Text);
            lblProfit.Text = String.Format("₵ {0:n}", result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

       
    }
}
