using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RestaurantSystem.Controller
{
    class Database
    {

        public MySqlConnection conn;
        public MySqlCommand cmd;
        public MySqlDataReader rd;
        Configuration config;

        public string dbSource = Properties.Settings.Default.dbSource;
        public string port = Properties.Settings.Default.port;
        public string user = Properties.Settings.Default.user;
        public string db = Properties.Settings.Default.db;
        public string ssl = Properties.Settings.Default.ssl;
        public string password = Properties.Settings.Default.password;
        public string connection;

        public Database()
        {
            
                connection = "datasource=" + dbSource + ";port=" + port + ";user Id=" + user + ";password="+password+";database=" + db + ";SSL Mode=" + ssl + "";

                conn = new MySqlConnection(connection);
                cmd = conn.CreateCommand();

            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

           
        }

        //the connection string from the app.config
        public string getConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        
        public void saveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "MySql.Data.MySqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
