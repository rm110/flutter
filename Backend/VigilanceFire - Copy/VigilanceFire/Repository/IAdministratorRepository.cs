using Microsoft.EntityFrameworkCore;
using VigilanceFire.Data;
using VigilanceFire.Models;

namespace VigilanceFire.Repository
{
    public interface IAdministratorRepository
    {
        public List<Administrator> GetAll();
        Administrator SignIn(int admin_Id, string name);
        List<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }

    public class AdministratorRepository : IAdministratorRepository
    {
        VigilanceFireContext db = new VigilanceFireContext();
        public Administrator SignIn(int admin_Id, string name)
        {
            return db.Administrator.FirstOrDefault(a => a.admin_Id == admin_Id && a.name == name );
        }

        public List<Administrator> GetAll()
        {
            return db.Administrator.ToList();
        }
        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return db.Users.FirstOrDefault(u => u.user_Id == id);
        }

        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = db.Users.FirstOrDefault(u => u.user_Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
