using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Controllers
{
    internal class LoginController
    {
        public static bool authenticateAccount(string username, string password)
        {
            UserServices userServices = new UserServices();
            var list = userServices.GetAllUsers();
            foreach (var item in list)
            {
                if (item.Username == username && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
