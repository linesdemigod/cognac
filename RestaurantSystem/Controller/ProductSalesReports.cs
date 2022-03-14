using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ProductSalesReports : Database
    {
        //for getCat
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //for getCat
        public DataTable dat = new DataTable();
        private DataSet das = new DataSet();
        
        //for getCat
        public DataTable datt = new DataTable();
        private DataSet dass = new DataSet();

        //variables
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string getYear { get; set; }
        public string product { get; set; }
        
        string subsql2 = "SELECT pro_name FROM product WHERE pro_id = order_item.pro_id";

        //SELECT  ("+subsql2+ ") AS Product, ordit_rate AS Price, SUM(ordit_quantity) AS Quantity, SUM(ordit_amount) As Amount FROM order_item WHERE created_at BETWEEN @from AND @to AND (SELECT (" + subsql2 + ") FROM product WHERE pro_id = order_item.pro_id) = @product GROUP BY product

        public void getProductReport()
        {
            string sql = "SELECT P.pro_name AS Product, P.pro_description AS Description, O.ordit_rate AS Price, SUM(O.ordit_quantity) AS Quantity, SUM(O.ordit_amount) As Amount FROM order_item AS O INNER JOIN product AS p USING(pro_id) WHERE o.created_at BETWEEN @from AND @to AND p.pro_name = @product GROUP BY pro_description";
            MySqlCommand selectCMD = new MySqlCommand(sql, conn);
            MySqlDataAdapter dta = new MySqlDataAdapter();
            dta.SelectCommand = selectCMD;
            selectCMD.Parameters.Add("@from", MySqlDbType.VarChar).Value = fromDate;
            selectCMD.Parameters.Add("@to", MySqlDbType.VarChar).Value = toDate;
            selectCMD.Parameters.Add("@product", MySqlDbType.VarChar).Value = product;
            dta.Fill(ds);
            dt = ds.Tables[0];
        }



        public void getProductsReport()
        {
            string sql = "SELECT P.pro_name AS Product, P.pro_description AS Description, O.ordit_rate AS Price, SUM(O.ordit_quantity) AS Quantity, SUM(O.ordit_amount) As Amount from order_item AS O INNER JOIN product AS p USING(pro_id) WHERE o.created_at BETWEEN @from AND @to GROUP BY pro_description";
            MySqlCommand selectCMD = new MySqlCommand(sql, conn);
            MySqlDataAdapter dta = new MySqlDataAdapter();
            dta.SelectCommand = selectCMD;
            selectCMD.Parameters.Add("@from", MySqlDbType.VarChar).Value = fromDate;
            selectCMD.Parameters.Add("@to", MySqlDbType.VarChar).Value = toDate;
            dta.Fill(dass);
            datt = dass.Tables[0];
        }




        //READ DATA
        public void getProduct()
        {
            //dat.Clear();
            string sql = "SELECT pro_id AS ID, pro_name AS Item FROM product WHERE pro_name LIKE '%"+product+"%'";
            //MySqlCommand selectCMD = new MySqlCommand(sql, conn);
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            //dta.SelectCommand = selectCMD;
            //selectCMD.Parameters.Add("@item", MySqlDbType.VarChar).Value = product;
            dta.Fill(das);
            dat = das.Tables[0];
        }
    }
}
