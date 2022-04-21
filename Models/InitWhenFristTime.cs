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
                role.Name = "Quản trị viên";
                role.Description = "Super User";
                role.ID = "admin";

                roleServices.Add(role);
            }
            if (dbContext.Users.Count() < 1)
            {
                User user = new User();
                user.Username = "Duyn";
                user.Email = "duypham05082002@gmail.com";
                user.Password = "0508";
                user.RoleID = "admin";

                userServices.Add(user);
            }
        }
    }
}