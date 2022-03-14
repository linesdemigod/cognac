using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class CompanyInfo : Database
    {
        public string company { get; set; }
        public string vat { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public string updateCompany { get; set; }
        public string updateVat { get; set; }
        public string updateAddress { get; set; }
        public string updatePhone { get; set; }


        //SEARCH USER 
        public void getCompany()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM company";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    rd = cmd.ExecuteReader();
                    if (rd.Read() == true)
                    {

                        company = rd.GetString("company_name");
                        vat = rd.GetString("vat_charge_value");
                        address = rd.GetString("address");
                        phone = rd.GetString("phone");

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

        //Update
        public void update_company()
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE company SET  company_name = @name, vat_charge_value = @vat, address = @address, phone = @phone";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = updateCompany;
                    cmd.Parameters.Add("@vat", MySqlDbType.VarChar).Value = updateVat;
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = updateAddress;
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = updatePhone;
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
