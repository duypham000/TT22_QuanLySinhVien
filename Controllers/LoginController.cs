using QuanLySinhVien.Models.ModelServices;

namespace QuanLySinhVien.Controllers
{
    internal class LoginController
    {
        public static bool authenticateAccount(string username, string password)
        {
            UserServices userServices = new UserServices();
            RoleServices roleServices = new RoleServices();
            var roles = roleServices.GetAll();
            var list = userServices.GetAllUsers();
            foreach (var item in list)
            {
                if (item.Username == username && item.Password == password)
                {
                    foreach (var role in roles)
                    {
                        if (role.ID.Equals(item.RoleID))
                        {
                            Properties.Settings.Default.Permission = role.Permission;
                            Properties.Settings.Default.Save();
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}