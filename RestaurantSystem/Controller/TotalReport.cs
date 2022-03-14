using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class TotalReport : Database
    {
        public double totalSales { get; set; }
        public string dailySales { get; set; }
        public string weeklySales { get; set; }
        public string monthlySales { get; set; }
        public string staff { get; set; }
        public string avgHour { get; set; }
        public string avgSales { get; set; }
        public string totalItemDay { get; set; }
        public string totalItemSold { get; set; }

        public void getTotalSalesReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT SUM(ord_net_amount) As countdata FROM orders";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        totalSales = rd.GetDouble("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {

                
            }
            finally
            {
                conn.Close();
            }
           
        }


        public void getDailySalesReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT SUM(ord_net_amount) AS countdata FROM orders WHERE date(created_at) = curdate()";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        dailySales = rd.GetString("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {
                dailySales = "0";


            } finally {
                conn.Close();
            }
           
        }

        public void getWeeklySalesReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT SUM(ord_net_amount) AS countdata FROM orders WHERE WEEK(created_at) = WEEK(NOW())";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        weeklySales = rd.GetString("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {

                weeklySales = "0";
            }
            finally
            {
                conn.Close();
            }
        }

        public void getMonthlySalesReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT SUM(ord_net_amount) AS countdata FROM orders WHERE MONTH(created_at) = MONTH(NOW())";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        monthlySales = rd.GetString("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {

                monthlySales = "0";
            }
            finally
            {
                conn.Close();
            }
        }

        public void getAvgHourReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT AVG(time(created_at)) AS countdata FROM orders";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        avgHour = rd.GetString("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {

                
            }
            finally
            {
                conn.Close();
            }
           
        }

        public void getAvgSalesReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(ord_id) AS countdata FROM orders";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        avgSales = rd.GetString("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {

                avgSales = "0";
            }
            finally
            {
                conn.Close();
            }
            
        }

        public void getDayItemTotalReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(ordit_quantity) AS countdata FROM order_item WHERE date(created_at) = curdate()";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        totalItemDay = rd.GetString("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {

                totalItemDay = "0";
            }
            finally
            {
                conn.Close();
            }
        }


        public void getItemTotalReport()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "select sum(ordit_quantity) as countdata from order_item";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    while (rd.Read() == true)
                    {

                        totalItemSold = rd.GetString("countdata");

                    }
                }
                conn.Close();
            }
            catch (Exception)
            {

                totalItemSold = "0";
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
