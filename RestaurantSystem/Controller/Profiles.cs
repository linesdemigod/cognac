using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Profiles : Database
    {

        public string password { get; set; }
        public string id { get; set; }
        public string oldPassword { get; set; }


        //Method to check and verify the data in the db
        public bool password_verification()
        {
            bool check = false;
            //open database connection


            conn.Open();
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT users_password FROM users WHERE users_uid=@username";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = id;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    check = true;
                    oldPassword = rd.GetString("users_password");
                }

                conn.Close();
            }



            return check;
        }


        //Update
        public void updatePassword()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE users SET users_password = @password WHERE users_uid=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
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
