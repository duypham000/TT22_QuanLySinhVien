using QuanLySinhVien.Models.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class TeacherServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public TeacherServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public List<Teacher> GetAll()
        {
            return dbContext.Teachers.OrderByDescending(x => x.ID).ToList();
        }

        public Teacher GetById(int id)
        {
            return dbContext.Teachers.Find(id);
        }

        public void Add(Teacher teacher)
        {
            dbContext.Teachers.Add(teacher);
            dbContext.SaveChanges();
        }

        public bool Update(Teacher teacher)
        {
            var oldTeacher = dbContext.Teachers.Find(teacher.ID);
            if (oldTeacher != null)
            {
                dbContext.Teachers.Find(teacher.ID).Name = teacher.Name;
                dbContext.Teachers.Find(teacher.ID).UserID = teacher.UserID;
                dbContext.Teachers.Find(teacher.ID).Phone = teacher.Phone;
                dbContext.Teachers.Find(teacher.ID).UpdatedBy = teacher.UpdatedBy;
                dbContext.Teachers.Find(teacher.ID).UpdatedDate = teacher.UpdatedDate;
                dbContext.Teachers.Find(teacher.ID).Status = teacher.Status;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Teacher teacher)
        {
            if (dbContext.Teachers.Find(teacher.ID) != null)
            {
                dbContext.Teachers.Remove(teacher);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteById(int id)
        {
            Teacher teacher = dbContext.Teachers.Find(id);
            if (teacher != null)
            {
                dbContext.Teachers.Remove(teacher);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}