using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class PriceAjustments : Database
    {

        //property for the delete method
        public string price { get; set; }
        public string description { get; set; }
        public string item { get; set; }
        public string id { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        //READ DATA
        public void getProduct()
        {
            dt.Clear();
            string sql = "SELECT product.pro_id,  product.pro_name, product.pro_price, product.pro_description FROM product ORDER BY pro_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //Update product
        public void adjustPrice()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE product SET  pro_price = @price WHERE pro_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
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

        public void setPriceHistory()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO pricehistory(pro_name, pro_price, pro_description) VALUES(@item, @price, @description)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@item", MySqlDbType.VarChar).Value = item;
                    cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                    cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
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
