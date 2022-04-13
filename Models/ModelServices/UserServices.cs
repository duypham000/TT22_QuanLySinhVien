using QuanLySinhVien.Models.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class UserServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public UserServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public int Count()
        {
            return dbContext.Users.Count();
        }

        public List<User> GetAllUsers()
        {
            return dbContext.Users.OrderBy(x => x.Username).ToList();
        }

        public List<User> GetAllPaging(int page, int itemCount)
        {
            return dbContext.Users.OrderBy(x => x.Username).Skip((page - 1) * itemCount).Take(itemCount).ToList();
        }

        public User GetByUsername(string username)
        {
            return dbContext.Users.SingleOrDefault(x => x.Username == username);
        }

        public bool Update(User user, string username)
        {
            var oldUser = dbContext.Users.Find(username);
            if (oldUser == null)
            {
                return false;
            }
            else
            {
                oldUser = user;
                dbContext.SaveChanges();
                return true;
            }
        }

        public void Add(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void Delete(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }

        public void DeleteByUsername(string username)
        {
            User user = new User();
            user = dbContext.Users.SingleOrDefault(x => x.Username == username);
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}