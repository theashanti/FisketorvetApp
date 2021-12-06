﻿using System.Collections.Generic;
using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;

// Martin

namespace FisketorvetApp.Repositories
{
    public class UserJsonFile : IUserRepository
    {
        
        //C:\Users\marti\Desktop\FisketorvetApp\FisketorvetApp\Data\JsonUsers.json
        
        string JsonFilePath = @"C:\Users\marti\Desktop\FisketorvetApp\FisketorvetApp\Data\JsonUsers.json";
        private List<User> users;

        public UserJsonFile()
        {
            users = JsonHelper.ReadUserFile(JsonFilePath);
        }
        
        public List<User> AllUsers()
        {
            return JsonHelper.ReadUserFile(JsonFilePath);
        }

        public void AddUser(User user)
        {
            users.Add(user);
            JsonHelper.WriteUserFile(users, JsonFilePath);
        }
        

        public List<User> Filter_By_StartCriteria(string criteria)
        {
            List<User> filteredUsers = new List<User>();

            foreach (User user in users)
            {
                if (user.Name.StartsWith(criteria))
                {
                    filteredUsers.Add(user);
                }
            }

            return filteredUsers;
        }

        public User GetUser(int id)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            
            return null;
        }
    }
}