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

namespace ais.Student_Forms
{
    public partial class StudentWin : Form
    {
        private readonly User _user;
        public StudentWin(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void StudentWin_Load(object sender, EventArgs e)
        {
            headingLabel.Text = "Hello " + _user.Name + " " + _user.Surname;

            gradeGrid.AutoGenerateColumns = false;
            gradeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grade.Width = 100;

            List<SubjectGrade> subjectGrades;
            using(MyDbContext db = new())
            {
                subjectGrades = db.SubjectGrades.Where(sg => sg.UserId == _user.Id).ToList();
            }

            List<GroupSubject> groupSubjects;
            using(MyDbContext db = new())
            {
                var group = db.Groups.FirstOrDefault(g => g.Id == _user.GroupId);
                groupSubjects = db.GroupSubjects.Where(gs => gs.GroupId == group.Id).ToList();
            }

            using(MyDbContext db = new())
            {
                foreach(var gs in groupSubjects)
                {
                    DataGridViewRow row = new();
                    row.CreateCells(gradeGrid);

                    var teacherSubject = db
                        .TeacherSubjects
                        .FirstOrDefault(ts => ts.Id == gs.TeacherSubjectId);

                    var subject = db.Subjects.FirstOrDefault(s => s.Id == teacherSubject.SubjectId);
                    var teacher = db.Users.FirstOrDefault(u => u.Id == teacherSubject.UserId);
                    var grade = db
                        .SubjectGrades
                        .FirstOrDefault(g => g.TeacherSubjectId == teacherSubject.Id
                        && g.UserId == _user.Id);

                    row.Cells[0].Value = subject.SubjectName;
                    row.Cells[1].Value = teacher.Name + " " + teacher.Surname;
                    if(grade != null)
                    {
                        row.Cells[2].Value = grade.Grade;
                    }
                    else
                    {
                        row.Cells[2].Value = null;
                    }
                    
                    gradeGrid.Rows.Add(row);
                }
            }
        }
    }
}
