using QuanLySinhVien.Models.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class ClassServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public ClassServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public List<Class> GetAll()
        {
            return dbContext.Classes.OrderByDescending(x=>x.ID).ToList();
        }

        public Class GetById(int id)
        {
            return dbContext.Classes.Find(id);
        }

        public void Add(Class @class)
        {
            dbContext.Classes.Add(@class);
            dbContext.SaveChanges();
        }

        public bool Update(Class @class)
        {
            var oldClass = dbContext.Classes.Find(@class.ID);
            if (oldClass != null)
            {
                dbContext.Classes.Find(@class.ID).Name = @class.Name;
                dbContext.Classes.Find(@class.ID).FacultyID = @class.FacultyID;
                dbContext.Classes.Find(@class.ID).LeaderID = @class.LeaderID;
                dbContext.Classes.Find(@class.ID).MonitorID = @class.MonitorID;
                dbContext.Classes.Find(@class.ID).UpdatedBy = @class.UpdatedBy;
                dbContext.Classes.Find(@class.ID).UpdatedDate = @class.UpdatedDate;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Class @class)
        {
            if (dbContext.Classes.Find(@class.ID) != null)
            {
                dbContext.Classes.Remove(@class);
                return true;
            }
            return false;
        }
    }
}