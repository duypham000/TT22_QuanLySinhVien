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

        public bool Update(User user)
        {
            var oldUser = dbContext.Users.Find(user.ID);
            if (oldUser != null)
            {
                dbContext.Users.Find(user.ID).Username = user.Username;
                dbContext.Users.Find(user.ID).RoleID = user.RoleID;
                dbContext.Users.Find(user.ID).Password = user.Password;
                dbContext.Users.Find(user.ID).Email = user.Email;
                dbContext.Users.Find(user.ID).UpdatedBy = user.UpdatedBy;
                dbContext.Users.Find(user.ID).UpdatedDate = user.UpdatedDate;

                dbContext.SaveChanges();
                return true;
            }
            return false;
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