using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.UserViews
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_ClientSizeChanged(object sender, EventArgs e)
        {
            this.log.Text = this.Width.ToString() + "x"+this.Height.ToString();
            int mid = (this.Width - this.panel4.Width) / 2;
            if (this.Height > 700)
            {
                this.panel4.Location = new System.Drawing.Point(mid, 35);
                this.panel5.Location = new System.Drawing.Point(mid, 135);
                this.panel6.Location = new System.Drawing.Point(mid, 235);
                this.panel7.Location = new System.Drawing.Point(mid, 335);
                this.panel8.Location = new System.Drawing.Point(mid, 435);
                this.panel9.Location = new System.Drawing.Point(mid, 535);
                this.panel10.Location = new System.Drawing.Point(mid, 635);
                this.panel11.Location = new System.Drawing.Point(mid, 735);
            }
            else
            {
                this.panel4.Location = new System.Drawing.Point(70, 30);
                this.panel5.Location = new System.Drawing.Point(70, 360);
                this.panel6.Location = new System.Drawing.Point(70, 250);
                this.panel7.Location = new System.Drawing.Point(70, 140);
                this.panel8.Location = new System.Drawing.Point(571, 30);
                this.panel9.Location = new System.Drawing.Point(571, 140);
                this.panel10.Location = new System.Drawing.Point(571, 250);
                this.panel11.Location = new System.Drawing.Point(571, 360);
            }
        }
    }
}
