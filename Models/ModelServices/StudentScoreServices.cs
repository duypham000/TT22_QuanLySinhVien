using QuanLySinhVien.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class StudentScoreServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public StudentScoreServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public List<StudentScore> GetAll()
        {
            return dbContext.StudentScores.OrderByDescending(x => x.ID).ToList();
        }

        public StudentScore GetScore(Student student)
        {
            return dbContext.StudentScores.Single(x=>x.StudentID == student.ID);
        }

        public void Add(StudentScore studentScore)
        {
            dbContext.StudentScores.Add(studentScore);
            dbContext.SaveChanges();
        }

        public bool Update(StudentScore studentScore)
        {
            var oldStudentScore = dbContext.StudentScores.Find(studentScore.ID);
            if (oldStudentScore != null)
            {
                oldStudentScore = studentScore;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(StudentScore studentScore)
        {
            if (dbContext.StudentScores.Find(studentScore.ID) != null)
            {
                dbContext.StudentScores.Remove(studentScore);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
