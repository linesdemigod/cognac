using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class EachProductReport : Database
    {
        //for getCat
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();

        //variables
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string getYear { get; set; }
        public string empName { get; set; }

        string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";
        

        public void getProductReport()
        {
            string sql = "SELECT (SELECT pro_name FROM product WHERE pro_id = order_item.pro_id) AS Product, ordit_rate AS Price, SUM(ordit_quantity) AS Quantity, SUM(ordit_amount) As Amount, (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) AS Cashier FROM order_item WHERE created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE) AND (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) = '" + empName + "'  GROUP BY product";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //READ DATA
        public void getEmployee()
        {
            dt.Clear();
            string sql = "SELECT CONCAT(users_fname, ' ', users_lname) As Cashier FROM users";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }


        public void dailyReport()
        {


            string sql = "SELECT  (SELECT pro_name FROM product WHERE pro_id = order_item.pro_id) AS Product,  ordit_rate AS Price, SUM(ordit_quantity) AS Quantity, SUM(ordit_amount) As Amount, (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) AS Cashier FROM order_item WHERE date(created_at) = curdate() AND (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) = '" + empName + "'  GROUP BY product";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void weeklyReport()
        {
            string sql = "SELECT  (SELECT pro_name FROM product WHERE pro_id = order_item.pro_id) AS Product,  ordit_rate AS Price, SUM(ordit_quantity) AS Quantity, SUM(ordit_amount) As Amount, (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) AS Cashier FROM order_item WHERE WEEK(created_at) = WEEK(NOW()) AND (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) = '" + empName + "'  GROUP BY product";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void monthlyReport()
        {

            string sql = "SELECT  (SELECT pro_name FROM product WHERE pro_id = order_item.pro_id) AS Product,  ordit_rate AS Price, SUM(ordit_quantity) AS Quantity, SUM(ordit_amount) As Amount, (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) AS Cashier FROM order_item WHERE MONTH(created_at) = MONTH(NOW()) AND (SELECT (" + subsql + ") FROM orders WHERE ord_id = order_item.ord_id) = '" + empName + "'  GROUP BY product";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
