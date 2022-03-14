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
    public partial class ManageExpenses : KryptonForm
    {
        //instance of expense class
        Expenses expense = new Expenses();

        public ManageExpenses()
        {
            InitializeComponent();
        }

        //load the winform
        private void ManageExpenses_Load(object sender, EventArgs e)
        {
            //getAllExpenses();
            setupUserAccess();
        }


        //validate Admin and manager
        public void setupUserAccess()
        {

            //instances of the permission class
            UserPermissions per = new UserPermissions();

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);


            //call the method in the Userpermissions class
            per.getPermission();

            //loop through the resultset from the database
            foreach (DataRow row in per.dt.Rows)
            {
                //assign the result to the a variable
                bool permission = Convert.ToBoolean(row["per_value"].ToString());
                string name = row["per_name"].ToString();
                int role = Convert.ToInt32(row["role_id"]);

                //check if the user logged and the priviledge given
                if (userLoggedInRole == role && name == "update expenses")
                {
                    dataGridViewExpenses.Columns["Update"].Visible = permission;

                }

                if (userLoggedInRole == role && name == "delete expenses")
                {
                    dataGridViewExpenses.Columns["Delete"].Visible = permission;

                }


            }

        }

        //function get all the expense to he datagrid
        private void getAllExpenses()
        {
            
            expense.fromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            expense.toDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            expense.getExpenses();
            dataGridViewExpenses.DataSource = expense.dt;
        }

        //refresh the datagrid
        private void btnRefreshes_Click(object sender, EventArgs e)
        {
            getAllExpenses(); 
        }

        //do the action when a cell is clicked
        private void dataGridViewExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1) return;

                //code the delete
                if (dataGridViewExpenses.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {


                        int id;
                        id = Convert.ToInt32(dataGridViewExpenses.Rows[e.RowIndex].Cells["ID"].Value);
                        expense.id = id.ToString();
                        if (Convert.ToInt32(expense.id) > 0)
                        {
                            //call the deleteUser method in the manageuser class
                            expense.deleteExpenses();
                            MessageBox.Show("Expenses deleted");
                            getAllExpenses();
                        }

                    }
                }


                //code for the update
                if (dataGridViewExpenses.Columns[e.ColumnIndex].HeaderText == "Update")
                {

                    string id, amount, purpose, name;

                    id = dataGridViewExpenses.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    amount = dataGridViewExpenses.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                    purpose = dataGridViewExpenses.Rows[e.RowIndex].Cells["Purpose"].Value.ToString();
                    name = dataGridViewExpenses.Rows[e.RowIndex].Cells["User"].Value.ToString();

                    UpdateExpenses user = new UpdateExpenses(id, amount, purpose, name);
                    user.ShowDialog();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getAllExpenses();
        }
    }
}
