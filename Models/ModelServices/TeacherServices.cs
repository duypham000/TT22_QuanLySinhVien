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
                oldTeacher = teacher;
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
    }
}