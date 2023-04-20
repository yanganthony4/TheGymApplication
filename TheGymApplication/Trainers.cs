using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TheGymApplication
{
    
    public class Trainers: SingeltonConnection
    {
        public static string GetFirstName()
        {
            string firstName = null;

            using (MySqlConnection connection = SingeltonConnection.Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT  FROM TRAINERS", connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        
                    }
                }
            }

            return firstName;
        }
      
    }
}
