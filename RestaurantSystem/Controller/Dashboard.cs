using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Dashboard : Database
    {

        //variables
        public string id { get; set; }
        public string users { get; set; }
        public string category { get; set; }

        //SEARCH USER 
        public void getProduct()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT count(pro_id) As countdata FROM product";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        id = rd.GetString("countdata");


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
        
        //SEARCH USER 
        public void getUser()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT count(users_id) As countdata FROM users";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        users = rd.GetString("countdata");
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
        
        //SEARCH USER 
        public void getCategory()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT count(cat_id) As countdata FROM category";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        category = rd.GetString("countdata");
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

