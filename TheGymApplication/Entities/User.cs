﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGymApplication.Entities
{
    internal class User
    {
        public int userId { get; set; }
        public string userFName { get; set; }
        public string userLName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public int numberOfVisits { get; set; }

        public User(int userId, string userFName, string userLName, string userEmail, string userPassword, int numberOfVisits)
        {
            this.userId = userId;
            this.userFName = userFName;
            this.userLName = userLName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.numberOfVisits = numberOfVisits;
        }
        public static List<User> PopulateUserList()
        {

            List<User> users_list = new List<User>();


            using (MySqlConnection connection = SingeltonConnection.Connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM CUSTOMERS", connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string userFName = reader.GetString(1);
                        string userLName = reader.GetString(2);
                        string userEmail = reader.GetString(3);
                        string userPassword = reader.GetString(4);
                        int numberOfVisits = reader.GetInt32(5);

                        User user = new User(userId, userFName, userLName, userEmail, userPassword, numberOfVisits);
                        users_list.Add(user);
                    }
                    return users_list;
                }
            }
        }
    }
}