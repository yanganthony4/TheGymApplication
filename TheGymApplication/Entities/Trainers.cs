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

        

        public static string AddToSchedule1()
        {
            try
            {
                using MySqlConnection connection1 = Connection;
                MySqlCommand command1 = new MySqlCommand("INSERT INTO bookings (booking_id, trainer_id, customer_id, booking_time, booking_description) VALUES  (@Value1, @Value2, @Value3, @Value4, @Value5)", connection1);
                command1.Parameters.AddWithValue("@Value1", 1);
                command1.Parameters.AddWithValue("@Value2", 1);
                command1.Parameters.AddWithValue("@Value3", 1);
                command1.Parameters.AddWithValue("@Value4", "2-5pm");
                command1.Parameters.AddWithValue("@Value5", "Keith John");
                command1.ExecuteNonQuery();
                
                return "hello";
            }
            catch (Exception ex)
            {
                // handle the exception
                return "Error: " + ex.Message;
            }
        }

        public static string AddToSchedule2()
        {
            try
            {
                using MySqlConnection connection2 = Connection;
                MySqlCommand command2 = new MySqlCommand("INSERT INTO bookings (booking_id, trainer_id, customer_id, booking_time, booking_description) VALUES  (@Value1, @Value2, @Value3, @Value4, @Value5)", connection2);
                command2.Parameters.AddWithValue("@Value1", 2);
                command2.Parameters.AddWithValue("@Value2", 2);
                command2.Parameters.AddWithValue("@Value3", 2);
                command2.Parameters.AddWithValue("@Value4", "10-6pm");
                command2.Parameters.AddWithValue("@Value5", "Barry Owens");
                command2.ExecuteNonQuery();

                return "hello";
            }
            catch (Exception ex)
            {
                // handle the exception
                return "Error: " + ex.Message;
            }
        }
    }
}
