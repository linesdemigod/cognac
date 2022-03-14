using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class CustomerReports : Database
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
        public string custName { get; set; }

        string subsql = "SELECT CONCAT(users_fname, ' ', users_lname) FROM users WHERE users_id = orders.users_id";



        public void getCustomerReport()
        {
            string sql = "SELECT ord_bill_number AS 'Bill #', created_at AS Date, ord_gross_amount AS 'Gross Amount', ord_vat_amount AS VAT, ord_discount AS Discount, ord_net_amount AS 'Total Amount', (" + subsql + ") AS Cashier FROM orders WHERE created_at BETWEEN cast('" + fromDate + "' AS DATE) AND CAST('" + toDate + "' AS DATE) AND cust_id = (SELECT cust_id FROM customer WHERE CONCAT(cust_fname, ' ', cust_lname) = '" + custName + "')  ORDER BY created_at DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //READ DATA
        public void getCustomer()
        {
            dt.Clear();
            string sql = "SELECT CONCAT(cust_fname, ' ', cust_lname) As Customer FROM customer";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(das);
            dat = das.Tables[0];
        }
    }
}
