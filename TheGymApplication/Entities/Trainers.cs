using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TheGymApplication.Entities
{

    public class Trainers : SingeltonConnection
    {
        public int trainerId { get; set; }
        public string fName { get; set; }

        public string lName { get; set; }
        public string speciality { get; set; }

        public Trainers(int trainerId, string fName, string lName, string speciality)
        {
            this.trainerId = trainerId;
            this.fName = fName;
            this.lName = lName;
            this.speciality = speciality;
        }

        public static List<Trainers> PopulateTrainerData()
        {
            List<Trainers> listtrainers = new List<Trainers>();
            using (MySqlConnection connection = Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM trainers", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int trainerId = reader.GetInt32(0);
                        string fName = reader.GetString(1);
                        string lName = reader.GetString(2);
                        string speciality = reader.GetString(3);
                        Trainers trainer = new Trainers(trainerId, fName, lName, speciality);
                        listtrainers.Add(trainer);
                    }
                    return listtrainers;
                }
            }
        }
    }
}
