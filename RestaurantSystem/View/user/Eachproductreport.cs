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
    public partial class Eachproductreport : KryptonForm
    {
        EachProductReport report = new EachProductReport();

        public Eachproductreport()
        {
            InitializeComponent();
        }

        private void Eachproductreport_Load(object sender, EventArgs e)
        {
            getEmployeeData();
            
        }

        //get the employee names
        public void getEmployeeData()
        {
            comboEmployee.DataSource = null;
            report.getEmployee();
            comboEmployee.DataSource = report.dat;
            comboEmployee.DisplayMember = "Cashier";
            //comboEmployee.ValueMember = "users_id";
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


        //method to filter the sales from specific date to date
        public void getReports()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.empName = comboEmployee.Text;
            report.fromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            report.toDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");

            report.getProductReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

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


        //calculate all the totals
        public void calcTotalAmount()
        {
            //calculate the datagridview total amount
            double sum = 0;
            for (int i = 0; i < dataGridViewProductReport.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[3].Value);
            }

            //this format the numbers to make it easier to read
            lblGrandTotal.Text = String.Format("₵ {0:n}", sum);
        }

        private void btnReferesh_Click(object sender, EventArgs e)
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveToExcel();
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

        //method which handle the daily sales report
        public void getDailyReport()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.empName = comboEmployee.Text;
            report.dailyReport();
            dataGridViewProductReport.DataSource = report.dt;
        }


        //method which handle the weekly sales report
        public void getWeeklyReport()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.empName = comboEmployee.Text;
            report.weeklyReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

        //method to get monthly sales report
        public void getMonthlyReport()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.empName = comboEmployee.Text;
            report.monthlyReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

        private void rdDailyReport_CheckedChanged(object sender, EventArgs e)
        {
            getDailyReport();
            calcTotalAmount(); ;
        }

        private void rdWeeklyReport_CheckedChanged(object sender, EventArgs e)
        {
            getWeeklyReport();
            calcTotalAmount(); 
        }

        private void rdMonthlyReport_CheckedChanged(object sender, EventArgs e)
        {
            getMonthlyReport();
            calcTotalAmount();
        }
    }
}
