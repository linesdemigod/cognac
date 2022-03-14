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
    public partial class Manageorder : KryptonForm
    {

        ManageOrder order = new ManageOrder();
        Orders restore = new Orders();

        public Manageorder()
        {
            InitializeComponent();
        }


        private void Manageorder_Load(object sender, EventArgs e)
        {
            kryptonGroupBox1.Visible = false;
            dataGridViewPrint.Visible = false;

        }

        private void tabManageOrder_Click(object sender, EventArgs e)
        {
            
        }


       

        //method to put the data to the gridviewdata
        public void getOrders()
        {
            dataGridViewOrder.DataSource = null;
            dataGridViewOrder.Rows.Clear();
            order.dat.Clear();
            order.fromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            order.toDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            order.getFullOrder();
            dataGridViewOrder.DataSource = order.dat;
        }


        private void searchByReceiptNumber()
        {
            string str = txtReceiptSearch.Text.Trim();
            dataGridViewOrder.DataSource = null;
            dataGridViewOrder.Rows.Clear();
            order.dat.Clear();
            order.billID = str;
            order.getFullOrders();
            dataGridViewOrder.DataSource = order.dat;
        }

        private void btnReceiptSearch_Click(object sender, EventArgs e)
        {
            searchByReceiptNumber();
        }



        //function to get the values of the sales using the ord_bill_number
        private void getReceiptPrint()
        {

            try
            {
                if (dataGridViewOrder.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewOrder.Rows)
                    {
                        if (row.Selected == true)
                        {
                            order.billID = Convert.ToString(row.Cells["ID"].Value);
                            order.printReceipt();
                            dataGridViewPrint.DataSource = order.dast;

                            lblDiscount.Text = "₵ " + row.Cells["Discount"].Value;
                            lblVat.Text = "₵ " + row.Cells["VAT"].Value;
                            lblSubTotal.Text = "₵ " + row.Cells["Gross"].Value;
                            lblGrandTotal.Text = "₵ " + row.Cells["Net"].Value;
                            lblBillToName.Text = Convert.ToString(row.Cells["Customer"].Value);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);

            }
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrint.Rows.Count != 0 || dataGridViewPrint != null)
            {
                dataGridViewPrint.Visible = true;
                kryptonGroupBox1.Visible = true;
                getReceiptPrint();

            }

            
        }
        


        //the print function
        #region print
        public void printData()
        {

            try
            {
                int datagrid = dataGridViewPrint.Rows.Count;
                if (datagrid > 0 && datagrid <= 5)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                    printDocument1.PrinterSettings.Copies = 2;
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

                if (datagrid > 150 && datagrid <= 250)
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion
       

        //receipt designing
        #region Receipt design  
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //company info
                CompanyInfo info = new CompanyInfo();
                info.getCompany();
                Orders order = new Orders();
                order.getTaxValue();
                //set vat percentage
                double dbVat = Convert.ToDouble(order.dbVat);

                DateTime now = DateTime.Now;
                int fontSize = 10;
                Font regular = new Font("Courierr New", fontSize, FontStyle.Regular);
                Font font = new Font("Courierr New", 10, FontStyle.Bold);
                Font small = new Font("Courierr New", 8, FontStyle.Regular);

                float fontheight = font.GetHeight();
                int startx = 40;
                int starty = 40;
                int footerx = 5;
                int footery = 30;
                int pos = 180;
                double productQty, product_price, productTotal;

                string product_name;

               
                e.Graphics.DrawString(info.company, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(startx, 0));

                e.Graphics.DrawString(info.address, regular, Brushes.Black, new Point(100, 20));
                e.Graphics.DrawString(info.phone, regular, Brushes.Black, new Point(100, starty));

                starty = starty + 20;

                e.Graphics.DrawString("Date: ", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString(now.ToString(), regular, Brushes.Black, new Point(70, starty));

                starty = starty + 20;

                e.Graphics.DrawString("Invoice No.: ", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString(dataGridViewPrint.Rows[0].Cells["PrintID"].Value.ToString(), regular, Brushes.Black, new Point(100, starty));

                starty = starty + 20;

                e.Graphics.DrawString("Cashier: ", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString(Form1.Login_fname + " " + Form1.Login_lname, regular, Brushes.Black, new Point(100, starty));
                
                starty = starty + 20;

                e.Graphics.DrawString("Bill To: ", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString(lblBillToName.Text, regular, Brushes.Black, new Point(100, starty));

                starty = starty + 20;

                e.Graphics.DrawString("**************************************************", font, Brushes.Black, new Point(1, starty));

                starty = starty + 20;

                e.Graphics.DrawString("PRODUCT", font, Brushes.Black, new Point(5, starty));
                e.Graphics.DrawString("QTY", font, Brushes.Black, new Point(110, starty));
                e.Graphics.DrawString("PRICE", font, Brushes.Black, new Point(160, starty));
                e.Graphics.DrawString("TOTAL", font, Brushes.Black, new Point(225, starty));

                foreach (DataGridViewRow row in dataGridViewPrint.Rows)
                {
                    product_name = Convert.ToString(row.Cells["PrintProduct"].Value);
                    productQty = Convert.ToDouble(row.Cells["PrintQty"].Value);
                    product_price = Convert.ToDouble(row.Cells["PrintPrice"].Value);
                    productTotal = Convert.ToDouble(row.Cells["PrintSubTotal"].Value);

                    //e.Graphics.DrawString(productID.ToString(), new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                    e.Graphics.DrawString(product_name.ToString(), regular, Brushes.Black, new Point(5, pos));
                    e.Graphics.DrawString(productQty.ToString(), regular, Brushes.Black, new Point(110, pos));
                    e.Graphics.DrawString(product_price.ToString(), regular, Brushes.Black, new Point(160, pos));
                    e.Graphics.DrawString(productTotal.ToString(), regular, Brushes.Black, new Point(225, pos));

                    pos = pos + 20;
                }


                e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

                footery = footery + 30;

                e.Graphics.DrawString("SubTotal: ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + lblSubTotal.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("Discount: ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + lblDiscount.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("VAT(" + order.dbVat + "%): ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + lblVat.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("Grand Total: ", font, Brushes.Black, new Point(footerx, pos + footery));
                e.Graphics.DrawString("GHS " + lblGrandTotal.Text, regular, Brushes.Black, new Point(footerx + 180, pos + footery));


                footery = footery + 30;

                e.Graphics.DrawString("******************************************************", font, Brushes.Black, new Point(0, pos + footery));

                footery = footery + 20;

                e.Graphics.DrawString("Thank you for visiting", font, Brushes.Black, new Point(80, pos + footery));
                //pos = 100;

                footery = footery + 20;

                e.Graphics.DrawString("Software by Cluster I.T. Solutions - 0242024796", small, Brushes.Black, new Point(10, pos + footery));
                pos = 120;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #endregion

       

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printData();
        }

        //filter out the date when the search is click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getOrders();
        }

        
    }
}
