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
    public partial class CustomerTemp : Form
    {
        Tempcart report = new Tempcart();

        public CustomerTemp()
        {
            InitializeComponent();
        }

        private void CustomerTemp_Load(object sender, EventArgs e)
        {
            getCustomerData();
        }

        //get the customer names
        public void getCustomerData()
        {
            comboEmployee.DataSource = null;
            report.getCustomer();
            comboEmployee.DataSource = report.dat;
            comboEmployee.DisplayMember = "Customer";
            //comboEmployee.ValueMember = "users_id";
        }

        //method to populate the datagirdview
        public void getProductReports()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.getCustomerReport();
            dataGridViewProductReport.DataSource = report.dt;
        }

        //method to filter the sales from specific date to date
        public void getReports()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
            report.custName = comboEmployee.Text;
            report.fromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            report.toDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");

            report.getCustomerReport();
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
                sum += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[6].Value);
                gross += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[3].Value);
                vat += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[4].Value);
                discount += Convert.ToDouble(dataGridViewProductReport.Rows[i].Cells[5].Value);
            }

            //this format the numbers to make it easier to read
            lblGrandTotal.Text = String.Format("₵ {0:n}", sum);
            lblSubTotal.Text = String.Format("₵ {0:n}", gross);
            lblVat.Text = String.Format("₵ {0:n}", vat);
            lblDiscount.Text = String.Format("₵ {0:n}", discount);
        }

        //insert ordered item to db
        #region into bill datagrid
        public void deleteTempItem()
        {
            try
            {


                if (dataGridViewProductReport == null || dataGridViewProductReport.Rows.Count == 0)
                {
                    
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridViewProductReport.Rows)
                    {

                        report.id = Convert.ToString(row.Cells["ID"].Value);

                        report.deleteFromTemp();


                    }

                    clearDataGrid();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

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

        private void clearDataGrid()
        {
            dataGridViewProductReport.DataSource = null;
            dataGridViewProductReport.Rows.Clear();
            report.dt.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                deleteTempItem();
               
            }
        }

    }
}
