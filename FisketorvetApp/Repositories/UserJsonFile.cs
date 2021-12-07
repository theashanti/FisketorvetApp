using System.Collections.Generic;
using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;

// Martin

namespace FisketorvetApp.Repositories
{
    public class UserJsonFile : IUserRepository
    {

        //C:\Users\marti\Desktop\FisketorvetApp\FisketorvetApp\Data\JsonUsers.json
        //Máté directory: E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonUsers.json
        //Ash C:\Users\ashan\OneDrive\Área de Trabalho\FisketorvetApp\FisketorvetApp\Data\JsonUsers.json
        //mitra  C:\Users\Uni\Source2\Repos\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonUsers.json
        //Dom: C:\Users\Lenovo\OneDrive - Zealand\Desktop\FisketorvetApp-master\FisketorvetApp\Data\JsonUsers.json
        string JsonFilePath = @"C:\Users\Lenovo\OneDrive - Zealand\Desktop\FisketorvetApp-master\FisketorvetApp\Data\JsonUsers.json";
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

            {foreach (User user in users)
            {
                if (user.Id == id)
                {
                    
                    return user;
                }
            }}

            return null;
        }
        public void EditUser(User u)
        {
            if (u != null)
            {
                foreach (var user in users)
                {
                    if (user.Email== u.Email)
                    {
                        user.Email = u.Email;
                        user.Name = u.Name;
                        user.PhoneNumber = u.PhoneNumber;
                        user.DateOfBirthDay = u.DateOfBirthDay;
                        user.DateOfBirthMonth = u.DateOfBirthMonth;
                        user.DateOfBirthYear = u.DateOfBirthYear;
                        user.Password = u.Password;
                        user.Address.Street = u.Address.Street;
                        user.Address.HouseNumber = u.Address.HouseNumber;
                        user.Address.PostalCode = u.Address.PostalCode;
                        user.Address.City = u.Address.City;
                        JsonHelper.WriteUserFile(users, JsonFilePath);
                        break;
                    }
                }
            }
        }
    }
}