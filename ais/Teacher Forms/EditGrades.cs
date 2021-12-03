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

namespace ais.Teacher_Forms
{
    public partial class EditGrades : Form
    {
        private readonly GroupSubject _groupSubject;
        private readonly TeacherSubject _teacherSubject;
        private readonly Subject _subject;

        private List<User> students;
        private List<SubjectGrade> subjectGradeList;
        public EditGrades(GroupSubject groupSubject, TeacherSubject teacherSubject, Subject subject)
        {
            InitializeComponent();
            _groupSubject = groupSubject;
            _teacherSubject = teacherSubject;
            _subject = subject;
        }

        private void EditGrades_Load(object sender, EventArgs e)
        {
            using(MyDbContext db = new())
            {
                var group = db.Groups.FirstOrDefault(g => g.Id == _groupSubject.GroupId);
                headingLabel.Text = group.GroupName + " " + _subject.SubjectName + " Grades";
            }
            students = new();
            subjectGradeList = new();

            gradeGrid.AutoGenerateColumns = false;
            gradeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            id.Width = 100;
            grade.Width = 100;

            using(MyDbContext db = new())
            {
                students = db.Users.Where(u => u.GroupId == _groupSubject.GroupId).ToList();
            }
            using(MyDbContext db = new())
            {
                foreach(var student in students)
                {
                    DataGridViewRow row = new();
                    row.CreateCells(gradeGrid);

                    row.Cells[0].Value = student.Id;
                    row.Cells[1].Value = student.Name + " " + student.Surname;

                    var subjectGrade = db.SubjectGrades
                        .FirstOrDefault(sg => sg.TeacherSubjectId == _teacherSubject.Id && sg.UserId == student.Id);

                    if(subjectGrade != null)
                    {
                        row.Cells[2].Value = subjectGrade.Grade;
                        subjectGradeList.Add(subjectGrade);
                    }
                    else
                    {
                        subjectGradeList.Add(null);
                    }

                    gradeGrid.Rows.Add(row);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(DataGridViewRow row in gradeGrid.Rows)
            {
                flag = false;
                using MyDbContext db = new();
                SubjectGrade grade = new()
                {
                    Grade = null,
                    UserId = students[row.Index].Id,
                    TeacherSubjectId = _teacherSubject.Id
                };

                if (row.Cells[2].Value != null)
                {
                    try
                    {
                        int tmp = int.Parse(row.Cells[2].Value.ToString());

                        if (tmp > -1 && tmp < 11)
                        {
                            grade.Grade = (int?)tmp;

                            var subjectGrade = subjectGradeList[row.Index];
                            if (subjectGrade != null)
                            {
                                subjectGrade.Grade = grade.Grade;
                                db.SubjectGrades.Update(subjectGrade);
                            }
                            else
                            {
                                db.SubjectGrades.Add(grade);
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid grade input!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            flag = true;
                            break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Invalid grade input!",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        flag = true;
                        break;
                    }
                }
            }
            if (!flag)
            {
                Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
