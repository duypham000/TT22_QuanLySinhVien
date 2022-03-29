using QuanLySinhVien.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models.ModelServices
{
    internal class SubjectScoreServices
    {
        private QuanLySinhVienDbContext dbContext = null;

        public SubjectScoreServices()
        {
            dbContext = new QuanLySinhVienDbContext();
        }

        public List<SubjectScore> GetAll()
        {
            return dbContext.SubjectScores.OrderByDescending(x => x.ID).ToList();
        }

        public SubjectScore GetScore(Student student)
        {
            return dbContext.SubjectScores.Single(x=>x.StudentID == student.ID);
        }

        public void Add(SubjectScore subjectScore)
        {
            dbContext.SubjectScores.Add(subjectScore);
            dbContext.SaveChanges();
        }

        public bool Update(SubjectScore subjectScore)
        {
            var oldSubjectScore = dbContext.SubjectScores.Find(subjectScore.ID);
            if (oldSubjectScore != null)
            {
                oldSubjectScore = subjectScore;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(SubjectScore subjectScore)
        {
            if (dbContext.SubjectScores.Find(subjectScore.ID) != null)
            {
                dbContext.SubjectScores.Remove(subjectScore);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
