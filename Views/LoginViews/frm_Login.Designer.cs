namespace QuanLySinhVien.Views
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpt_password = new System.Windows.Forms.TextBox();
            this.inpt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.err_loginErr = new System.Windows.Forms.LinkLabel();
            this.err_forgot = new System.Windows.Forms.LinkLabel();
            this.cbx_showPass = new System.Windows.Forms.CheckBox();
            this.cbx_autoLogin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-138, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(83, 80);
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
            this.label3.Location = new System.Drawing.Point(79, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // inpt_password
            // 
            this.inpt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_password.Location = new System.Drawing.Point(83, 190);
            this.inpt_password.Name = "inpt_password";
            this.inpt_password.PasswordChar = '*';
            this.inpt_password.Size = new System.Drawing.Size(260, 29);
            this.inpt_password.TabIndex = 2;
            // 
            // inpt_username
            // 
            this.inpt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_username.Location = new System.Drawing.Point(83, 107);
            this.inpt_username.Name = "inpt_username";
            this.inpt_username.Size = new System.Drawing.Size(260, 29);
            this.inpt_username.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_login.Location = new System.Drawing.Point(83, 269);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(260, 35);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.login);
            // 
            // err_loginErr
            // 
            this.err_loginErr.AutoSize = true;
            this.err_loginErr.BackColor = System.Drawing.Color.Transparent;
            this.err_loginErr.LinkColor = System.Drawing.Color.White;
            this.err_loginErr.Location = new System.Drawing.Point(83, 331);
            this.err_loginErr.Name = "err_loginErr";
            this.err_loginErr.Size = new System.Drawing.Size(128, 13);
            this.err_loginErr.TabIndex = 6;
            this.err_loginErr.TabStop = true;
            this.err_loginErr.Text = "Gặp sự cố khi đăng nhập";
            this.err_loginErr.Click += new System.EventHandler(this.loginError);
            // 
            // err_forgot
            // 
            this.err_forgot.AutoSize = true;
            this.err_forgot.BackColor = System.Drawing.Color.Transparent;
            this.err_forgot.LinkColor = System.Drawing.Color.White;
            this.err_forgot.Location = new System.Drawing.Point(83, 365);
            this.err_forgot.Name = "err_forgot";
            this.err_forgot.Size = new System.Drawing.Size(154, 13);
            this.err_forgot.TabIndex = 7;
            this.err_forgot.TabStop = true;
            this.err_forgot.Text = "Quên tài khoản hoặc mật khẩu";
            this.err_forgot.Click += new System.EventHandler(this.forgotPass);
            // 
            // cbx_showPass
            // 
            this.cbx_showPass.AutoSize = true;
            this.cbx_showPass.BackColor = System.Drawing.Color.Transparent;
            this.cbx_showPass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbx_showPass.Location = new System.Drawing.Point(248, 170);
            this.cbx_showPass.Name = "cbx_showPass";
            this.cbx_showPass.Size = new System.Drawing.Size(95, 17);
            this.cbx_showPass.TabIndex = 4;
            this.cbx_showPass.Text = "Hiện mật khẩu";
            this.cbx_showPass.UseVisualStyleBackColor = false;
            this.cbx_showPass.CheckedChanged += new System.EventHandler(this.showPassword);
            // 
            // cbx_autoLogin
            // 
            this.cbx_autoLogin.AutoSize = true;
            this.cbx_autoLogin.BackColor = System.Drawing.Color.Transparent;
            this.cbx_autoLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbx_autoLogin.Location = new System.Drawing.Point(83, 237);
            this.cbx_autoLogin.Name = "cbx_autoLogin";
            this.cbx_autoLogin.Size = new System.Drawing.Size(91, 17);
            this.cbx_autoLogin.TabIndex = 5;
            this.cbx_autoLogin.Text = "Lưu mật khẩu";
            this.cbx_autoLogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbx_autoLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_showPass);
            this.panel1.Controls.Add(this.err_forgot);
            this.panel1.Controls.Add(this.err_loginErr);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.inpt_username);
            this.panel1.Controls.Add(this.inpt_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(147, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 408);
            this.panel1.TabIndex = 8;
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập vào hệ thống";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.onFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpt_password;
        private System.Windows.Forms.TextBox inpt_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel err_loginErr;
        private System.Windows.Forms.LinkLabel err_forgot;
        private System.Windows.Forms.CheckBox cbx_showPass;
        private System.Windows.Forms.CheckBox cbx_autoLogin;
        private System.Windows.Forms.Panel panel1;
    }
}