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
    public partial class QuantityAdjustment : KryptonForm
    {
        QuantityAdjustments qtyAdj = new QuantityAdjustments();

        public QuantityAdjustment()
        {
            InitializeComponent();
        }

        private void QuantityAdjustment_Load(object sender, EventArgs e)
        {
           

            getProductData();
        }

        //validate Admin and manager
       

        //method to put the data to the gridviewdata
        public void getProductData()
        {
            
            qtyAdj.getProduct();
            dataGridViewProduct.DataSource = qtyAdj.dt;

        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;


                //code for the update
                if (dataGridViewProduct.Columns[e.ColumnIndex].HeaderText == "Update")
                {

                    string id, item, quantity, description;

                    id = dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    item = dataGridViewProduct.Rows[e.RowIndex].Cells["Item"].Value.ToString();
                    quantity = dataGridViewProduct.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                    description = dataGridViewProduct.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                    UpdateQuantity user = new UpdateQuantity(id, quantity, item, description);
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error prod cell: Something went wrong");
            }
        }

        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void search()
        {
            string str = txtProductSearch.Text.Trim().Replace("'", "\\");
            DataView dv = qtyAdj.dt.DefaultView;
            dv.RowFilter = string.Format("pro_name LIKE '%" + str + "%'");
            dataGridViewProduct.DataSource = dv.ToTable();
        }
        #endregion

        private void btnRefreshes_Click(object sender, EventArgs e)
        {
            getProductData();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
