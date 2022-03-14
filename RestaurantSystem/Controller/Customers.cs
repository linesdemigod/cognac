using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Customers : Database
    {
        //variables
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string id { get; set; }


        //for customers
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        //Insert the data to the database
        public void createCustomer()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO customer(users_id, cust_fname, cust_lname, cust_phone, cust_address) VALUES((SELECT users_id FROM users WHERE users_uid = @username), @firstname, @lastname, @telephone, @address)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastName;
                    cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = telephone;
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        
        //READ DATA
        public void getCustomers()
        {
            dt.Clear();
            string sql = "SELECT cust_id, cust_fname, cust_lname, cust_phone,cust_address FROM customer ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //Delete
        public void deleteCustomer()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM customer WHERE cust_id=@id";
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

        //Update
        public void updateCustomer()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE customer SET users_id = (SELECT users_id FROM users WHERE users_uid = @username), cust_fname = @firstname, cust_lname = @lastname, cust_phone = @telephone, cust_address = @address WHERE cust_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastName;
                    cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = telephone;
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
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

        //READ DATA
        public void getAllCustomerOrders()
        {

            dat.Clear();
            string sql = "SELECT ord_bill_number AS ID , ord_gross_amount AS Gross, ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS Net, created_at AS Date FROM orders WHERE cust_id = '" + id + "'";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }


        //READ DATA
        public void printReceipt()
        {

            dt.Clear();
            string sql = "SELECT orders.ord_bill_number, product.pro_name, product.pro_price, order_item.ordit_quantity, order_item.ordit_amount from orders INNER JOIN order_item USING (ord_id) INNER JOIN product USING (pro_id) WHERE orders.ord_bill_number = '" + id + "'"; 
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
