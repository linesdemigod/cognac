using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class SalesReportGraph : Dashboard
    {
        public string chartResult { get; set; }
        public string chartYear { get; set; }
        public string chartValue { get; set; }
        public string year { get; set; }



        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();



        //READ DATA
        public void getGraphSales()
        {
            dt.Clear();
            string sql = "SELECT Sum(ord_net_amount) AS countdata, MONTH(created_at) as created FROM orders WHERE YEAR(created_at) = '" + year + "' group by month(created_at)";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void getChartSales()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT ord_net_amount AS countdata, MONTH(created_at) as created FROM orders WHERE YEAR(created_at) = '"+chartYear+ "' group by month(created_at)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        chartResult = rd.GetString("countdata");
                        chartValue = rd.GetString("created");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
