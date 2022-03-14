using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class DashboardGraph : Dashboard
    {
        public string product { get; set; }
        public string qty { get; set; }
        public string totalExpenses { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();



        //READ DATA
        public void getChartResult()
        {
            dt.Clear();
            string sql = "SELECT product.pro_name AS Item, SUM(order_item.ordit_quantity) AS Qty FROM order_item INNER JOIN product ON order_item.pro_id = product.pro_id GROUP BY Item";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //get the best item
        public void getBestSellingItem()
        {
           
            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT (SELECT pro_name FROM product WHERE pro_id = order_item.pro_id) AS Product, sum(ordit_quantity) AS Quantity FROM order_item GROUP BY pro_id ORDER BY sum(ordit_quantity) DESC LIMIT 1";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    product = rd.GetString("Product");

                }

                conn.Close();
            }
            
        }

        //get the best item
        public void getWorstSellingItem()
        {

            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT (SELECT pro_name FROM product WHERE pro_id = order_item.pro_id) AS Product, sum(ordit_quantity) AS Quantity FROM order_item GROUP BY pro_id ORDER BY sum(ordit_quantity) ASC LIMIT 1";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    product = rd.GetString("Product");

                }

                conn.Close();
            }


        }
        
        //get the sumof
        public void getTotalExpenses()
        {
            try
            {

                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT SUM(exp_amount) AS Expenses FROM expense";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        
                       
                       totalExpenses = rd.GetString("Expenses");
                        
                    }

                    conn.Close();
                }
            }
            catch (System.Data.SqlTypes.SqlNullValueException ex)
            {
                Console.WriteLine(ex.Message);

            }
           

        }
    }
}
