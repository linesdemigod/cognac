using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Expenses : Database
    {
        public string amount { get; set; }
        public string purpose { get; set; }
        public string id { get; set; }
        public string user { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }


        //Read data
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //Insert the data to the database
        public void addExpenses()
        {
            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO expense(exp_purpose, exp_amount, exp_user) VALUES(@purpose, @amount, @id)";

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = purpose;
                    cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;
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

       
        //READ DATA
        public void getExpenses()
        {
            dt.Clear();
            string sql = "SELECT * FROM expense WHERE created_at BETWEEN @from AND @to ORDER BY created_at DESC";
            MySqlCommand selectCMD = new MySqlCommand(sql, conn);
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, conn);
            dta.SelectCommand = selectCMD;
            selectCMD.Parameters.Add("@from", MySqlDbType.VarChar).Value = fromDate;
            selectCMD.Parameters.Add("@to", MySqlDbType.VarChar).Value = toDate;
            dta.Fill(ds);
            dt = ds.Tables[0];
        }


        //Delete
        public void deleteExpenses()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM expense WHERE pro_id=@id";
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


        //Update product
        public void updateExpenses()
        {

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "UPDATE expense SET exp_purpose = @purpose, exp_amount = @amount, exp_user = @user WHERE exp_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@purpose", MySqlDbType.VarChar).Value = purpose;
                    cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
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
