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
    public partial class QantityHistorys : Form
    {
        public QantityHistorys()
        {
            InitializeComponent();
        }

        private void QantityHistorys_Load(object sender, EventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'DataSetQuantityHistory.quantityhistory' table. You can move, or remove it, as needed.
                this.quantityhistoryTableAdapter.Fill(this.DataSetQuantityHistory.quantityhistory);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Connection Error");
            }
        }
    }
}
