using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class EmployeeReport : Database
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
            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', (" + subsql + ") AS Cashier FROM orders WHERE created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE) AND users_id = (SELECT users_id FROM users WHERE CONCAT(users_fname, ' ', users_lname) = '" + empName + "')  ORDER BY created_at DESC";
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


            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', (" + subsql + ") AS Cashier FROM orders WHERE date(created_at) = curdate() AND users_id = (SELECT users_id FROM users WHERE CONCAT(users_fname, ' ', users_lname) = '" + empName + "')  ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void weeklyReport()
        {
            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', (" + subsql + ") AS Cashier FROM orders WHERE WEEK(created_at) = WEEK(NOW()) AND users_id = (SELECT users_id FROM users WHERE CONCAT(users_fname, ' ', users_lname) = '" + empName + "') ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void monthlyReport()
        {
            //string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', (" + subsql + ") AS Cashier FROM orders WHERE MONTH(created_at) = MONTH(NOW()) AND users_id = (SELECT users_id FROM users WHERE CONCAT(users_fname, ' ', users_lname) = '" + empName + "') ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
