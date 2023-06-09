﻿using System;
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
        public int customerId { get; set; }
        public string bookingTime { get; set; }
        public string bookingDescription { get; set; }


        public Bookings(int bookingId, int trainerId, int customerId, string bookingTime, string bookingDescription) //Constructor for booking object
        {
            this.bookingId = bookingId;
            this.trainerId = trainerId;
            this.customerId = customerId;
            this.bookingTime = bookingTime;
            this.bookingDescription = bookingDescription;
        }
        public static List<Bookings> PopulateBookingList()  //Populates all rows in bookings table as objects in a list
        {
            List<Bookings> bookings_list = new List<Bookings>();
            using (MySqlConnection connection = Connection)
                {
                    string query = "SELECT * FROM BOOKINGS";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            int bookingId = reader.GetInt32(0);
                            int trainingId = reader.GetInt32(1);
                            int customerId = reader.GetInt32(2);
                            string bookingTime= reader.GetString(3);
                            string bookingDescription= reader.GetString(4);

                            Bookings bookings = new Bookings(bookingId, trainingId, customerId, bookingTime, bookingDescription);
                            bookings_list.Add(bookings);                         
                        }
                    }
                }
                return bookings_list;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Bookings other = (Bookings)obj;
            return bookingDescription == other.bookingDescription && bookingTime == other.bookingTime;
        }


        //public static List<Bookings> PopulateBookingData()
        //{
        //    List<Bookings> listbooking = new List<Bookings>();
        //    MySqlConnection connection = Connection;
        //    MySqlCommand command = new MySqlCommand("SELECT * FROM bookings", connection);
        //    using (MySqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            int bookingId = reader.GetInt32(0);
        //            int trainerId = reader.GetInt32(1);
        //            string bookingDate = reader.GetString(2);
        //            int bookingLength = reader.GetInt32(3);
        //            Bookings booking = new Bookings(bookingId, trainerId, bookingDate, bookingLength);
        //            listbooking.Add(booking);
        //        }
        //        return listbooking;
        //    }
        //}


    }
}