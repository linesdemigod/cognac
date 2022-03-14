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
    public partial class PriceAjustment : KryptonForm
    {
        //Instance of manageuser class
        PriceAjustments priceAdj = new PriceAjustments();

        public PriceAjustment()
        {
            InitializeComponent();
        }

        private void PriceAjustment_Load(object sender, EventArgs e)
        {
      

            getProductData();


        }
       

        //method to put the data to the gridviewdata
        public void getProductData()
        {

            priceAdj.getProduct();
            dataGridViewProduct.DataSource = priceAdj.dt;

        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;
                
               
                //code for the update
                if (dataGridViewProduct.Columns[e.ColumnIndex].HeaderText == "Update")
                {

                    string id, price, item, description;

                    id = dataGridViewProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    item = dataGridViewProduct.Rows[e.RowIndex].Cells["Item"].Value.ToString();
                    price = dataGridViewProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    description = dataGridViewProduct.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                    UpdatePrice user = new UpdatePrice(id,  price, item, description);
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
            DataView dv = priceAdj.dt.DefaultView;
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
