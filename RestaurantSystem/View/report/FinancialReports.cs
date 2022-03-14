using ComponentFactory.Krypton.Toolkit;
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
    public partial class FinancialReports : KryptonForm
    {
        public FinancialReports()
        {
            InitializeComponent();
        }

        private void FinancialReports_Load(object sender, EventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'DataSetFinancialReport.Grand' table. You can move, or remove it, as needed.
                this.GrandTableAdapter.Fill(this.DataSetFinancialReport.Grand);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Salaries' table. You can move, or remove it, as needed.
                this.SalariesTableAdapter.Fill(this.DataSetFinancialReport.Salaries);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Rent' table. You can move, or remove it, as needed.
                this.RentTableAdapter.Fill(this.DataSetFinancialReport.Rent);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Maintenance' table. You can move, or remove it, as needed.
                this.MaintenanceTableAdapter.Fill(this.DataSetFinancialReport.Maintenance);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Miscellaneous' table. You can move, or remove it, as needed.
                this.MiscellaneousTableAdapter.Fill(this.DataSetFinancialReport.Miscellaneous);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Other' table. You can move, or remove it, as needed.
                this.OtherTableAdapter.Fill(this.DataSetFinancialReport.Other);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Tax' table. You can move, or remove it, as needed.
                this.TaxTableAdapter.Fill(this.DataSetFinancialReport.Tax);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Item' table. You can move, or remove it, as needed.
                this.ItemTableAdapter.Fill(this.DataSetFinancialReport.Item);
                // TODO: This line of code loads data into the 'DataSetFinancialReport.Utility' table. You can move, or remove it, as needed.
                this.UtilityTableAdapter.Fill(this.DataSetFinancialReport.Utility);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                MessageBox.Show("Connection Error");
            }
        }
    }
}
