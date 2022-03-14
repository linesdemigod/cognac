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
    public partial class Addcategory : KryptonForm
    {
        AddCategory cat = new AddCategory();

        public Addcategory()
        {
            InitializeComponent();
        }
        
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                //Invoke function in this class
                Create();


            }
            catch (Exception ex)
            {

               Console.Write(ex.Message);
            }
        }


        public void Create()
        {
            //assign the properties of the AddCategory class to the textbox and trim user input
            cat.category = txtCategory.Text.Trim();

            if (cat.category == "")
            {
                MessageBox.Show("Please enter category");
                return;
            }

            //call the method in the AddUsers class
            cat.createCategory();
            MessageBox.Show("New Category created");

            //clear textbox after successful insert
            cat.category = txtCategory.Text = "";
        }

       
    }
}
