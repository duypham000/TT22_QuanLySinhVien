using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien.Models
{
    internal class InitWhenFristTime
    {
        private QuanLySinhVienDbContext dbContext = null;
        private UserServices userServices = null;
        private RoleServices roleServices = null;

        public InitWhenFristTime()
        {
            dbContext = new QuanLySinhVienDbContext();
            Database.SetInitializer<QuanLySinhVienDbContext>(new CreateDatabaseIfNotExists<QuanLySinhVienDbContext>());
            userServices = new UserServices();
            roleServices = new RoleServices();
        }

        public void InsertUserDemoData()
        {
            if (dbContext.Roles.Count() < 1)
            {
                Role role = new Role();
                role.Name = "Admin";
                role.Description = "Super User";
                role.Status = true;
                role.ID = 1;

                roleServices.Add(role);
            }
            if (dbContext.Users.Count() < 1)
            {
                User user = new User();
                user.Username = "admin";
                user.Email = "duypham05082002@gmail.com";
                user.Password = "0508";
                user.Status = true;
                user.RoleID = 1;

                userServices.Add(user);
            }
        }
    }
}