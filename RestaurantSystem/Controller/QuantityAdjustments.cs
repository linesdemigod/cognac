using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class QuantityAdjustments : Database
    {


        //property for the delete method
        public string quantity { get; set; }
        public string item { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public string productOperator { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        //READ DATA
        public void getProduct()
        {
            dt.Clear();
            string sql = "SELECT product.pro_id, product.pro_name, product.pro_quantity, product.pro_description FROM product ORDER BY pro_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //Update product
        public void updateStock()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE product SET  pro_quantity = pro_quantity " + productOperator + " @quantity WHERE pro_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = quantity;
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

        public void setQuantityHistory()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO quantityhistory(pro_name, pro_description, pro_quantity) VALUES(@item, @description, @qty)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@item", MySqlDbType.VarChar).Value = item;
                    cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
                    cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = quantity;
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
