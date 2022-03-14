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
    public partial class Productreport : KryptonForm
    {
        //instance of the report class
        ProductReport report = new ProductReport();

        public Productreport()
        {
            InitializeComponent();
        }




        private void Productreport_Load(object sender, EventArgs e)
        {
           
            //getProductReports();  //call the get getproduct method to populate the datagrid

            calcTotalAmount(); //calculate all the totals
        }

        //method to populate the datagirdview
        public void getProductReports()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.getProductReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

        //method to handle the search button event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                getReports(); //method to filter the date between a specific period
                calcTotalAmount(); //calculate all the totals


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
        }

        //method to filter the sales from specific date to date
        public void getReports()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.fromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            report.toDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");

            report.getProductReportFilter();
            dataGridViewProductReport.DataSource = report.dt;
        }

        //calculate all the totals
        public void calcTotalAmount()
        {
            //calculate the datagridview total amount
            double sum = 0;
            double gross = 0;
            double vat = 0;
            double discount = 0;
            for (int i = 0; i < dataGridViewProductReport.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[5].Value);
                gross += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[2].Value);
                vat += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[3].Value);
                discount += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[4].Value);
            }

            //this format the numbers to make it easier to read
            lblGrandTotal.Text = String.Format("₵ {0:n}", sum);
            lblSubTotal.Text = String.Format("₵ {0:n}", gross);
            lblVat.Text = String.Format("₵ {0:n}", vat);
            lblDiscount.Text = String.Format("₵ {0:n}", discount);
        }

        //refresh the datagrid when clicked
        private void btnReferesh_Click(object sender, EventArgs e)
        {
            getProductReports();
            calcTotalAmount();
        }

        
        //method which handle the daily sales report
        public void getDailyReport()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.dailyReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

        //method which handle the weekly sales report
        public void getWeeklyReport()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.weeklyReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

        //method to get monthly sales report
        public void getMonthlyReport()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.monthlyReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

        //get the yearly report
        private void getYearlyReport()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.getYear  = comboboxYear.Text;
            report.getReportByYear();
            
            dataGridViewProductReport.DataSource = report.dt;
            calcTotalAmount();
        }

        //filter by the year
        private void comboboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            getYearlyReport();
            calcTotalAmount();
        }

        //radio button which handle the daily sales report
        private void rdDailyReport_CheckedChanged(object sender, EventArgs e)
        {
            getDailyReport();
            calcTotalAmount();
        }

        //radio button which handle the weekly sales report
        private void rdWeeklyReport_CheckedChanged(object sender, EventArgs e)
        {
            getWeeklyReport();
            calcTotalAmount();
        }

        //radio button which handle the monthly sales report
        private void rdMonthlyReport_CheckedChanged(object sender, EventArgs e)
        {
            getMonthlyReport();
            calcTotalAmount();
        }

        //this handle the save to excel when clicked
        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                saveToExcel();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //save to excel
        public void saveToExcel()
        {
            //Export to excel
            saveFileDialog.InitialDirectory = "D";
            saveFileDialog.Title = "Save as Excel File";
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Excel Files (2007|*.xlsx|Excel Files(.CSV)|*.csv";

            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                //change properties
                excelApp.Columns.ColumnWidth = 28;
                for (int i = 1; i < dataGridViewProductReport.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridViewProductReport.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridViewProductReport.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewProductReport.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridViewProductReport.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelApp.Columns.AutoFit();
                excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();

                MessageBox.Show("Export Successful");
            }


            Cursor.Current = Cursors.Default;
        }

       
    }
}
