﻿using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.ClassViews
{
    partial class ClassListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.classTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.type_search = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.inpt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.paginationBar = new System.Windows.Forms.Panel();
            this.nav_toLast = new System.Windows.Forms.Button();
            this.nav_toNext = new System.Windows.Forms.Button();
            this.nav_display = new System.Windows.Forms.Button();
            this.nav_toPre = new System.Windows.Forms.Button();
            this.nav_toFirst = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.panel6.SuspendLayout();
            this.paginationBar.SuspendLayout();
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
            this.panel8.Controls.Add(this.classTable);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(916, 461);
            this.panel8.TabIndex = 5;
            // 
            // classTable
            // 
            this.classTable.AllowUserToAddRows = false;
            this.classTable.AllowUserToDeleteRows = false;
            this.classTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.classTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.classTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.classTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.classTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.classTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classTable.ColumnHeadersHeight = 50;
            this.classTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.classTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fa,
            this.leader,
            this.mo});
            this.classTable.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.classTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classTable.EnableHeadersVisualStyles = false;
            this.classTable.GridColor = System.Drawing.Color.White;
            this.classTable.Location = new System.Drawing.Point(0, 0);
            this.classTable.Margin = new System.Windows.Forms.Padding(0);
            this.classTable.Name = "classTable";
            this.classTable.ReadOnly = true;
            this.classTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.classTable.RowHeadersWidth = 15;
            this.classTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.classTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.classTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classTable.RowTemplate.Height = 35;
            this.classTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.classTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.classTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classTable.ShowCellErrors = false;
            this.classTable.ShowCellToolTips = false;
            this.classTable.ShowEditingIcon = false;
            this.classTable.ShowRowErrors = false;
            this.classTable.Size = new System.Drawing.Size(916, 461);
            this.classTable.TabIndex = 0;
            this.classTable.DoubleClick += new System.EventHandler(this.updateUser);
            // 
            // id
            // 
            this.id.HeaderText = "Mã lớp";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fa
            // 
            this.fa.HeaderText = "Khoa";
            this.fa.Name = "fa";
            this.fa.ReadOnly = true;
            // 
            // leader
            // 
            this.leader.HeaderText = "Chủ nhiệm";
            this.leader.Name = "leader";
            this.leader.ReadOnly = true;
            // 
            // mo
            // 
            this.mo.HeaderText = "Lớp trưởng";
            this.mo.Name = "mo";
            this.mo.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 53);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.Controls.Add(this.btn_delete);
            this.panel5.Controls.Add(this.btn_update);
            this.panel5.Controls.Add(this.btn_add);
            this.panel5.Location = new System.Drawing.Point(12, 10);
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
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.type_search);
            this.panel3.Controls.Add(this.inpt_search);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Location = new System.Drawing.Point(373, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 42);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm theo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_search
            // 
            this.type_search.BackColor = System.Drawing.Color.Transparent;
            this.type_search.BorderColor = System.Drawing.Color.Transparent;
            this.type_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.type_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.type_search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type_search.FocusedState.Parent = this.type_search;
            this.type_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.type_search.ForeColor = System.Drawing.Color.White;
            this.type_search.HoverState.Parent = this.type_search;
            this.type_search.ItemHeight = 30;
            this.type_search.Items.AddRange(new object[] {
            "Mã khoa",
            "Tên khoa",
            "Trưởng khoa"});
            this.type_search.ItemsAppearance.Parent = this.type_search;
            this.type_search.Location = new System.Drawing.Point(84, 0);
            this.type_search.Name = "type_search";
            this.type_search.ShadowDecoration.Parent = this.type_search;
            this.type_search.Size = new System.Drawing.Size(135, 36);
            this.type_search.TabIndex = 5;
            this.type_search.SelectedIndexChanged += new System.EventHandler(this.type_search_SelectedIndexChanged);
            // 
            // inpt_search
            // 
            this.inpt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.inpt_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.inpt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_search.ForeColor = System.Drawing.Color.White;
            this.inpt_search.Location = new System.Drawing.Point(219, 0);
            this.inpt_search.Name = "inpt_search";
            this.inpt_search.Size = new System.Drawing.Size(287, 31);
            this.inpt_search.TabIndex = 4;
            this.inpt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inpt_search_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_search.IconColor = System.Drawing.Color.White;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 37;
            this.btn_search.Location = new System.Drawing.Point(506, 0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 42);
            this.btn_search.TabIndex = 3;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.findAndDisplay);
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
            // ClassListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 561);
            this.Controls.Add(this.panel1);
            this.Name = "ClassListView";
            this.ClientSizeChanged += new System.EventHandler(this.onChangeSize);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.paginationBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView classTable;
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
        private FontAwesome.Sharp.IconPictureBox btn_search;
        private System.Windows.Forms.TextBox inpt_search;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox type_search;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fa;
        private DataGridViewTextBoxColumn leader;
        private DataGridViewTextBoxColumn mo;
    }
}