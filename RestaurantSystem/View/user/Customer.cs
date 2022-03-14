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
    public partial class Customer : KryptonForm
    {
        Customers cust = new Customers();

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        //insert into database
        private void createCustomerAccount()
        {
            try
            {
                
                cust.username = Form1.Login_username;
                cust.firstName = txtFirstName.Text.Trim();
                cust.lastName = txtLastName.Text.Trim();
                cust.telephone = txtTelephone.Text.Trim();
                cust.address = txtAddress.Text.Trim();

                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtTelephone.Text == "" ||txtAddress.Text == "")
                {
                    MessageBox.Show("Please Fill all field");

                    return;
                }
               
                cust.createCustomer();
                MessageBox.Show("Customer created");

                //clear various textboxes
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtTelephone.Text = "";

            }
            catch (Exception)
            {
                throw new Exception("Something went wrong");

            }
        }

        //telephone accept only numbers
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //insert into database
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            createCustomerAccount();
        }
    }
}
