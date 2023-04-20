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
                MySqlCommand command = new MySqlCommand("SELECT FirstName FROM Trainers", connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        firstName = reader.GetString(0);
                    }
                }
            }

            return firstName;
        }
      
    }
}
