namespace QuanLySinhVien.Views.LoginViews
{
    partial class pnl_ForgotPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnl_ForgotPassword));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpt_newPassword = new System.Windows.Forms.TextBox();
            this.inpt_username = new System.Windows.Forms.TextBox();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.link_sendOtp = new System.Windows.Forms.LinkLabel();
            this.err_mail = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inpt_otp = new System.Windows.Forms.TextBox();
            this.pnl_forgotPass = new System.Windows.Forms.Panel();
            this.cbx_showPass = new System.Windows.Forms.CheckBox();
            this.link_returnLogin = new System.Windows.Forms.LinkLabel();
            this.pnl_forgotPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(215, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(211, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "New password";
            // 
            // inpt_newPassword
            // 
            this.inpt_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_newPassword.Location = new System.Drawing.Point(215, 188);
            this.inpt_newPassword.Name = "inpt_newPassword";
            this.inpt_newPassword.PasswordChar = '*';
            this.inpt_newPassword.Size = new System.Drawing.Size(260, 29);
            this.inpt_newPassword.TabIndex = 2;
            // 
            // inpt_username
            // 
            this.inpt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_username.Location = new System.Drawing.Point(215, 105);
            this.inpt_username.Name = "inpt_username";
            this.inpt_username.Size = new System.Drawing.Size(260, 29);
            this.inpt_username.TabIndex = 1;
            // 
            // btn_changePass
            // 
            this.btn_changePass.BackColor = System.Drawing.Color.Transparent;
            this.btn_changePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_changePass.Location = new System.Drawing.Point(215, 321);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(260, 35);
            this.btn_changePass.TabIndex = 3;
            this.btn_changePass.Text = "Đổi mật khẩu";
            this.btn_changePass.UseVisualStyleBackColor = false;
            this.btn_changePass.Click += new System.EventHandler(this.changePass);
            // 
            // link_sendOtp
            // 
            this.link_sendOtp.AutoSize = true;
            this.link_sendOtp.BackColor = System.Drawing.Color.Transparent;
            this.link_sendOtp.LinkColor = System.Drawing.Color.White;
            this.link_sendOtp.Location = new System.Drawing.Point(212, 232);
            this.link_sendOtp.Name = "link_sendOtp";
            this.link_sendOtp.Size = new System.Drawing.Size(191, 13);
            this.link_sendOtp.TabIndex = 6;
            this.link_sendOtp.TabStop = true;
            this.link_sendOtp.Text = "Gửi mã xác nhận otp  tới email đăng ký";
            this.link_sendOtp.Click += new System.EventHandler(this.sendOtp);
            // 
            // err_mail
            // 
            this.err_mail.AutoSize = true;
            this.err_mail.BackColor = System.Drawing.Color.Transparent;
            this.err_mail.LinkColor = System.Drawing.Color.White;
            this.err_mail.Location = new System.Drawing.Point(212, 374);
            this.err_mail.Name = "err_mail";
            this.err_mail.Size = new System.Drawing.Size(172, 13);
            this.err_mail.TabIndex = 7;
            this.err_mail.TabStop = true;
            this.err_mail.Text = "Không thể truy cập email đăng ký?";
            this.err_mail.Click += new System.EventHandler(this.loginError);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(219, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "OTP";
            // 
            // inpt_otp
            // 
            this.inpt_otp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_otp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_otp.Location = new System.Drawing.Point(295, 269);
            this.inpt_otp.Name = "inpt_otp";
            this.inpt_otp.Size = new System.Drawing.Size(180, 29);
            this.inpt_otp.TabIndex = 8;
            // 
            // pnl_forgotPass
            // 
            this.pnl_forgotPass.BackColor = System.Drawing.Color.Transparent;
            this.pnl_forgotPass.Controls.Add(this.link_returnLogin);
            this.pnl_forgotPass.Controls.Add(this.cbx_showPass);
            this.pnl_forgotPass.Controls.Add(this.inpt_otp);
            this.pnl_forgotPass.Controls.Add(this.label4);
            this.pnl_forgotPass.Controls.Add(this.label1);
            this.pnl_forgotPass.Controls.Add(this.err_mail);
            this.pnl_forgotPass.Controls.Add(this.link_sendOtp);
            this.pnl_forgotPass.Controls.Add(this.btn_changePass);
            this.pnl_forgotPass.Controls.Add(this.inpt_username);
            this.pnl_forgotPass.Controls.Add(this.inpt_newPassword);
            this.pnl_forgotPass.Controls.Add(this.label3);
            this.pnl_forgotPass.Controls.Add(this.label2);
            this.pnl_forgotPass.Location = new System.Drawing.Point(0, 0);
            this.pnl_forgotPass.Name = "pnl_forgotPass";
            this.pnl_forgotPass.Size = new System.Drawing.Size(703, 438);
            this.pnl_forgotPass.TabIndex = 8;
            // 
            // cbx_showPass
            // 
            this.cbx_showPass.AutoSize = true;
            this.cbx_showPass.BackColor = System.Drawing.Color.Transparent;
            this.cbx_showPass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbx_showPass.Location = new System.Drawing.Point(380, 168);
            this.cbx_showPass.Name = "cbx_showPass";
            this.cbx_showPass.Size = new System.Drawing.Size(95, 17);
            this.cbx_showPass.TabIndex = 9;
            this.cbx_showPass.Text = "Hiện mật khẩu";
            this.cbx_showPass.UseVisualStyleBackColor = false;
            this.cbx_showPass.Click += new System.EventHandler(this.showPassword);
            // 
            // link_returnLogin
            // 
            this.link_returnLogin.AutoSize = true;
            this.link_returnLogin.BackColor = System.Drawing.Color.Transparent;
            this.link_returnLogin.LinkColor = System.Drawing.Color.White;
            this.link_returnLogin.Location = new System.Drawing.Point(212, 404);
            this.link_returnLogin.Name = "link_returnLogin";
            this.link_returnLogin.Size = new System.Drawing.Size(100, 13);
            this.link_returnLogin.TabIndex = 10;
            this.link_returnLogin.TabStop = true;
            this.link_returnLogin.Text = "Quay lại đăng nhập";
            this.link_returnLogin.Click += new System.EventHandler(this.goBack);
            // 
            // pnl_ForgotPassword
            // 
            this.AcceptButton = this.btn_changePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.pnl_forgotPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pnl_ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu mới";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.goBack);
            this.pnl_forgotPass.ResumeLayout(false);
            this.pnl_forgotPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpt_newPassword;
        private System.Windows.Forms.TextBox inpt_username;
        private System.Windows.Forms.Button btn_changePass;
        private System.Windows.Forms.LinkLabel link_sendOtp;
        private System.Windows.Forms.LinkLabel err_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpt_otp;
        private System.Windows.Forms.Panel pnl_forgotPass;
        private System.Windows.Forms.CheckBox cbx_showPass;
        private System.Windows.Forms.LinkLabel link_returnLogin;
    }
}