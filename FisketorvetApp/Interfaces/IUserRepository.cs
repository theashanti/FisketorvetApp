using System.Collections.Generic;
using FisketorvetApp.Models;

//Martin

namespace FisketorvetApp.Interfaces
{
    public interface IUserRepository
    {
        public List<User> AllUsers();

        public void AddUser(User user);

        public List<User> Filter_By_StartCriteria(string criteria);

        public User GetUser(int id);
  
        public void WriteChanges();
    }
}