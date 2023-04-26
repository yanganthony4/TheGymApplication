using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TheGymApplication
{
    public class SingeltonConnection
    {
        public static MySqlConnection Connection
        {
            get
            { 
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
                {
                    Server = "localhost",
                    UserID = "root",
                    Password = "password",
                    Database = "thegymdb"
                };

                var _connection = new MySqlConnection(builder.ConnectionString);
                _connection.Open();
                return _connection;
            }
        }
    }
}
