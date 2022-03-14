using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class AddUser : Database
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string checkUid { get; set; }


        //check if the username exist
        public bool uidExist()
        {
            bool check = false;
            try
            {
               
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM users WHERE users_uid = @username";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        check = true;
                        checkUid = rd.GetString("users_uid");
                    }

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

            return check;
        }


        //Insert the data to the database
        public void createUser()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO users(users_fname, users_lname, users_phone, users_gender, users_uid, users_password, role_id) VALUES(@firstname, @lastname, @telephone, @gender, @username, @password, (SELECT role_id FROM role WHERE role = @role))";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastName;
                    cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = telephone;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;
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


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getRole()
        {
            dt.Clear();
            string sql = "SELECT * FROM role";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
