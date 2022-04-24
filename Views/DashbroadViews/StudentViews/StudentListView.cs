using QuanLySinhVien.Models.Model;
using QuanLySinhVien.Models.ModelServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.Views.DashbroadViews.StudentViews
{
    public partial class StudentListView : Form
    {
        private UserServices userServices = null;
        private ClassServices classServices = null;
        private StudentServices studentServices = null;

        private List<Student> students = null;
        private List<User> users = null;
        private List<Class> classes = null;

        private int pageSize = 11;
        private int curPage = 1;
        private int totalPage = 1;
        private string searchType = null;
        private string[] searchOption = { "id", "name", "class", "status" };

        public StudentListView()
        {
            InitializeComponent();
            this.userServices = new UserServices();
            this.classServices = new ClassServices();
            this.studentServices = new StudentServices();

            this.students = studentServices.GetAll();
            this.classes = classServices.GetAll();
            this.users = userServices.GetAllUsers();

            this.searchType = "id";
            this.type_search.SelectedIndex = 0;

            permissionCheck();
        }
        private void permissionCheck()
        {
            string[] permis = Properties.Settings.Default.Permission.Split('-');
            foreach (var per in permis)
            {
                char[] p = per.ToCharArray();
                if (p[0].Equals('S'))
                {
                    if (p[2].Equals('0'))
                    {
                        this.btn_add.Enabled = false;
                    }
                    if (p[3].Equals('0'))
                    {
                        this.btn_update.Enabled = false;
                    }
                    if (p[4].Equals('0'))
                    {
                        this.btn_delete.Enabled = false;
                    }
                }
            }
        }
        private void fillToTable(int page, int size, List<Student> listStudent)
        {
            this.studentTable.Rows.Clear();

            // đoạn này cần chuyển sang double để không bị tự làm tròn xuống
            double userCount = students.Count;
            double pagSz = pageSize;
            double total = userCount / pagSz;
            int totalpage = (int)Math.Ceiling(total);

            if (this.curPage > totalpage)
            {
                this.curPage = totalpage;
            }

            this.nav_display.Text = curPage + "/" + totalpage;
            this.totalPage = totalpage;

            if (this.curPage == 1)
            {
                this.nav_toFirst.Enabled = false;
                this.nav_toPre.Enabled = false;
            }
            else
            {
                this.nav_toFirst.Enabled = true;
                this.nav_toPre.Enabled = true;
            }
            if (this.curPage == totalPage)
            {
                this.nav_toLast.Enabled = false;
                this.nav_toNext.Enabled = false;
            }
            else
            {
                this.nav_toLast.Enabled = true;
                this.nav_toNext.Enabled = true;
            }

            List<Student> newListStudent = new List<Student>();
            if (listStudent.Count > size)
            {
                int skipCount = (page - 1) * size;
                if ((skipCount + size) > listStudent.Count)
                {
                    for (int i = skipCount; i < listStudent.Count; i++)
                    {
                        newListStudent.Add(listStudent[i]);
                    }
                }
                else
                    newListStudent = listStudent.GetRange(skipCount, size);
            }
            else
            {
                newListStudent = listStudent;
            }

            string className = "";

            foreach (var student in newListStudent)
            {
                foreach (var @class in classes)
                {
                    if (@class.ID == student.ClassID)
                    {
                        className = @class.Name;
                    }
                }

                this.studentTable.Rows.Add(student.StudentID, student.Name, className, student.ClassRole, student.Address, student.DateOfBirth, student.Religion, student.Phone, student.SchoolProfile, student.Status);
            }
        }

        #region NavControl

        private void nextPage(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage++;
                fillToTable(this.curPage, this.pageSize, this.students);
            }
        }

        private void prevPage(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage--;
                fillToTable(this.curPage, this.pageSize, this.students);
            }
        }

        private void toFirst(object sender, EventArgs e)
        {
            if (this.curPage > 1)
            {
                this.curPage = 1;
                fillToTable(this.curPage, this.pageSize, this.students);
            }
        }

        private void toLast(object sender, EventArgs e)
        {
            if (this.curPage < this.totalPage)
            {
                this.curPage = this.totalPage;
                fillToTable(this.curPage, this.pageSize, this.students);
            }
        }

        private void onChangeSize(object sender, EventArgs e)
        {
            double currSize = this.studentTable.Height - this.studentTable.ColumnHeadersHeight;
            double size = currSize / this.studentTable.RowTemplate.Height;
            int oldSize = this.pageSize;
            this.pageSize = (int)Math.Floor(size);
            if (oldSize != this.pageSize)
            {
                fillToTable(this.curPage, this.pageSize, this.students);
            }
        }

        #endregion NavControl

        #region StudentControl

        private int[] getCurrentStudentID()
        {
            int total = this.studentTable.SelectedRows.Count;
            int[] res = new int[total];
            for (int i = 0; i < total; i++)
            {
                int index = this.studentTable.SelectedRows[i].Index;
                index += (curPage - 1) * pageSize;
                res[i] = this.students[index].ID;
            }
            return res;
        }

        private void addStudent(object sender, EventArgs e)
        {
            this.Tag = "add-student";
            this.Close();
        }

        private void removeStudent(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa các mục đã chọn?";
            string title = "Xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                foreach (var id in getCurrentStudentID())
                {
                    studentServices.DeleteByID(id);
                }

                this.students = studentServices.GetAll();
                fillToTable(curPage, this.pageSize, this.students);
            }
        }

        private void updateStudent(object sender, EventArgs e)
        {
            if (this.btn_update.Enabled && this.students.Count > 0)
                if (getCurrentStudentID().Length < 2)
                {
                    this.Tag = "update-student/" + getCurrentStudentID()[0];
                    this.Close();
                }
        }

        #endregion StudentControl

        private void findAndDisplay(object sender, EventArgs e)
        {
            this.students = studentServices.GetAll();
            List<Student> res = new List<Student>();
            var searchValue = this.inpt_search.Text;

            if (this.searchType.Equals("id"))
            {
                foreach (var student in students)
                {
                    if (student.StudentID.Contains(searchValue))
                    {
                        res.Add(student);
                    }
                }
            }
            else if (this.searchType.Equals("class"))
            {
                foreach (var student in students)
                {
                    foreach (var @class in classes)
                    {
                        if (@class.ID.Equals(student.ClassID) && @class.Name.Contains(searchValue))
                        {
                            res.Add(student);
                        }
                    }
                }
            }
            else if (this.searchType.Equals("name"))
            {
                foreach (var student in students)
                {
                    if (student.Name.Contains(searchValue))
                    {
                        res.Add(student);
                    }
                }
            }
            else if (this.searchType.Equals("status"))
            {
                foreach (var student in students)
                {
                    if (student.Status.Contains(searchValue))
                    {
                        res.Add(student);
                    }
                }
            }

            this.students.Clear();
            this.students = res;
            this.curPage = 1;
            fillToTable(this.curPage, this.pageSize, res);
        }

        private void type_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.type_search.SelectedIndex;
            searchType = searchOption[index];
        }

        private void inpt_search_KeyDown(object sender, KeyEventArgs e)
        {
            findAndDisplay(null, null);
        }

        private void StudentListView_Load(object sender, EventArgs e)
        {
            fillToTable(this.curPage, this.pageSize, this.students);
        }
    }
}