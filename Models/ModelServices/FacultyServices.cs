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

        public Faculty GetById(int id)
        {
            return dbContext.Faculties.Find(id);
        }

        public void Add(Faculty faculty)
        {
            dbContext.Faculties.Add(faculty);
            dbContext.SaveChanges();
        }

        public bool Update(Faculty faculty)
        {
            var oldFaculty = dbContext.Faculties.Find(faculty.ID);
            if (oldFaculty != null)
            {
                dbContext.Faculties.Find(faculty.ID).Name = faculty.Name;
                dbContext.Faculties.Find(faculty.ID).LeaderID = faculty.LeaderID;
                dbContext.Faculties.Find(faculty.ID).UpdatedBy = faculty.UpdatedBy;
                dbContext.Faculties.Find(faculty.ID).UpdatedDate = faculty.UpdatedDate;

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

        public bool DeleteByID(int id)
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
