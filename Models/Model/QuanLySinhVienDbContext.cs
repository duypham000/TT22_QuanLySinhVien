using System.Data.Entity;

namespace QuanLySinhVien.Models.Model
{
    public partial class QuanLySinhVienDbContext : DbContext
    {
        public QuanLySinhVienDbContext()
            : base("name=QuanLySinhVienDbContext")
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.Leader)
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
                .WithRequired(e => e.Class)
                .HasForeignKey(e => e.ClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
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

            modelBuilder.Entity<Teacher>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Teacher)
                .HasForeignKey(e => e.Leader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Teacher)
                .HasForeignKey(e => e.InforID);

            modelBuilder.Entity<User>()
                .Property(e => e.InforID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}