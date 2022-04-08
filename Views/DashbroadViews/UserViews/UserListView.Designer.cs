using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.UserViews
{
    partial class UserListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.paginationBar = new System.Windows.Forms.Panel();
            this.nav_toLast = new System.Windows.Forms.Button();
            this.nav_toNext = new System.Windows.Forms.Button();
            this.nav_display = new System.Windows.Forms.Button();
            this.nav_toPre = new System.Windows.Forms.Button();
            this.nav_toFirst = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.rjTextBox1 = new QuanLySinhVien.Views.CommonViews.RJTextBox();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.paginationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 561);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.userTable);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(916, 471);
            this.panel8.TabIndex = 5;
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.userTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.userTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.userTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.userTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.userTable.ColumnHeadersHeight = 50;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.name,
            this.role,
            this.age,
            this.email,
            this.address,
            this.phone});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.userTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTable.EnableHeadersVisualStyles = false;
            this.userTable.GridColor = System.Drawing.Color.White;
            this.userTable.Location = new System.Drawing.Point(0, 0);
            this.userTable.Margin = new System.Windows.Forms.Padding(0);
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.userTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTable.ShowCellErrors = false;
            this.userTable.ShowCellToolTips = false;
            this.userTable.ShowEditingIcon = false;
            this.userTable.ShowRowErrors = false;
            this.userTable.Size = new System.Drawing.Size(916, 471);
            this.userTable.TabIndex = 0;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // name
            // 
            this.name.FillWeight = 130F;
            this.name.HeaderText = "Tên người dùng";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // role
            // 
            this.role.HeaderText = "Vai trò";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // age
            // 
            this.age.FillWeight = 40F;
            this.age.HeaderText = "Tuổi";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // email
            // 
            this.email.FillWeight = 130F;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // address
            // 
            this.address.FillWeight = 130F;
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.FillWeight = 87F;
            this.phone.HeaderText = "Số điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 43);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.Controls.Add(this.btn_delete);
            this.panel5.Controls.Add(this.btn_update);
            this.panel5.Controls.Add(this.btn_add);
            this.panel5.Location = new System.Drawing.Point(12, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 35);
            this.panel5.TabIndex = 4;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_delete.Location = new System.Drawing.Point(185, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 35);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.removeUser);
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_update.Location = new System.Drawing.Point(93, 0);
            this.btn_update.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 35);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.updateUser);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 35);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.addUser);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.rjTextBox1);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Location = new System.Drawing.Point(592, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 32);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.paginationBar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 514);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(916, 47);
            this.panel6.TabIndex = 3;
            // 
            // paginationBar
            // 
            this.paginationBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paginationBar.AutoSize = true;
            this.paginationBar.Controls.Add(this.nav_toLast);
            this.paginationBar.Controls.Add(this.nav_toNext);
            this.paginationBar.Controls.Add(this.nav_display);
            this.paginationBar.Controls.Add(this.nav_toPre);
            this.paginationBar.Controls.Add(this.nav_toFirst);
            this.paginationBar.Location = new System.Drawing.Point(373, 9);
            this.paginationBar.Margin = new System.Windows.Forms.Padding(0);
            this.paginationBar.Name = "paginationBar";
            this.paginationBar.Size = new System.Drawing.Size(169, 28);
            this.paginationBar.TabIndex = 2;
            // 
            // nav_toLast
            // 
            this.nav_toLast.BackColor = System.Drawing.Color.Transparent;
            this.nav_toLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_toLast.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_toLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_toLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_toLast.ForeColor = System.Drawing.Color.White;
            this.nav_toLast.Location = new System.Drawing.Point(140, 0);
            this.nav_toLast.Margin = new System.Windows.Forms.Padding(0);
            this.nav_toLast.Name = "nav_toLast";
            this.nav_toLast.Size = new System.Drawing.Size(28, 28);
            this.nav_toLast.TabIndex = 8;
            this.nav_toLast.Text = ">>";
            this.nav_toLast.UseVisualStyleBackColor = false;
            this.nav_toLast.Click += new System.EventHandler(this.toLast);
            // 
            // nav_toNext
            // 
            this.nav_toNext.BackColor = System.Drawing.Color.Transparent;
            this.nav_toNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_toNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_toNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_toNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_toNext.ForeColor = System.Drawing.Color.White;
            this.nav_toNext.Location = new System.Drawing.Point(112, 0);
            this.nav_toNext.Margin = new System.Windows.Forms.Padding(0);
            this.nav_toNext.Name = "nav_toNext";
            this.nav_toNext.Size = new System.Drawing.Size(28, 28);
            this.nav_toNext.TabIndex = 7;
            this.nav_toNext.Text = ">";
            this.nav_toNext.UseVisualStyleBackColor = false;
            this.nav_toNext.Click += new System.EventHandler(this.nextPage);
            // 
            // nav_display
            // 
            this.nav_display.BackColor = System.Drawing.Color.Transparent;
            this.nav_display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_display.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_display.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_display.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_display.ForeColor = System.Drawing.Color.White;
            this.nav_display.Location = new System.Drawing.Point(56, 0);
            this.nav_display.Margin = new System.Windows.Forms.Padding(0);
            this.nav_display.Name = "nav_display";
            this.nav_display.Size = new System.Drawing.Size(56, 28);
            this.nav_display.TabIndex = 4;
            this.nav_display.Text = "5/10";
            this.nav_display.UseVisualStyleBackColor = false;
            // 
            // nav_toPre
            // 
            this.nav_toPre.BackColor = System.Drawing.Color.Transparent;
            this.nav_toPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_toPre.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_toPre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toPre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_toPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_toPre.ForeColor = System.Drawing.Color.White;
            this.nav_toPre.Location = new System.Drawing.Point(28, 0);
            this.nav_toPre.Margin = new System.Windows.Forms.Padding(0);
            this.nav_toPre.Name = "nav_toPre";
            this.nav_toPre.Size = new System.Drawing.Size(28, 28);
            this.nav_toPre.TabIndex = 1;
            this.nav_toPre.Text = "<";
            this.nav_toPre.UseVisualStyleBackColor = false;
            this.nav_toPre.Click += new System.EventHandler(this.prevPage);
            // 
            // nav_toFirst
            // 
            this.nav_toFirst.BackColor = System.Drawing.Color.Transparent;
            this.nav_toFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_toFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_toFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.nav_toFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_toFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_toFirst.ForeColor = System.Drawing.Color.White;
            this.nav_toFirst.Location = new System.Drawing.Point(0, 0);
            this.nav_toFirst.Margin = new System.Windows.Forms.Padding(0);
            this.nav_toFirst.Name = "nav_toFirst";
            this.nav_toFirst.Size = new System.Drawing.Size(28, 28);
            this.nav_toFirst.TabIndex = 0;
            this.nav_toFirst.Text = "<<";
            this.nav_toFirst.UseVisualStyleBackColor = false;
            this.nav_toFirst.Click += new System.EventHandler(this.toFirst);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(287, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 32);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(0, 0);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.White;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(287, 31);
            this.rjTextBox1.TabIndex = 4;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // UserListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 561);
            this.Controls.Add(this.panel1);
            this.Name = "UserListView";
            this.Text = "UserListView";
            this.ClientSizeChanged += new System.EventHandler(this.onChangeSize);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.paginationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel paginationBar;
        private System.Windows.Forms.Button nav_toNext;
        private System.Windows.Forms.Button nav_display;
        private System.Windows.Forms.Button nav_toPre;
        private System.Windows.Forms.Button nav_toFirst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button nav_toLast;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CommonViews.RJTextBox rjTextBox1;
    }
}