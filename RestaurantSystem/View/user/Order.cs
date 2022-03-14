using ComponentFactory.Krypton.Toolkit;
using System;
using RestaurantSystem.Controller;
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
    public partial class Order : KryptonForm
    {
        //instance of the order class
        Orders order = new Orders();
        AddProduct product = new AddProduct();
        Tempcart temp = new Tempcart();
        
        
        //variables for the datagrid
        int Key = 0;
        string productName;
        int addNewRow = 1;

        public Order()
        {
            InitializeComponent();

            //disable one from pasting from clipboard to the datagridview quantity cell
            dataGridViewBill.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewBill.EditingControlShowing += dataGridViewBill_EditingControlShowing;
            

        }
       
        //method like the constructor
        #region load winform
        private void Order_Load(object sender, EventArgs e)
        {
            //hide the customer datagridview
            dataGridViewAutoComplete.Visible = false;

            //load the left datagridview
            getProductData();

            //get the current VAT 
            vatValueToLabel();


            //get all the various category to the combobox
            getCatData();

            //hide the bill topanel
            panelBillTo.Visible = false;

            getNotification();


        }
        #endregion

        //get notifications of the ruuning out product
        private void notify(string item, int stock)
        {
            popupNotifierItem.TitleText = "Running Out Of Stock";
            popupNotifierItem.ContentText = item + " is left with only " + stock + " quantity";
            popupNotifierItem.Popup();
        }

        //method for notifications
        #region NOTIFICATIONS   
        private void getNotification()
        {
            Orders order = new Orders();
            order.getProductData();
            
            foreach (DataRow row in order.dt.Rows)
            {
                int stock = Convert.ToInt32(row["Stock"]);
                string item = row["Food"].ToString();
                
                if(stock < 5)
                {
                
                  notify(item, stock);
                }
            }
        }
        #endregion

        //method to put the data to the gridviewdata left side
        #region datagrid
        public void getProductData()
        {
            order.getProductData();
            dataGridViewProduct.DataSource = order.dt;
        }
        #endregion

       
        //filter the datagrid at the left to the value provided in the textbox
        #region search product
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            search();
            
        }
        #endregion

        //method to the filter the product based on the value entered in the textbox
        #region Search
        public void search()
        {
            //prevent sql injection
            string str = txtProduct.Text.Trim().Replace("'", "\\");
            DataView dv = order.dt.DefaultView;
            dv.RowFilter = string.Format("Food LIKE '%" + str + "%'");
            dataGridViewProduct.DataSource = dv.ToTable();
        }
        #endregion
        

        //method to the filter the product based on category
        #region Search by category
        public void searchByCategory()
        {
            //prevent sql injection
            string str = comboSearchFilter.Text.Trim().Replace("'", "\\");

            DataView dv = order.dt.DefaultView;
            dv.RowFilter = string.Format("Cat = '" + str + "'");
            dataGridViewProduct.DataSource = dv.ToTable();
        }
        #endregion

        //method to put the data to the combobox
        #region Load category
        public void getCatData()
        {
            //comboCategory.DataSource = null;
            product.getCat();
            comboSearchFilter.DataSource = product.dt;
            comboSearchFilter.DisplayMember = "cat_name";
            comboSearchFilter.ValueMember = "Cat_id";
        }
        #endregion

        //show the customers name on the datagrid
        #region show customer names
        private void datagridAutocomplete()
        {
            order.dat.Clear();
            order.name = txtAutoComplete.Text.Trim().Replace("'","\\");
            order.getCustomer();
            dataGridViewAutoComplete.DataSource = order.dat;
           
            //hide the id column in the datagrid
            dataGridViewAutoComplete.Columns["ID"].Visible = false;
        }
        #endregion

        //customer datagrid validate
        #region Customer Datagrid
        private void validateCustomerDatagrid()
        {
            try
            {
                if (txtAutoComplete.Text != "" || txtAutoComplete != null)
                {
                    dataGridViewAutoComplete.Visible = true;
                    
                    datagridAutocomplete(); //call the search customer function

                }

                if (txtAutoComplete.Text == "" || String.IsNullOrEmpty(txtAutoComplete.Text))
                {
                    dataGridViewAutoComplete.Visible = false;
                    dataGridViewAutoComplete.DataSource = null;
                    dataGridViewAutoComplete.Rows.Clear();
                    dataGridViewAutoComplete.Refresh();
                   

                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Customer list is empty");
            }
        }
        #endregion


        //textcomplete auto complete
        #region AUTOCOMPLETE

        //autocomplete
         /*private void autoComple()
         {

             txtAutoComplete.AutoCompleteMode = AutoCompleteMode.Suggest;
             txtAutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
             AutoCompleteStringCollection coll = new AutoCompleteStringCollection();


            sales.getSearchItem();
            
            foreach (DataRow row in sales.dt.Rows)
             {
               
                    string newLine = Environment.NewLine;
                    string prod = row["Food"].ToString() +" " + newLine + row["Price"].ToString();
                    string desc = row["Description"].ToString();


                coll.Add(prod + desc);
                    //coll.Add(price);
                    //coll.Add(desc);
                
             }

            comboAuto.AutoCompleteCustomSource = coll;
         }

     
    */
        #endregion

        //autocomplete
        #region show autocomplete
        private void txtAutoComplete_TextChanged(object sender, EventArgs e)
        {

            validateCustomerDatagrid();
        }
        #endregion


        //VAT value to the label
        #region Vat label
        public void vatValueToLabel()
        {
            order.getTaxValue();
            label7.Text = "VAT(" + order.dbVat + "%)";
        }
        #endregion


        //select the values from the datagrid to the right datagrid
        #region datagrid cellcontentclicked
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //GET SELECTED DATA
            DataGridView senderGrid = (DataGridView)sender;

            try
            {
                if (dataGridViewProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {


                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridViewBill);
                    newRow.Cells[0].Value = addNewRow;
                    newRow.Cells[1].Value = (dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    newRow.Cells[2].Value = "1";
                    newRow.Cells[3].Value = (Convert.ToDouble(dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    newRow.Cells[4].Value = (dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
                    newRow.Cells[5].Value = (Convert.ToDouble(dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString())); //insert it into datagridviewbill
                    newRow.Cells[6].Value = (dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dataGridViewBill.Rows.Add(newRow);
                    addNewRow++;


                    calcTotalAmount();



                    if (productName == "")
                    {
                        Key = 0;
                    }
                    else
                    {
                        Key = Convert.ToInt32(dataGridViewProduct.Rows[0].Cells[0].Value.ToString());
                    }
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Something went wrong, Please retry");
            }
        }

        #endregion

        //method to delete a selected row from datagridviewbill and deduct deleted value from the subtotal
        #region delete cell and calculate subtotal after
        public void removeCell()
        {
            try
            {
                if (dataGridViewBill.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewBill.Rows)
                    {
                        if (row.Selected == true)
                        {
                            lblSubTotal.Text = (Convert.ToDouble(lblSubTotal.Text) - Convert.ToDouble(row.Cells["Column5"].Value)).ToString();

                            dataGridViewBill.Rows.RemoveAt(row.Index);
                            dataGridViewBill.Refresh();
                        }

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Remove: Something went wrong");
            }

        }

        #endregion

        //remove from datagrid cart
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            removeCell();
        }

        


        //call the vat and grandtotal methods here
        #region subtotal event handler
        private void lblSubTotal_TextChanged(object sender, EventArgs e)
        {

            vatCalc();
            grandTotal();


        }
        #endregion

        //calculate discount
        #region discount calc
        public void calcDiscount()
        {
            try
            {
                //declare variable for the calc
                double grandTotal, vat, discount, subTotal;

                //convert the various textbox to double
                vat = Convert.ToDouble(lblVat.Text);
                discount = Convert.ToDouble(txtDiscount.Text);
                subTotal = Convert.ToDouble(lblSubTotal.Text);

                //calc the grand total
                grandTotal = (vat + subTotal) - discount;

                lblGrandTotal.Text = grandTotal.ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Discount: Something went wrong, please retry");

            }

        }
        #endregion

        //calc the grandtotal
        #region Grandtotal
        public void grandTotal()
        {
            try
            {
                //declare variable for the calc
                double grandTotal, vat, subTotal;

                //convert the various textbox to double
                vat = Convert.ToDouble(lblVat.Text);
                subTotal = Convert.ToDouble(lblSubTotal.Text);

                //calc the grand total
                grandTotal = vat + subTotal;

                lblGrandTotal.Text = grandTotal.ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Total: something went wrong");

            }

        }
        #endregion

        //Calculate the Vat set the value to 13%
        #region Vat calculator
        public void vatCalc()
        {

            try
            {
                order.getTaxValue();
                //set vat percentage to 13
                double dbVat = Convert.ToDouble(order.dbVat);

                double vat = dbVat / 100;

                double subTotal = Convert.ToDouble(lblSubTotal.Text);
                double calcvat = subTotal * vat;

                lblVat.Text = calcvat.ToString("0.00");
            }
            catch (Exception)
            {

                MessageBox.Show("Vat: Something went wrong");
            }

        }
        #endregion

        //calc the change
        #region calculate change
        public void calcChange()
        {
                double amountPaid = string.IsNullOrEmpty(txtAmountPaid.Text) ? 0 : double.Parse(txtAmountPaid.Text);
            try
            {
                double  change, grandTotal;

                amountPaid = Convert.ToDouble(txtAmountPaid.Text);
                grandTotal = Convert.ToDouble(lblGrandTotal.Text);
                

                change = amountPaid - grandTotal;

                txtChange.Text = change.ToString("0.00");
            }
            catch (FormatException) 
            {
               
                MessageBox.Show("Enter amount to get the change");
                //throw new ArgumentException("Name cannot be null or empty string", ex);
            }

        }
        #endregion


        //the calcDiscount method when a value is enter in the Discount textbox
        #region discount event handler
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            
                //if the discount txtbox is empty set value to 0
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                }

                calcDiscount();

        }
        #endregion

        //calculate the change to be given to the customer
        #region Change 
        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            
                if (txtAmountPaid.Text == "")
                {
                    txtChange.Text = "";

                    return;
                }

                calcChange(); //call the function to calculate the change

            
        }
        #endregion


        //order button clicked event handler
        #region order event 
        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (dataGridViewBill.Rows.Count == 0 || dataGridViewBill == null)
            {
                MessageBox.Show("Select an item");

                return;
            }

            if (lblSubTotal.Text == "0" || lblSubTotal.Text == "")
            {
                MessageBox.Show("Subtotal is 0");
                return;
            }




            DialogResult confirm = MessageBox.Show("Do you want to Make order? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {

                //insert the bill to the orders table in the db
                insertBillDB();

                //insert into order item in the db
                insertOrderItem();

                saveToTemp(); //save to temporary

                //update the stock
                updateStock();

                //print the receipt
                printData();

                //clear the cart
                clearDataGridTable();

                //clear the various table after inserting it to the database
                lblSubTotal.Text = "0";
                lblVat.Text = "";
                lblGrandTotal.Text = "";
                txtChange.Text = "";
                txtAmountPaid.Text = "";
                lblBillID.Text = "";
                lblBillToID.Text = "0";
                lblBillToName.Text = "";

                //set the discount textbox to zero
                txtDiscount.Text = "0";

                //reload the datagrid
                getProductData();
            }

        }
        #endregion

        //Generate random number for each receipt
        #region randomnumber
        public string getRandNum()
        {
            Random rand = new Random();
            string result = "BA" + rand.Next();

            return result;
        }
        #endregion


        //TEMPORARY
        private void saveToTemp()
        {
            temp.billNumber = lblBillID.Text;
            temp.grossAmount = lblSubTotal.Text;
            temp.vatAmount = lblVat.Text;
            temp.discount = txtDiscount.Text;
            temp.netAmount = lblGrandTotal.Text;
            temp.customer = lblBillToID.Text;
            temp.saveTemp();
        }

        //insert the bill to the database
        #region insertBill
        public void insertBillDB()
        {

            if (lblSubTotal.Text == "")
            {
                MessageBox.Show("Select a product");

                return;
            }



            string g = getRandNum();
            lblBillID.Text = g;
            order.username = Form1.Login_username;
            order.billNumber = lblBillID.Text;
            order.grossAmount = lblSubTotal.Text;
            order.vatAmount = lblVat.Text;
            order.discount = txtDiscount.Text;
            order.netAmount = lblGrandTotal.Text;
            order.customer = lblBillToID.Text;
            order.saveBill();

            //display success message
            MessageBox.Show("Order completed");

        }
        #endregion

        //clear the datagriview at the right
        #region Clear Table
        public void clearDataGridTable()
        {
            dataGridViewBill.DataSource = null;
            dataGridViewBill.Rows.Clear();

        }
        #endregion

        //insert ordered item to db
        #region into bill datagrid
        public void insertOrderItem()
        {

            foreach (DataGridViewRow row in dataGridViewBill.Rows)
            {
                order.productName = Convert.ToString(row.Cells["Column2"].Value);
                order.quantity = Convert.ToString(row.Cells["Column3"].Value);
                order.rate = Convert.ToString(row.Cells["Column4"].Value);
                order.orderAmount = Convert.ToString(row.Cells["Column5"].Value);
                order.desc = Convert.ToString(row.Cells["Column6"].Value);
                order.saveOrderItem();

            }
        }
        #endregion

        //handle print preview
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            printData();
           
            
        }


        //the print function
        #region print
        public void printData()
        {
            try
            {
                int datagrid = dataGridViewBill.Rows.Count;
                if (datagrid > 0 && datagrid <= 5)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 5 && datagrid <= 10)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 900);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 10 && datagrid <= 18)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1200);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 18 && datagrid <= 30)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1200);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 30 && datagrid <= 50)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 50 && datagrid <= 100)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 100 && datagrid <= 150)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 120 && datagrid <= 180)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 180 && datagrid <= 250)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 250 && datagrid <= 300)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

                if (datagrid > 300 && datagrid <= 400)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1500);
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                    return;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Printing error");
            }

        }


        #endregion

        //receipt designing
        #region Receipt design
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //company info
            CompanyInfo info = new CompanyInfo();
            info.getCompany();
            DateTime now = DateTime.Now;
            int fontSize = 10;
            Font font = new Font("Courierr New", 10, FontStyle.Bold);
            Font regular = new Font("Courierr New", fontSize, FontStyle.Regular);
            Font small = new Font("Courierr New", 8, FontStyle.Regular);

            float fontheight = font.GetHeight();
            int startx = 40;
            int starty = 40;
            int footerx = 5;
            int footery = 30;
            int pos = 180;
            double productQty, product_price, productTotal;

            string product_name, description;


            e.Graphics.DrawString(info.company, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(startx, 0));

            e.Graphics.DrawString(info.address, regular, Brushes.Black, new Point(100, 20));
            e.Graphics.DrawString(info.phone, regular, Brushes.Black, new Point(100, starty));

            starty = starty + 20;

            e.Graphics.DrawString("Date: ", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString(now.ToString(), regular, Brushes.Black, new Point(70, starty));

            starty = starty + 20;

            e.Graphics.DrawString("Invoice No.: ", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString(lblBillID.Text, regular, Brushes.Black, new Point(100, starty));

            starty = starty + 20;

            e.Graphics.DrawString("Cashier: ", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString(Form1.Login_fname + " " + Form1.Login_lname, regular, Brushes.Black, new Point(100, starty));

            starty = starty + 20;

            e.Graphics.DrawString("Bil To: ", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString(lblBillToName.Text, regular, Brushes.Black, new Point(100, starty));

            starty = starty + 20;

            e.Graphics.DrawString("**************************************************", font, Brushes.Black, new Point(1, starty));

            starty = starty + 20;

            e.Graphics.DrawString("ITEM", font, Brushes.Black, new Point(5, starty));
            e.Graphics.DrawString("QTY", font, Brushes.Black, new Point(110, starty));
            e.Graphics.DrawString("PRICE", font, Brushes.Black, new Point(160, starty));
            e.Graphics.DrawString("TOTAL", font, Brushes.Black, new Point(225, starty));

            foreach (DataGridViewRow row in dataGridViewBill.Rows)
            {
                product_name = Convert.ToString(row.Cells["Column2"].Value);
                productQty = Convert.ToDouble(row.Cells["Column3"].Value);
                product_price = Convert.ToDouble(row.Cells["Column4"].Value);
                productTotal = Convert.ToDouble(row.Cells["Column5"].Value);
                description = Convert.ToString(row.Cells["Column6"].Value);

                //e.Graphics.DrawString(productID.ToString(), new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString(product_name.ToString(), regular, Brushes.Black, new Point(5, pos));
                e.Graphics.DrawString(description, regular, Brushes.Black, new Point(5, pos + 20));
                e.Graphics.DrawString(productQty.ToString(), regular, Brushes.Black, new Point(110, pos));
                e.Graphics.DrawString(product_price.ToString(), regular, Brushes.Black, new Point(160, pos));
                e.Graphics.DrawString(productTotal.ToString(), regular, Brushes.Black, new Point(225, pos));

                pos = pos + 40;
            }


            e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

            footery = footery + 30;

            e.Graphics.DrawString("SubTotal: ", font, Brushes.Black, new Point(footerx, pos + footery));
            e.Graphics.DrawString("GHS " + lblSubTotal.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString("Discount:", font, Brushes.Black, new Point(footerx, pos + footery));

            e.Graphics.DrawString("GHS " + txtDiscount.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString(label7.Text, font, Brushes.Black, new Point(footerx, pos + footery));
            e.Graphics.DrawString("GHS " + lblVat.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString("Grand Total: ", font, Brushes.Black, new Point(footerx, pos + footery));
            e.Graphics.DrawString("GHS " + lblGrandTotal.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

            footery = footery + 30;

            e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

            footery = footery + 20;

            e.Graphics.DrawString("Thank you for visiting", font, Brushes.Black, new Point(80, pos + footery));
            //pos = 160;

            footery = footery + 20;

            e.Graphics.DrawString("Software by Cluster I.T. Solutions - 0242024796", small, Brushes.Black, new Point(10, pos + footery));
            pos = 120;
        }

        #endregion

        //handle the search by category function
        #region filter category
        private void comboSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchByCategory();
        }
        #endregion


        //calculate the sum of the subtotal when the quantity is increased
        #region increase cart quantity
        private void dataGridViewBill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                foreach (DataGridViewRow row in dataGridViewBill.Rows)
                {


                    row.Cells[dataGridViewBill.Columns["Column5"].Index].Value = (Convert.ToDouble(row.Cells[dataGridViewBill.Columns["Column3"].Index].Value)) * (Convert.ToDouble(row.Cells[dataGridViewBill.Columns["Column4"].Index].Value));
                }

                calcTotalAmount();
            }
            catch (Exception)
            {

                MessageBox.Show("Could not calculate subtotal: please retry");
            }

        }
        #endregion

        //calculate all the totals
        #region calculate total amount
        public void calcTotalAmount()
        {
            //calculate the datagridview total amount
            double sum = 0;

            for (int i = 0; i < dataGridViewBill.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridViewBill.Rows[i].Cells[5].Value);
            }

            //this format the numbers to make it easier to read
            lblSubTotal.Text = sum.ToString();

        }
        #endregion

        //this method update stockin the database when the order is made
        #region update stock
        public void updateStock()
        {
            foreach (DataGridViewRow row in dataGridViewBill.Rows)
            {


                order.stock = Convert.ToString(row.Cells["Column3"].Value);
                order.id = Convert.ToString(row.Cells["Column12"].Value);
                order.decreaseStock();

            }
        }


        #endregion

        //validate quantity cell to accept only numbers
        #region Accept only number
        private void dataGridViewBill_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Quantity_KeyPress);
            if (dataGridViewBill.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Quantity_KeyPress);
                    tb.ContextMenuStrip = new ContextMenuStrip();
                    tb.KeyDown -= Quantity_KeyDown;
                    tb.KeyDown += Quantity_KeyDown;
                }

            }
        }

        //the quantity cell accept only number
        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //disable copy and paste
        private void Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C | e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        #endregion


        //prevent cell from being empty
        #region prevent empty cell
        private void dataGridViewBill_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewBill.Columns[e.ColumnIndex].Name == "Column3")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridViewBill.Rows[e.RowIndex].ErrorText =
                        "Qty must not be empty";
                    e.Cancel = true;
                }
            }
        }

        #endregion

        //set the value clicked to the txtbox and then hide the customer datagrid
        #region cUSTOMER AUTOCOMPLETE
        private void dataGridViewAutoComplete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewAutoComplete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //assign the value to the label and textbox
                    //txtAutoComplete.Text = (dataGridViewAutoComplete.Rows[e.RowIndex].Cells[1].Value.ToString());
                    lblBillToID.Text = (dataGridViewAutoComplete.Rows[e.RowIndex].Cells[0].Value.ToString());
                   lblBillToName.Text = (dataGridViewAutoComplete.Rows[e.RowIndex].Cells[1].Value.ToString());

                    
                    //show the bill to panel
                    panelBillTo.Visible = true;
                    dataGridViewAutoComplete.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("customer: Something went wrong");

            }
        }
        #endregion

        //hide the autoCOmplete when any part is clicked
        private void Order_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridViewAutoComplete.Visible = false;
        }

       
        //close the billto
        private void lblClose_Click(object sender, EventArgs e)
        {
            panelBillTo.Visible = false;
            lblBillToName.Text = "";
            lblBillToID.Text = "";
        }

    }
}
