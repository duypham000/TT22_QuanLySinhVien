﻿using QuanLySinhVien.Models.Model;
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

        public List<User> GetAllUsers()
        {
            return dbContext.Users.OrderByDescending(x => x.Username).ToList();
        }

        public User GetByUsername(string username)
        {
            return dbContext.Users.SingleOrDefault(x => x.Username == username);
        }

        public bool Update(User user)
        {
            var oldUser = dbContext.Users.Find(user.Username);
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
    }
}