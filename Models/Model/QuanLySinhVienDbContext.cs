using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien.Models.Model
{
    public partial class QuanLySinhVienDbContext : DbContext
    {
        public QuanLySinhVienDbContext()
            : base("name=QuanLySinhVienDbContext")
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectScore> SubjectScores { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.LeaderID)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.MonitorID)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.ViceID)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Class)
                .HasForeignKey(e => e.ClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.Teachers)
                .WithOptional(e => e.Class)
                .HasForeignKey(e => e.ClassID);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.LeaderID)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.MonitorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Classes1)
                .WithRequired(e => e.Student1)
                .HasForeignKey(e => e.ViceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Student)
                .HasForeignKey(e => e.InforID);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.SubjectScores)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.TeacherID)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SubjectScore>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<SubjectScore>()
                .Property(e => e.SubjectID)
                .IsUnicode(false);

            modelBuilder.Entity<SubjectScore>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SubjectScore>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.LeaderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Faculties)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.LeaderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Teacher)
                .HasForeignKey(e => e.InforID);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.InforID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
