using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Orders : Database
    {
        public string name { get; set; }
        public string price { get; set; }
        public string username { get; set; }
        public string billNumber { get; set; }
        public string grossAmount { get; set; }
        public string vatAmount { get; set; }
        public string discount { get; set; }
        public string netAmount { get; set; }
        public string productName { get; set; }
        public string orderID { get; set; }
        public string quantity { get; set; }
        public string rate { get; set; }
        public string orderAmount { get; set; }
        public string desc { get; set; }
        public string billID { get; set; }
        public string stock { get; set; } //it means quantity
        public string id { get; set; }
        public string uniqueId { get; set; }
        public string customer { get; set; }



        //for getCat
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //for getCat
        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        //READ DATA
        public void getCustomer()
        {
            
            string sql = "SELECT  cust_id AS ID, CONCAT(cust_fname, ' ', cust_lname ) AS Name, cust_phone AS Phone from customer WHERE cust_fname LIKE '%"+name+"%'";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }

        //SEARCH USER 
        public void search_data()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT pro_name, pro_price FROM product WHERE pro_name=@name";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                rd = cmd.ExecuteReader();
                if (rd.Read() == true)
                {

                    name = rd.GetString("pro_name");
                    price = rd.GetString("pro_price");
                }
            }
            conn.Close();
        }

        //READ DATA
        public void getProductData()
        {
            dt.Clear();
            string subsql = "SELECT cat_name FROM category WHERE cat_id = product.cat_id";
            string sql = "SELECT pro_id AS ID, pro_name AS Food, pro_price AS Price, pro_quantity AS Stock, pro_description AS Description, (" + subsql+") AS Cat  FROM product";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //save bill 
        public void saveBill()
        {

            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO orders (users_id, ord_bill_number, ord_gross_amount, ord_vat_amount, ord_discount, ord_net_amount, cust_id) VALUES ((SELECT users_id FROM users WHERE users_uid = @username), @billnumber, @grossamount, @vatamount, @discount, @netamount, @customer)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
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

        //save the list of the ordered items
        public void saveOrderItem()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    string subsql1 = "SELECT pro_id FROM product WHERE pro_name = @name AND pro_description = @desc";
                    string subsql2 = "SELECT MAX(ord_id) FROM orders";

                    cmd.CommandText = "INSERT INTO order_item (pro_id, ord_id, ordit_quantity, ordit_rate, ordit_amount) VALUES ((" + subsql1 + "), (" + subsql2 + "), @quantity, @rate, @amount)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = productName;
                    cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
                    cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = quantity;
                    cmd.Parameters.Add("@rate", MySqlDbType.VarChar).Value = rate;
                    cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = orderAmount;
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


        public string dbVat { get; set; }
        //Get tax
        public void getTaxValue()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT vat_charge_value FROM company";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        dbVat = rd.GetString("vat_charge_value");

                    }
                }
                conn.Close();
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

        //Update Quantity
        public void decreaseStock()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "UPDATE product SET pro_quantity = pro_quantity - @stock WHERE pro_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@stock", MySqlDbType.VarChar).Value = stock;
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

        //Update Quantity
        public void increaseStock()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "UPDATE product SET pro_quantity = pro_quantity + @stock WHERE pro_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@stock", MySqlDbType.VarChar).Value = stock;
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


        //Insert it into temporary cart table
        public void insertIntoTempCart()
        {

            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO tempcart (uniqueID, pro_id, pro_name, pro_quantity) VALUES (@uniqueid, @id, @name, @quantity)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@uniqueid", MySqlDbType.VarChar).Value = uniqueId;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = stock;
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

        //Delete it from temporary cart table
        public void deleteFromTempCart()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM tempcart WHERE uniqueID=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = uniqueId;
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