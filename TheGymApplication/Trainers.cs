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
        public int Trainerid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }   
        public string Speciality { get; set; }  


        public void PopulateTrainerName()
        {
            string sql = "SELECT TrainerId, FirstName, LastName, Speciality FROM Trainers";
            MySqlCommand command = new MySqlCommand(); 

            MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                this.Trainerid = reader.GetInt32(0);
                this.Fname = reader.GetString(1);
                this.Lname = reader.GetString(2);
                this.Speciality = reader.GetString(3); 
            }
            

        }
    }
}
