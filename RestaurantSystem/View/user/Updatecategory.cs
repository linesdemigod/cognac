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
    public partial class Updatecategory : KryptonForm
    {

        //Instance of manageuser class
        ManageCategory manageCat = new ManageCategory();

        //variable for the columns
        string code, category;


        private void Updatecategory_Load(object sender, EventArgs e)
        {
            txtCategoryName.Text = category;
            txtCategoryId.Text = code;
        }



        public Updatecategory(string id, string categoryName)
        {
            InitializeComponent();

            code = id;
            category = categoryName;
        }


       

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Do you want to update? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    updateCategory();

                }

                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error 001CAT: Something went wrong");
            }
        }

       


        //update function
        public void updateCategory()
        {
            manageCat.category = txtCategoryName.Text;
            manageCat.id = txtCategoryId.Text;

            //check if the textboxes are empty
            if (manageCat.category == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }

            manageCat.updateCategory();
            MessageBox.Show("Category Updated");
            manageCat.category = txtCategoryName.Text = "";
            manageCat.id = txtCategoryId.Text = "";
        }

    }
}
