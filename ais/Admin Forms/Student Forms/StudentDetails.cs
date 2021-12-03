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

namespace ais
{
    public partial class StudentDetails : Form
    {
        // student from previous win
        private User _student;

        // group list in combo box
        private List<Group> groupListCB;
        
        // update ref
        public bool IsUpdated { get; set; }

        public StudentDetails(User student)
        {
            InitializeComponent();
            _student = student;
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            IsUpdated = false;

            subjectGrid.AutoGenerateColumns = false;
            subjectGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<GroupSubject> groupSubjectList = new();
            Group group;

            // main heading
            using (MyDbContext db = new())
            {
                group = db.Groups.FirstOrDefault(g => g.Id == _student.GroupId);
                headingLabel.Text = _student.Name + " " + _student.Surname + " " + group.GroupName + " Details";

                groupSubjectList = db.GroupSubjects.Where(gs => gs.GroupId == group.Id).ToList();
            }

            // student info
            nameInput.Text = _student.Name;
            surnameInput.Text = _student.Surname;
            usernameInput.Text = _student.Username;
            passwordInput.Text = _student.Password;

            // fill dgv with group subjects and their teachers
            using (MyDbContext db = new())
            { 
                foreach(var gs in groupSubjectList)
                {
                    var teacherSubject = db.TeacherSubjects.FirstOrDefault(ts => ts.Id == gs.TeacherSubjectId);

                    var teacher = db.Users.FirstOrDefault(t => t.Id == teacherSubject.UserId);
                    var subject = db.Subjects.FirstOrDefault(s => s.Id == teacherSubject.SubjectId);

                    DataGridViewRow row = new();
                    row.CreateCells(subjectGrid);

                    row.Cells[0].Value = gs.Id;
                    row.Cells[1].Value = subject.SubjectName;
                    row.Cells[2].Value = teacher.Name + " " + teacher.Surname;

                    subjectGrid.Rows.Add(row);
                }
            }

            // fill list box with groups to chose from
            using (MyDbContext db = new())
            {
                var groupList = db.Groups.Where(g => g.Id != group.Id).ToList();

                groupListCB = new();
                foreach (var g in groupList)
                {
                    groupListCB.Add(g);
                    groupComboBox.Items.Add(g.GroupName);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string surname = surnameInput.Text.Trim();
            string username = usernameInput.Text.Trim();
            string password = passwordInput.Text.Trim();
            
            if(name != "" && surname != "" && username != "" && password != "")
            {
                using (MyDbContext db = new())
                {
                    if(groupComboBox.SelectedIndex > -1)
                    {
                        _student.GroupId = groupListCB[groupComboBox.SelectedIndex].Id;
                    }
                    _student.Name = name;
                    _student.Surname = surname;
                    _student.Username = username;
                    _student.Password = password;

                    db.Users.Update(_student);
                    db.SaveChanges();
                }

                IsUpdated = true;
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Student info fields must be filled!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
