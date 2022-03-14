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
    public partial class UpdateExpenses : KryptonForm
    {
        //instance of expenses class
        Expenses expense = new Expenses();

        public UpdateExpenses(string id, string amount, string purpose, string name)
        {
            InitializeComponent();

            txtID.Text = id;
            txtAmount.Text = amount;
            comboPurpose.Text = purpose;
        }

        //function to update the expenses
        private void updateExpenses()
        {
            expense.purpose = comboPurpose.Text;
            expense.amount = txtAmount.Text;
            expense.user = Form1.Login_fname + " " + Form1.Login_lname;
            expense.id = txtID.Text;
            expense.updateExpenses();

            //clear field
            txtAmount.Text = "";
            comboPurpose.Text = "";
            txtID.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtAmount.Text== "" || comboPurpose.Text == "")
                {
                    MessageBox.Show("Please Fill all field");
                    return;
                }

                updateExpenses();
                MessageBox.Show("Expenses Updated");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    if (txtAmount.Text == "" || comboPurpose.Text == "")
                    {
                        MessageBox.Show("Please Fill all field");
                        return;
                    }

                    updateExpenses();
                    MessageBox.Show("Expenses Updated");
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Something went wrong");
                }
            }

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtAmount.Text.IndexOf('.') != -1)
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
