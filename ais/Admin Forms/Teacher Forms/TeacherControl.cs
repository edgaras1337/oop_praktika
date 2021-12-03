using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ais.Models;
using Microsoft.EntityFrameworkCore;

namespace ais
{
    public partial class TeacherControl : Form
    {
        // teacher role id
        private int roleId;

        // windows
        private TeacherDetails detailsWin;
        private AddTeacher addTeacherWin;

        // lists
        private List<User> teacherList;

        public TeacherControl()
        {
            InitializeComponent();
        }

        private void TeacherControl_Load(object sender, EventArgs e)
        {
            // load grid
            teacherGrid.AutoGenerateColumns = false;
            teacherGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            id.Width = 100;
            edit.Width = 150;
            delete.Width = 150;

            loadTeacherGrid();
        }

        private void loadTeacherGrid()
        {
            using(MyDbContext db = new())
            {
                roleId = (db.Roles.FirstOrDefault(r => r.RoleName == "teacher")).Id;
                var userRoles = (db.UserRoles.Where(r => r.RoleId == roleId)).ToList();

                teacherList = new();
                foreach (var ur in userRoles)
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == ur.UserId);
                    if (user != null)
                    {
                        teacherList.Add(user);
                    }
                }
            }
            teacherGrid.DataSource = teacherList;
        }

        private void newRecordBtn_Click(object sender, EventArgs e)
        {
            addTeacherWin = new(roleId);
            addTeacherWin.Show();
            addTeacherWin.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
        }

        void updateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(addTeacherWin != null && addTeacherWin.IsUpdated)
            {
                loadTeacherGrid();
            }
            if (detailsWin != null && detailsWin.IsUpdated)
            {
                loadTeacherGrid();
            }
        }

        private void teacherGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                // open details window
                detailsWin = new( teacherList[e.RowIndex]);
                detailsWin.Show();
                detailsWin.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
            } 
            else if(e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show
                (
                    "Are you sure you want to delete this account?", 
                    "Information", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if(dr == DialogResult.Yes)
                {
                    var user = teacherList[e.RowIndex];

                    using(MyDbContext db = new())
                    {
                        var teacherSubject = db.TeacherSubjects.Where(t => t.UserId == user.Id);
                        foreach (var ts in teacherSubject)
                        {
                            // remove row from group subject as it contains id of teacher subject
                            using (MyDbContext db2 = new())
                            {
                                var gss = db2.GroupSubjects.Where(g => g.TeacherSubjectId == ts.Id);
                                foreach (var gs in gss)
                                {
                                    db.GroupSubjects.Remove(gs);
                                }
                            }
                            // remove subject grade tbl rows
                            using (MyDbContext db3 = new())
                            {
                                var sgs = db3.SubjectGrades.Where(s => s.TeacherSubjectId == ts.Id);
                                foreach (var sg in sgs)
                                {
                                    db.SubjectGrades.Remove(sg);
                                }
                            }
                            // remove teacher subject row
                            db.TeacherSubjects.Remove(ts);
                        }
                        db.SaveChanges();

                        // remove user role tbl row
                        db.UserRoles.RemoveRange(user.UserRoles);
                        db.SaveChanges();

                        // remove the teacher
                        db.Users.Remove(user);
                        db.SaveChanges();
                    }

                    MessageBox.Show
                    (
                        "Account removed succesfully!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    loadTeacherGrid();
                }

            }
        }
    }
}
