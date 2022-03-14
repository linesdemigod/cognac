using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ManageOrder : Database
    {

        //variables
        public string id { get; set; }
        public string billID { get; set; }
        public int scroll { get; set; }
        public int limit { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }



        //for getCat
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public MySqlDataAdapter dta;

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        public DataTable dast = new DataTable();
        private DataSet dass = new DataSet();




        //READ DATA
        public void getOrder()
        {
            try
            {

            dt.Clear();
            string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT ord_bill_number, ord_gross_amount, ord_vat_amount, ord_discount, ord_net_amount, (" + subsql + ") AS Cashier FROM orders ORDER BY created_at DESC"; // WHERE ord_bill_number = '"+billID+"'";
            dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds, scroll, limit, "orders");
            dt = ds.Tables[0];
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        

        //READ DATA
        public void getFullOrder()
        {

            try
            {

                string sql = "SELECT ord_bill_number AS ID , ord_gross_amount AS Gross, ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS Net, (SELECT CONCAT(cust_fname, ' ', cust_lname) FROM customer WHERE cust_id = orders.cust_id) AS Customer FROM orders WHERE created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE) ORDER BY created_at DESC";
                MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
                dta.Fill(das);
                dat = das.Tables[0];
            }
            catch (Exception ex)
            {

                throw new Exception( ex.Message);
            }
        }

        

        //READ DATA
        public void getFullOrders()
        {

            string sql = "SELECT ord_bill_number AS ID , ord_gross_amount AS Gross, ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS Net, (SELECT CONCAT(cust_fname, ' ', cust_lname) FROM customer WHERE cust_id = orders.cust_id) AS Customer FROM orders WHERE ord_bill_number = @bill";

            MySqlCommand selectCMD = new MySqlCommand(sql, conn);
            MySqlDataAdapter dta = new MySqlDataAdapter();

            dta.SelectCommand = selectCMD;
            selectCMD.Parameters.Add("@bill", MySqlDbType.VarChar).Value = billID;
            dta.Fill(das);
            dat = das.Tables[0];
        }
       
        //READ DATA
        public void printReceipt()
        {

            dast.Clear();
            string sql = "SELECT orders.ord_bill_number, product.pro_name, product.pro_price, order_item.ordit_quantity, order_item.ordit_amount from orders INNER JOIN order_item USING (ord_id) INNER JOIN product USING (pro_id) WHERE orders.ord_bill_number = '" + billID + "'"; 
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(dass);
            dast = dass.Tables[0];
        }



        //Delete order
        public void deleteOrder()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM orders WHERE ord_bill_number=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }

    }
}
