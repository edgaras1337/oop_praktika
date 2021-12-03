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
    public partial class TeacherWin : Form
    {
        // logged in user
        private readonly User _user;

        // lists
        private List<Subject> subjectList;
        private List<GroupSubject> groupSubjectList;
        private List<TeacherSubject> teacherSubjectList;

        // windows
        private EditGrades gradesWin;

        public TeacherWin(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void TeacherMainWin_Load(object sender, EventArgs e)
        {
            subjectGrid.AutoGenerateColumns = false;
            subjectGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            group.Width = 100;
            grades.Width = 150;

            // create lists
            subjectList = new();
            groupSubjectList = new();
            teacherSubjectList = new();

            List<TeacherSubject> teacherSubjects;
            using (MyDbContext db = new())
            {
                teacherSubjects = db.TeacherSubjects.Where(t => t.UserId == _user.Id).ToList();
            }

            // load subject dgv with data
            using (MyDbContext db = new())
            {
                foreach (var ts in teacherSubjects)
                {
                    // select subject
                    var subject = db.Subjects.FirstOrDefault(s => s.Id == ts.SubjectId);
                    
                    // get group subjects
                    var groupSubjects = db.GroupSubjects.Where(gs => gs.TeacherSubjectId == ts.Id);

                    // fill dgv with group subjects, which the teacher has
                    foreach (var gs in groupSubjects)
                    {
                        using MyDbContext db2 = new();
                        var group = db2.Groups.FirstOrDefault(g => g.Id == gs.GroupId);

                        // add data to dgv
                        DataGridViewRow row = new();
                        row.CreateCells(subjectGrid);

                        row.Cells[0].Value = subject.SubjectName;
                        row.Cells[1].Value = group.GroupName;

                        subjectGrid.Rows.Add(row);

                        // fill lists
                        subjectList.Add(subject);
                        groupSubjectList.Add(gs);
                        teacherSubjectList.Add(ts);
                    }

                }
            }
        }

        private void subjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                var subject = subjectList[e.RowIndex];
                var teacherSubject = teacherSubjectList[e.RowIndex];
                var groupSubject = groupSubjectList[e.RowIndex];

                gradesWin = new(groupSubject, teacherSubject, subject);
                gradesWin.Show();
            }
        }
    }
}
