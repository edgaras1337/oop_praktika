using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ais.Models;

namespace ais
{
    public partial class StudentControl : Form
    {
        // windows
        private AddStudent addStudentWin;
        private StudentDetails studentDetails;

        // student list from db
        private List<User> studentList;

        // variables
        private int roleId;

        public StudentControl(MyDbContext context)
        {
            InitializeComponent();
        }

        private void addRowToDgv(User student, Group group)
        {
            // adding a row to dgv
            if (student != null && group != null)
            {
                DataGridViewRow row = new();
                row.CreateCells(studentGrid);

                row.Cells[0].Value = student.Id;
                row.Cells[1].Value = student.Name;
                row.Cells[2].Value = student.Surname;
                row.Cells[3].Value = group.GroupName;

                studentGrid.Rows.Add(row);
            }
        }

        private void sortDgv()
        {
            // sorting dgv by group aswell as studentList
            studentGrid.Sort(studentGrid.Columns[3], ListSortDirection.Ascending);
            studentGrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            // fill student list with sorted values
            studentList = new();
            using MyDbContext db = new();
            foreach (DataGridViewRow row in studentGrid.Rows)
            {
                studentList.Add(db.Users.FirstOrDefault(u => u.Id ==
                Int32.Parse(row.Cells[0].Value.ToString())));
            }
        }

        void updateList()
        {
            // get the userRoles tbl data
            using MyDbContext db = new();
            roleId = db.Roles.FirstOrDefault(r => r.RoleName == "student").Id;
            var ids = db.UserRoles.Where(u => u.RoleId == roleId);

            // fill dgv
            studentGrid.DataSource = null;
            studentGrid.Rows.Clear();
            foreach (var i in ids)
            {
                using MyDbContext db2 = new();
                var student = db2.Users.FirstOrDefault(u => u.Id == i.UserId);
                var group = db2.Groups.FirstOrDefault(g => g.Id == student.GroupId);

                // add row to dgv
                addRowToDgv(student, group);
            }

            // sort dgv and fill studentList with sorted users
            sortDgv();
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            studentGrid.AutoGenerateColumns = false;
            studentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            id.Width = 100;
            edit.Width = 150;
            delete.Width = 150;

            updateList();
        }

        private void newRecordBtn_Click(object sender, EventArgs e)
        {
            // add student window
            addStudentWin = new(roleId);
            addStudentWin.Show();
            addStudentWin.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
        }

        private void updateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update dgv when form closed if student was added
            if(addStudentWin != null && addStudentWin.IsUpdated)
            {
                updateList();
            }
            // update dgv if changes were made
            if(studentDetails != null && studentDetails.IsUpdated)
            {
                updateList();
            }
        }

        private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check for clicked column index
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                // open student details window
                var student = studentList.FirstOrDefault(
                    u => u.Id == Int32.Parse(studentGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));

                studentDetails = new(student);
                studentDetails.Show();
                studentDetails.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
            }
            else if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                // delete row from dgv and db
                DialogResult dr = MessageBox.Show
                (
                    "Are you sure you want to delete this student?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    var user = studentList[e.RowIndex];
                    
                    using (MyDbContext db = new())
                    {
                        // remove user role
                        var userRole = db
                            .UserRoles
                            .AsNoTracking()
                            .FirstOrDefault(ur => ur.UserId == user.Id);

                        db.UserRoles.Remove(userRole);

                        // remove student grades
                        using (MyDbContext db2 = new())
                        {
                            var grades = db2.SubjectGrades.Where(sg => sg.UserId == user.Id);
                            foreach(var grade in grades)
                            {
                                db2.SubjectGrades.Remove(grade);
                            }
                            db2.SaveChanges();
                        }

                        // remove student
                        db.Users.Remove(user);
                        db.SaveChanges();
                    }

                    updateList();

                    MessageBox.Show
                    (
                        "Student removed succesfully!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
    }
}
