using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class ManageUser : Database
    {

        //property for the delete method
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string id { set; get; }
        public string rol { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //READ DATA
        public void getUsers()
        {
            dt.Clear();
            string sql = "SELECT users.users_id, users.users_fname, users.users_lname, users.users_phone, users.users_gender, users.users_uid, users.users_password, role.role FROM users INNER JOIN role USING (role_id)  WHERE users.role_id = '3' OR users.role_id = " + rol + "  OR users.role_id = '2' ORDER BY users_id DESC";
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.Fill(ds);
            dt = ds.Tables[0];
        }

        //Delete
        public void deleteUser()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM users WHERE users_id=@id";
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
        public void updateUser()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string subsql = "SELECT role_id FROM role WHERE role = @role";

                    cmd.CommandText = "UPDATE users SET users_fname = @firstname, users_lname=@lastname, users_phone=@telephone, users_gender=@gender, users_uid=@username, users_password = @password, role_id=(" + subsql + ") WHERE users_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastName;
                    cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = telephone;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                    cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;
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
