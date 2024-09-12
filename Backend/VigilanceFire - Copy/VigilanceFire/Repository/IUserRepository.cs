using System;
using VigilanceFire.Models;
using VigilanceFire.Data;
using Microsoft.EntityFrameworkCore;

namespace VigilanceFire.Repository
{
    public interface IUserRepository
    {
        public List<User> GetAll();
        User SignIn( int user_Id ,string name);
    }

    class UserRepository : IUserRepository
    {
        VigilanceFireContext db = new VigilanceFireContext();
        public User SignIn(int user_Id, string name)
        {
            return db.Users.FirstOrDefault(u => u.user_Id == user_Id && u.name == name);
        }
        public List<User> GetAll()
        {
            return db.Users.ToList();
        }
    }
}