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
    public partial class Addproduct : KryptonForm
    {
        //instance of the AddProduct class
        AddProduct product = new AddProduct();

        //instance of the Adjustment history class
        QuantityAdjustments qtyAdj = new QuantityAdjustments();
        PriceAjustments priceAdj = new PriceAjustments();

        public Addproduct()
        {
            InitializeComponent();
            getCatData();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //Invoke function in this class
                Create();

            }
            catch (Exception)
            {

                MessageBox.Show("Error product001: something went wrong");
            }
        }


        private void btnAddClear_Click(object sender, EventArgs e)
        {
            product.productName = txtProductName.Text = "";
            product.price = txtProductPrice.Text = "";
            product.description = txtProductDescription.Text = "";
        }


        //method to put the data to the combobox
        public void getCatData()
        {
            //comboCategory.DataSource = null;
            try
            {

            product.getCat();
            comboCategory.DataSource = product.dt;
            comboCategory.DisplayMember = "cat_name";
            comboCategory.ValueMember = "Cat_id";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void Create()
        {
            try
            {

            //assign the properties of the AddProduct class to the textbox and trim user input
            product.productName = txtProductName.Text.Trim();
            product.price = txtProductPrice.Text.Trim();
            product.description = txtProductDescription.Text.Trim();
            product.category = comboCategory.Text.Trim();
            product.quantity = txtProductQuantity.Text.Trim();

            if (product.productName == "" || product.price == "" || product.description == "" || product.quantity == "")
            {
                MessageBox.Show("Please fill all field");
                return;
            }

            //call the method in the AddProduct class
            product.addProduct();
            setQuantityHistory();
            setPriceHistory();
            MessageBox.Show("New product created");

            product.productName = txtProductName.Text = "";
            product.price = txtProductPrice.Text = "";
            product.description = txtProductDescription.Text = "";
            product.quantity = txtProductQuantity.Text = "";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void setQuantityHistory()
        {
            qtyAdj.item = txtProductName.Text;
            qtyAdj.quantity = txtProductQuantity.Text;
            qtyAdj.description = txtProductDescription.Text;
            qtyAdj.setQuantityHistory();
        }


        private void setPriceHistory()
        {
            priceAdj.item = txtProductName.Text;
            priceAdj.price = txtProductPrice.Text;
            priceAdj.description = txtProductDescription.Text;
            priceAdj.setPriceHistory();
        }

        //acept only numbers
        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (ch == 46 && txtProductPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //accept only numbers
        private void txtProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
