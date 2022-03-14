using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ManageCategory : Database
    {
        //property for the delete method
        public string category { get; set; }
        public string id { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getCategory()
        {
            dt.Clear();
            string sql = "SELECT cat_id, cat_name FROM category ORDER BY cat_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //Delete
        public void deleteCategory()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM category WHERE cat_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
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

        //Update
        public void updateCategory()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE category SET cat_name = @catname WHERE cat_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@catname", MySqlDbType.VarChar).Value = category;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
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
