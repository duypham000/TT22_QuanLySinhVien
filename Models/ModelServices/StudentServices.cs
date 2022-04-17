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
            return dbContext.Students.OrderByDescending(x => x.ID).ToList();
        }

        public void Add(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }

        public Student GetByID(string id)
        {
            return dbContext.Students.Find(id);
        }

        public bool Update(Student student, string id)
        {
            var oldStudent = dbContext.Students.Find(id);
            if (oldStudent != null)
            {
                dbContext.Students.Remove(oldStudent);
                dbContext.Students.Add(student);
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

        public void DeleteByID(string id)
        {
            Student student = dbContext.Students.Single(x=>x.ID == id);

            dbContext.Students.Remove(student);
            dbContext.SaveChanges();
        }
    }
}