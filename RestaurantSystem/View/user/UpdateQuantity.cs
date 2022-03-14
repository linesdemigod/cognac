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
    
    public partial class UpdateQuantity : KryptonForm
    {
        QuantityAdjustments qtyAdj = new QuantityAdjustments();

        public UpdateQuantity(string id, string quantity, string item, string description)
        {
            InitializeComponent();

            txtMagId.Text = id;
            lblItem.Text = item;
            lblCurrentStock.Text = quantity;
            lblDesc.Text = description;
        }


        //function to update the stock quantity
        private void updateStock()
        {
            if (txtMagQuantity.Text == "")
            {
                MessageBox.Show("Please enter the stock quantity");

                return;
            }

            if (comboAddSub.Text == "")
            {
                MessageBox.Show("Add or Substract from the stock");

                return;
            }


            qtyAdj.quantity = txtMagQuantity.Text;
            qtyAdj.id = txtMagId.Text;
            qtyAdj.productOperator = comboAddSub.Text;
            qtyAdj.updateStock();
            qtyHistory();
            MessageBox.Show("Stock Updated");

            txtMagQuantity.Text = "";

            this.Close();

        }

        public void qtyHistory()
        {
            qtyAdj.quantity = txtMagQuantity.Text;
            qtyAdj.item = lblItem.Text;
            qtyAdj.description = lblDesc.Text;
            qtyAdj.setQuantityHistory();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            
            updateStock();
            

        }

        private void txtMagQuantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMagQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
