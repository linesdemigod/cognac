using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Login : Database
    {

        public string username { get; set; }
        public string password { get; set; }
        public int role { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }


        //Method to check and verify the data in the db
        public bool user_verification()
        {
            bool check = false;
            //open database connection

            
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM users WHERE users_uid=@username AND users_password=@password";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        check = true;
                        role = rd.GetInt32("role_id");
                        fname = rd.GetString("users_fname");
                        lname = rd.GetString("users_lname");
                        gender = rd.GetString("users_gender");
                        phone = rd.GetString("users_phone");
                    }

                    conn.Close();
                }
            
            

            return check;
        }
    }
}
