using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TheGymApplication.Entities
{
    internal class Bookings : SingeltonConnection
    {
        public int bookingId { get; set; }
        public int trainerId { get; set; }
        public string bookingDate { get; set; }
        public int bookingLength { get; set; }


        public Bookings(int bookingId, int trainerId, string bookingDate, int bookingLength)
        {
            this.bookingId = bookingId;
            this.trainerId = trainerId;
            this.bookingDate = bookingDate;
            this.bookingLength = bookingLength;
        }

        public static List<Bookings> PopulateBookingData()
        {
            List<Bookings> listbooking = new List<Bookings>();
            MySqlConnection connection = Connection;
            MySqlCommand command = new MySqlCommand("SELECT * FROM bookings", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int bookingId = reader.GetInt32(0);
                    int trainerId = reader.GetInt32(1);
                    string bookingDate = reader.GetString(2);
                    int bookingLength = reader.GetInt32(3);
                    Bookings booking = new Bookings(bookingId, trainerId, bookingDate, bookingLength);
                    listbooking.Add(booking);
                }
                return listbooking;
            }
        }


    }
}