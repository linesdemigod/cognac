using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ManageProduct : Database
    {

        //property for the delete method
        public string name { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string quantity { get; set; }
        public string id { get; set; }
        public string productOperator { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //for getCat
        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();


        //READ DATA
        public void getProduct()
        {
            dt.Clear();
            string sql = "SELECT product.pro_id, category.cat_name, product.pro_name,  product.pro_description FROM product INNER JOIN category USING(cat_id) ORDER BY pro_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }



        //READ DATA
        public void getCat()
        {
            dt.Clear();
            string sql = "SELECT * FROM category";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }


        //READ DATA
        public void getCate()
        {
            dt.Clear();
            string sql = "SELECT * FROM category";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }

        //Delete
        public void deleteProduct()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM product WHERE pro_id=@id";
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


        //Update product
        public void updateProduct()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string subsql = "SELECT cat_id FROM category WHERE cat_name = @category";

                    cmd.CommandText = "UPDATE product SET cat_id = (" + subsql + "), pro_name = @name,  pro_description = @description WHERE pro_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@category", MySqlDbType.VarChar).Value = category;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                    cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
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
