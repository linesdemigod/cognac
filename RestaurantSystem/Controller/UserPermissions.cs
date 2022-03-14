using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class UserPermissions : Database
    {

        public string id { get; set; }
        public string value { get; set; }

        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

       
        //READ DATA
        public void getPermission()
        {
            dt.Clear();
            string sql = "SELECT * FROM permissions";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        

        //Update
        public void setPermissions()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE permissions SET per_value = @value WHERE per_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@value", MySqlDbType.VarChar).Value = value;
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
