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
    public partial class TeacherDetails : Form
    {
        // passed teacher
        private User _teacher;

        // lists
        private List<Subject> teacherSubjectList;
        private List<Subject> subjectList;

        // update ref
        public bool IsUpdated { get; set; }

        public TeacherDetails(User teacher)
        {
            InitializeComponent();
            _teacher = teacher;
        }

        private void TeacherDetails_Load(object sender, EventArgs e)
        {
            IsUpdated = false;

            headingLabel.Text = _teacher.Name + " " + _teacher.Surname + " Teacher Details";
            nameInput.Text = _teacher.Name;
            surnameInput.Text = _teacher.Surname;
            usernameInput.Text = _teacher.Username;
            passwordInput.Text = _teacher.Password;

            removeBtn1.Enabled = false;
            addBtn1.Enabled = false;

            // initialize values with teacher subject data
            using MyDbContext db = new();
            var ids = db.TeacherSubjects.Where(s => s.UserId == _teacher.Id);
            teacherSubjectList = new();
            foreach(var i in ids)
            {
                using MyDbContext context = new();
                var subject = context.Subjects.FirstOrDefault(s => s.Id == i.SubjectId);
                if(subject != null)
                {
                    teacherSubjectList.Add(subject);

                    tSubjectListBox.Items.Add(subject.SubjectName);
                }
            }

            // initialize values with subject data
            subjectList = db.Subjects.ToList();
            if(subjectList != null)
            {
                foreach(var s in subjectList)
                {
                    subjectsListBox.Items.Add(s.SubjectName);
                }
            }
        }

        private void subjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = subjectList.FirstOrDefault(
                s => s.SubjectName == subjectsListBox.SelectedItem.ToString());

            if (!teacherSubjectList.Any() ||
                teacherSubjectList.FirstOrDefault(s => s.Id == selectedItem.Id) == null)
            {
                addBtn1.Enabled = true;
            }
            else
            {
                addBtn1.Enabled = false;
            }
        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            tSubjectListBox.Items.Add(subjectsListBox.SelectedItem);

            teacherSubjectList.Add(subjectList[subjectsListBox.SelectedIndex]);

            addBtn1.Enabled = false;
        }

        private void tSubjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeBtn1.Enabled = true;
        }

        private void removeBtn1_Click(object sender, EventArgs e)
        {
            teacherSubjectList.RemoveAt(tSubjectListBox.SelectedIndex);

            tSubjectListBox.Items.Remove(tSubjectListBox.SelectedItem);

            removeBtn1.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // update teachers subjects
            using MyDbContext db = new();
            TeacherSubject del;
            do
            {
                del = db.TeacherSubjects.FirstOrDefault(s => s.UserId == _teacher.Id);
                if(del != null)
                {
                    db.TeacherSubjects.Remove(del);
                    db.SaveChanges();
                }

            } while (del != null);

            foreach(var ts in teacherSubjectList)
            {
                TeacherSubject tmp = new()
                {
                    UserId = _teacher.Id,
                    SubjectId = ts.Id
                };
                db.TeacherSubjects.Add(tmp);
                db.SaveChanges();
            }

            // update teacher
            _teacher.Username = usernameInput.Text;
            _teacher.Password = passwordInput.Text;
            _teacher.Name = nameInput.Text;
            _teacher.Surname = surnameInput.Text;


            db.Users.Update(_teacher);
            db.SaveChanges();

            IsUpdated = true;

            Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
