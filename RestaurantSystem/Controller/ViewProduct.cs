using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ViewProduct : Database
    {

        public string productName { get; set; }
        public string name { get; set; }


        //for getCat
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //for ViewProduct
        public DataTable dtView = new DataTable();
        private DataSet dsView = new DataSet();


        //READ DATA
        public void getProduct()
        {
           
            string sql = "SELECT product.pro_id AS ID, category.cat_name AS Category, product.pro_name AS Food, product.pro_price AS Price, product.pro_description AS Description FROM product INNER JOIN category USING(cat_id) ORDER BY pro_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void getProductData()
        {
            
            string sql = "SELECT product.pro_id AS ID, category.cat_name AS Category, product.pro_name AS Food, product.pro_price AS Price, product.pro_description AS Description FROM product INNER JOIN category USING(cat_id)";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(dtView);
        }


        //SEARCH USER 
        public void searchData()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM product";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        name = rd.GetString("pro_name");
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

    }

}

