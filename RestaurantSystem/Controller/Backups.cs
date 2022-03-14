using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller
{
    class Backups : Database
    {
        string file = @"C:\Cog\HE23HJO8OP43HT.sql";
       
        public void backup()
        {
            try
            {
                using (var cmd = new MySqlCommand())
                {

                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();

                    }
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

        public void restore()
        {
            try
            {
                using (var cmd = new MySqlCommand())
                {

                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();

                    }
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

        //create folder
        //create new folder
        public void createFolder()
        {
            string folderName = @"C:\Cog";

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
    }
}
