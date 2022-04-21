using QuanLySinhVien.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class FacultyServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public FacultyServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public List<Faculty> GetAll()
        {
            return dbContext.Faculties.OrderByDescending(x => x.ID).ToList();
        }

        public Faculty GetById(string id)
        {
            return dbContext.Faculties.Find(id);
        }

        public void Add(Faculty faculty)
        {
            dbContext.Faculties.Add(faculty);
            dbContext.SaveChanges();
        }

        public bool Update(Faculty faculty, string id)
        {
            var oldFaculty = dbContext.Faculties.Find(id);
            if (oldFaculty != null)
            {
                dbContext.Faculties.Remove(oldFaculty);
                dbContext.Faculties.Add(faculty);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Faculty faculty)
        {
            if (dbContext.Faculties.Find(faculty.ID) != null)
            {
                dbContext.Faculties.Remove(faculty);
                return true;
            }
            return false;
        }

        public bool DeleteByID(string id)
        {
            Faculty faculty = dbContext.Faculties.Find(id);
            if ( faculty != null)
            {
                dbContext.Faculties.Remove(faculty);
                return true;
            }
            return false;
        }
    }
}
