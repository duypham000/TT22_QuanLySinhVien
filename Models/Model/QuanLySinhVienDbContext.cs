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
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Class)
                .HasForeignKey(e => e.ClassID);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Classes)
                .WithOptional(e => e.Faculty)
                .HasForeignKey(e => e.FacultyID);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Classes1)
                .WithOptional(e => e.Faculty1)
                .HasForeignKey(e => e.FacultyID);

            modelBuilder.Entity<Role>()
                .Property(e => e.Permission)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.DateOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Classes)
                .WithOptional(e => e.Student)
                .HasForeignKey(e => e.MonitorID);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Classes)
                .WithOptional(e => e.Teacher)
                .HasForeignKey(e => e.LeaderID);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Faculties)
                .WithOptional(e => e.Teacher)
                .HasForeignKey(e => e.LeaderID);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);
        }
    }
}
