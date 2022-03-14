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
    public partial class ExpensesRecords : KryptonForm
    {
        //instance of the Expenses
        Expenses expense = new Expenses();

        public ExpensesRecords()
        {
            InitializeComponent();
        }

        //when the winform load 
        private void ExpensesRecords_Load(object sender, EventArgs e)
        {

        }

        //create function to add the data to the database
        private void setExpenses()
        {
            expense.purpose = comboPurpose.Text;
            expense.amount = txtAmount.Text.Trim();
            expense.id = Form1.Login_fname + " " + Form1.Login_lname;
            expense.addExpenses();

          //clean textbox
            txtAmount.Text = "";

        }

        //when button click call the setExpenses function
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text == "" || comboPurpose.Text == "")
                {
                    MessageBox.Show("Please Fill all field");
                    return;
                }
                //call the function
                setExpenses();
                //show msg when successful
                MessageBox.Show("Expenses Add");
            }
            catch (Exception)
            {

                MessageBox.Show("Error: Something went wrong");
            }
        }

        //accept only number
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
