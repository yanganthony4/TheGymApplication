using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGymApplication.Entities
{
    internal class Book
    {
        public static string AddToSchedule1()
        {
            MySqlConnection con = SingeltonConnection.Connection;

            MySqlCommand command1 = new MySqlCommand("INSERT INTO bookings (booking_id, trainer_id, customer_id, booking_time, booking_description) VALUES  (@Value1, @Value2, @Value3, @Value4, @Value5) ON DUPLICATE KEY UPDATE booking_id=booking_id", con);
            command1.Parameters.AddWithValue("@Value1", 1);
            command1.Parameters.AddWithValue("@Value2", 1);
            command1.Parameters.AddWithValue("@Value3", 1);
            command1.Parameters.AddWithValue("@Value4", "2-5 pm");
            command1.Parameters.AddWithValue("@Value5", "Keith John");
            command1.ExecuteNonQuery();

            //using var cmd = con.CreateCommand();
            //cmd.CommandText = "select * from bookings";
            //var reader = cmd.ExecuteReader();
            //do
            //{
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("RESULT: " + reader.GetString(4));
            //    }
            //} while (reader.NextResult());

            return "hello";

        }
        public static string AddToSchedule2()
        {

            MySqlConnection con = SingeltonConnection.Connection;

            MySqlCommand command1 = new MySqlCommand("INSERT INTO bookings (booking_id, trainer_id, customer_id, booking_time, booking_description) VALUES  (@Value1, @Value2, @Value3, @Value4, @Value5) ON DUPLICATE KEY UPDATE booking_id=booking_id", con);
            command1.Parameters.AddWithValue("@Value1", 2);
            command1.Parameters.AddWithValue("@Value2", 2);
            command1.Parameters.AddWithValue("@Value3", 2);
            command1.Parameters.AddWithValue("@Value4", "10-6 pm");
            command1.Parameters.AddWithValue("@Value5", "Barry Owens");
            command1.ExecuteNonQuery();

            return "hello";
            
            
        }
        public static string AddToSchedule3()
        {

            MySqlConnection con = SingeltonConnection.Connection;

            MySqlCommand command1 = new MySqlCommand("INSERT INTO bookings (booking_id, trainer_id, customer_id, booking_time, booking_description) VALUES  (@Value1, @Value2, @Value3, @Value4, @Value5) ON DUPLICATE KEY UPDATE booking_id=booking_id", con);
            command1.Parameters.AddWithValue("@Value1", 3);
            command1.Parameters.AddWithValue("@Value2", 3);
            command1.Parameters.AddWithValue("@Value3", 3);
            command1.Parameters.AddWithValue("@Value4", "10-3 pm");
            command1.Parameters.AddWithValue("@Value5", "Reese Penny");
            command1.ExecuteNonQuery();

            return "hello";


        }
        public static string AddToSchedule4()
        {

            MySqlConnection con = SingeltonConnection.Connection;

            MySqlCommand command1 = new MySqlCommand("INSERT INTO bookings (booking_id, trainer_id, customer_id, booking_time, booking_description) VALUES  (@Value1, @Value2, @Value3, @Value4, @Value5) ON DUPLICATE KEY UPDATE booking_id=booking_id", con);
            command1.Parameters.AddWithValue("@Value1", 4);
            command1.Parameters.AddWithValue("@Value2", 4);
            command1.Parameters.AddWithValue("@Value3", 4);
            command1.Parameters.AddWithValue("@Value4", "7-2 pm");
            command1.Parameters.AddWithValue("@Value5", "Chad Bulwark");
            command1.ExecuteNonQuery();

            return "hello";


        }

    }
}
