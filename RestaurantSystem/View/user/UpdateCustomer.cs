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
    public partial class UpdateCustomer : KryptonForm
    {

        //INSTANCE OF THE CUSTOMERS CLASS
        Customers cust = new Customers();

        public UpdateCustomer(string id, string firstname, string lastname, string telephone, string address)
        {
            InitializeComponent();

            txtID.Text = id;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
            txtTelephone.Text = telephone;
            txtAddress.Text = address;
        }

        //update customer
        private void updateCustomer()
        {
            try
            {

                cust.username = Form1.Login_username;
                cust.firstName = txtFirstName.Text;
                cust.lastName = txtLastName.Text;
                cust.telephone = txtTelephone.Text;
                cust.address = txtAddress.Text;
                cust.id = txtID.Text;

                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtTelephone.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Please Fill all field");

                    return;
                }

                cust.updateCustomer();
                MessageBox.Show("Customer Details Updated");

                //close the form
                this.Close();
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }
        }

        //accept only numbers
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            updateCustomer();
        }
    }
}
