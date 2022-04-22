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

        public Role GetByID(int id)
        {
            return dbContext.Roles.Find(id);
        }

        public void Add(Role role)
        {
            dbContext.Roles.Add(role);
            dbContext.SaveChanges();
        }

        public bool Update(Role role)
        {
            var oldRole = dbContext.Roles.Find(role.ID);
            if (oldRole != null)
            {
                dbContext.Roles.Find(role.ID).Name = role.Name;
                dbContext.Roles.Find(role.ID).Description = role.Description;
                dbContext.Roles.Find(role.ID).Permission = role.Permission;
                dbContext.Roles.Find(role.ID).UpdatedBy = role.UpdatedBy;
                dbContext.Roles.Find(role.ID).UpdatedDate = role.UpdatedDate;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeteleById(int id)
        {
            Role role = dbContext.Roles.Find(id);
            if (role != null)
            {
                dbContext.Roles.Remove(role);
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