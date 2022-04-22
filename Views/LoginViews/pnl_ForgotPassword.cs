using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using QuanLySinhVien.Views.LoginView;
using QuanLySinhVien.Controllers;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.LoginViews
{
    public partial class pnl_ForgotPassword : Form
    {
        private string otpCode = null;
        private string curent_usename = null;
        private UserServices userServices = null;
        private layout_Login layout = null;

        public pnl_ForgotPassword(layout_Login layout_Login)
        {
            InitializeComponent();
            userServices = new UserServices();
            layout = layout_Login;
        }

        private void goBack(object sender, EventArgs e)
        {
            layout.show_LoginForm();
        }

        private string getEmail()
        {
            string username = this.inpt_username.Text;
            if (username != "")
            {
                this.curent_usename = username;
                User user = userServices.GetByUsername(username);
                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy user");
                    return null;
                }
                return user.Email;
            }
            else
            {
                MessageBox.Show("Hãy nhập username");
                return null;
            }
        }

        private void loginError(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/duyn5822/");

            MessageBox.Show("Hãy liên hệ qua facebook của admin để được hỗ trợ trực tiếp!");
        }

        private void sendOtp(object sender, EventArgs e)
        {
            string email = getEmail();

            if (email != null)
            {
                string otp = Common.GenerateOTP();
                this.otpCode = otp;

                string html = "<h1>Chào bạn, có vẻ đã có ai đó gửi yêu cầu thay đổi mật khẩu</h1> <h2> Nếu là bạn, vui lòng nhập mã dưới đây để tiến hành thay đổi mật khẩu </h2> <br /> <h1 id='otp'>" + otp + "</h1> <br /> <h4> Nếu đây không phải bạn, vui lòng liên hệ admin theo link dưới đây để phàn nàn: https://www.facebook.com/duyn5822/ </h4> <br /> <p>Đây là email tự động, vui lòng không trả lời!</p>";
                string subject = "Yêu cầu thay đổi mật khẩu";
                Common.MailTo(subject, html, email);
                MessageBox.Show("Đã gửi mã tới email đăng ký của user, nếu không tìm thấy, hãy kiểm tra hộp thư spam hoặc kiểm tra lại username");
            }
        }

        private void changePass(object sender, EventArgs e)
        {
            string otp = this.inpt_otp.Text;
            string username = this.inpt_username.Text
                ;
            string newPassword = this.inpt_newPassword.Text;

            User user = userServices.GetByUsername(username);
            if (username != "" && newPassword != "" && otp != "")
            {
                if (otp.Equals(this.otpCode))
                {
                    if (username.Equals(this.curent_usename))
                    {
                        user.Password = newPassword;
                        userServices.Update(user);
                        MessageBox.Show("Mật khẩu của " + username + " đã được thay đổi, vui lòng đăng nhập!");
                        goBack(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Mã OTP này là của một username khác, vui lòng không tọc mạch!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã OTP sai, vui lòng nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }

        private void showPassword(object sender, EventArgs e)
        {
            if (this.cbx_showPass.Checked)
            {
                this.inpt_newPassword.PasswordChar = '\0';
            }
            else
            {
                this.inpt_newPassword.PasswordChar = '*';
            }
        }
    }
}