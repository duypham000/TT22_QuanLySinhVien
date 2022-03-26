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
                oldClass = @class;
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