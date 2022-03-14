using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
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
    public partial class Salesreportgraph : KryptonForm
    {
        SalesReportGraph report = new SalesReportGraph();
        public Salesreportgraph()
        {
            InitializeComponent();
        }

        

        private void getYearReport()
        {
            report.year = comboboxYear.Text;
            report.getGraphSales();

            foreach (DataRow row in report.dt.Rows)
            {
                string month = row["created"].ToString();
                string values = row["countdata"].ToString();

                switch (month)
                {
                    case "1":
                        month = "Jan";
                        break;
                    case "2":
                        month = "Feb";
                        break;
                    case "3":
                        month = "Mar";
                        break;
                    case "4":
                        month = "Apr";
                        break;
                    case "5":
                        month = "May";
                        break;
                    case "6":
                        month = "Jun";
                        break;
                    case "7":
                        month = "Jul";
                        break;
                    case "8":
                        month = "Aug";
                        break;
                    case "9":
                        month = "Sep";
                        break;
                    case "10":
                        month = "Oct";
                        break;
                    case "11":
                        month = "Nov";
                        break;
                    default:
                        month = "Dec";
                        break;
                }

                chartSales.Series["Month"].Points.AddXY(month, values);

            }
        }

        private void Salesreportgraph_Load(object sender, EventArgs e)
        {
            //getChartResult();
        }

        private void comboboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartSales.Series["Month"].Points.Clear();
            
            getYearReport();
        }
    }
}
