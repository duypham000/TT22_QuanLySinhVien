using QuanLySinhVien.Models.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class StudentServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public StudentServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public List<Student> GetAll()
        {
            return dbContext.Students.OrderByDescending(x => x.Name).ToList();
        }

        public void Add(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }

        public bool Update(Student student)
        {
            var oldStudent = dbContext.Students.Find(student.ID);
            if (oldStudent != null)
            {
                oldStudent = student;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Student student)
        {
            if (dbContext.Students.Find(student.ID) != null)
            {
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}