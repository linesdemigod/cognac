using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class AddProduct : Database
    {

        public string productName { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string categoryName { get; set; }
        public string quantity { get; set; }



        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getCat()
        {
            dt.Clear();
            string sql = "SELECT * FROM category";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }




        public void addProduct()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO product (cat_id, pro_name, pro_price, pro_description, pro_quantity) VALUES ((SELECT cat_id FROM category WHERE cat_name = @category), @name, @price, @description, @quantity)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@category", MySqlDbType.VarChar).Value = category;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = productName;
                    cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                    cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
                    cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = quantity;
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
