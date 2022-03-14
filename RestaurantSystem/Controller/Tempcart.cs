using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Tempcart : Database
    {
      
        public string username { get; set; }
        public string billNumber { get; set; }
        public string grossAmount { get; set; }
        public string vatAmount { get; set; }
        public string discount { get; set; }
        public string netAmount { get; set; }
       
        public string id { get; set; }
        public string customer { get; set; }

        //for getCat
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        //variables
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string getYear { get; set; }
        public string custName { get; set; }

        //save bill 
        public void saveTemp()
        {

            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO orders_temp (ord_bill_number, ord_gross_amount, ord_vat_amount, ord_discount, ord_net_amount, cust_id) VALUES ( @billnumber, @grossamount, @vatamount, @discount, @netamount, @customer)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@billnumber", MySqlDbType.VarChar).Value = billNumber;
                    cmd.Parameters.Add("@grossamount", MySqlDbType.VarChar).Value = grossAmount;
                    cmd.Parameters.Add("@vatamount", MySqlDbType.VarChar).Value = vatAmount;
                    cmd.Parameters.Add("@discount", MySqlDbType.VarChar).Value = discount;
                    cmd.Parameters.Add("@netamount", MySqlDbType.VarChar).Value = netAmount;
                    cmd.Parameters.Add("@customer", MySqlDbType.VarChar).Value = customer;
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

      

        public void getCustomerReport()
        {
            string sql = "SELECT ord_id AS ID, ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount'  FROM orders_temp WHERE created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE) AND cust_id = (SELECT cust_id FROM customer WHERE CONCAT(cust_fname, ' ', cust_lname) = '" + custName + "')  ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //READ DATA
        public void getCustomer()
        {
            dt.Clear();
            string sql = "SELECT CONCAT(cust_fname, ' ', cust_lname) As Customer FROM customer";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }

        //Delete it from temporary cart table
        public void deleteFromTemp()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM orders_temp WHERE ord_id=@id";
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
