using QuanLySinhVien.Models.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class RoleServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public RoleServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public List<Role> GetAll()
        {
            return dbContext.Roles.OrderByDescending(r => r.Name).ToList();
        }

        public void Add(Role role)
        {
            dbContext.Roles.Add(role);
            dbContext.SaveChanges();
        }

        public bool Update(Role role)
        {
            var oldRole = dbContext.Roles.FirstOrDefault(r => r.ID == role.ID);
            if (oldRole != null)
            {
                oldRole = role;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Detele(Role role)
        {
            if (dbContext.Roles.Find(role.ID) != null)
            {
                dbContext.Roles.Remove(role);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}