using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ProductReport : Database
    {

        //for getCat
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //variables
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string getYear { get; set; }
        string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";


        public void getProductReport()
        {

            string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";
           
            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', ("+subsql+") AS Cashier FROM orders ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //READ DATA
        public void getProductReportFilter()
        {
            //string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', ("+subsql+") AS Cashier FROM orders WHERE created_at BETWEEN cast('"+fromDate+ "' AS DATE) AND CAST('" + toDate + "' AS DATE) ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void dailyReport()
        {
           

            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', ("+subsql+") AS Cashier FROM orders WHERE date(created_at) = curdate() ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void weeklyReport()
        {
            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', (" + subsql + ") AS Cashier FROM orders WHERE WEEK(created_at) = WEEK(NOW()) ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void monthlyReport()
        {
            //string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";

            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', ("+subsql+") AS Cashier FROM orders WHERE MONTH(created_at) = MONTH(NOW()) ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        public void getReportByYear()
        {
            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', (" + subsql + ") AS Cashier FROM orders WHERE Year(created_at) = '"+getYear+"' ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}

