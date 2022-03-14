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
    public partial class UpdatePrice : KryptonForm
    {

        PriceAjustments priceAdj = new PriceAjustments();

        public UpdatePrice(string id, string price, string item,string description)
        {
            InitializeComponent();

            txtMagId.Text = id;
            txtMagPrice.Text = price;
            lblItem.Text = item;
            lblDesc.Text = description;
        }


        //function to update the product price
        private void updatePrice()
        {
            if (txtMagPrice.Text == "")
            {
                MessageBox.Show("Please enter Price");

                return;
            }



            priceAdj.price = txtMagPrice.Text;
            priceAdj.id = txtMagId.Text;
            priceAdj.adjustPrice();
            setPriceHistory();
            MessageBox.Show("Stock Updated");

            txtMagPrice.Text = "";

            this.Close();
        }

        //set the price of the price
        private void setPriceHistory()
        {
            priceAdj.price = txtMagPrice.Text;
            priceAdj.item = lblItem.Text;
            priceAdj.description = lblDesc.Text;
            priceAdj.setPriceHistory();
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void txtMagPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtMagPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
