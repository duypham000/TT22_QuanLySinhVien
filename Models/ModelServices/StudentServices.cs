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

        public Student GetByID(int id)
        {
            return dbContext.Students.Find(id);
        }

        public bool Update(Student student)
        {
            int id = student.ID;
            var oldStudent = dbContext.Students.Find(id);
            if (oldStudent != null)
            {
                dbContext.Students.Find(id).StudentID = student.StudentID;
                dbContext.Students.Find(id).Address = student.Address;
                dbContext.Students.Find(id).Name = student.Name;
                dbContext.Students.Find(id).Phone = student.Phone;
                dbContext.Students.Find(id).DateOfBirth = student.DateOfBirth;
                dbContext.Students.Find(id).SchoolProfile = student.SchoolProfile;
                dbContext.Students.Find(id).Religion = student.Religion;
                dbContext.Students.Find(id).ClassRole = student.ClassRole;
                dbContext.Students.Find(id).ClassID = student.ClassID;
                dbContext.Students.Find(id).UpdatedDate = student.UpdatedDate;
                dbContext.Students.Find(id).UpdatedBy = student.UpdatedBy;
                dbContext.Students.Find(id).Status = student.Status;
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

        public void DeleteByID(int id)
        {
            Student student = dbContext.Students.Find(id);

            dbContext.Students.Remove(student);
            dbContext.SaveChanges();
        }
    }
}