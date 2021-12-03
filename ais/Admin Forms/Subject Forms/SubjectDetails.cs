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
    public partial class SubjectDetails : Form
    {
        // passed subject
        private readonly Subject _subject;

        // lists
        private List<User> teacherList;
        private List<User> subjectTeacherList;

        // update ref
        public bool IsUpdated { get; set; }

        public SubjectDetails(Subject subject)
        {
            InitializeComponent();
            _subject = subject;
        }

        private void SubjectDetails_Load(object sender, EventArgs e)
        {
            IsUpdated = false;
            headingLabel.Text = _subject.SubjectName + " Details";
            subjectNameInput.Text = _subject.SubjectName;

            addBtn1.Enabled = false;
            removeBtn1.Enabled = false;

            // get user role
            List<UserRole> userRoles;
            using(MyDbContext db = new())
            {
                var role = db.Roles.FirstOrDefault(r => r.RoleName == "teacher");
                userRoles = db.UserRoles.Where(u => u.RoleId == role.Id).ToList();
            }

            // fill teacher list box
            teacherList = new();
            using(MyDbContext db = new())
            {
                foreach (var ur in userRoles)
                {
                    var teacher = db.Users.FirstOrDefault(u => u.Id == ur.UserId);
                    if (teacher != null)
                    {
                        teacherList.Add(teacher);
                        teacherListBox.Items.Add(teacher.Name + " " + teacher.Surname);
                    }
                }
            }

            // fill subject teacher list box
            List<TeacherSubject> teacherSubjects;
            using(MyDbContext db = new())
            {
                teacherSubjects = db.TeacherSubjects
                    .Where(ts => ts.SubjectId == _subject.Id)
                    .ToList();
            }
            
            subjectTeacherList = new();
            using(MyDbContext db = new())
            {
                foreach (var ts in teacherSubjects)
                {
                    var teacher = db.Users.FirstOrDefault(u => u.Id == ts.UserId);
                    if (teacher != null)
                    {
                        subjectTeacherList.Add(teacher);
                        subjectTListBox.Items.Add(teacher.Name + " " + teacher.Surname);
                    }
                }
            }
        }

        private void teacherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = teacherList[teacherListBox.SelectedIndex];

            if(!subjectTeacherList.Any() ||
                subjectTeacherList.FirstOrDefault(t => t.Id == selectedItem.Id) == null)
            {
                addBtn1.Enabled = true;
            }
            else
            {
                addBtn1.Enabled = false;
            }
        }

        private void subjectTListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeBtn1.Enabled = true;
        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            subjectTListBox.Items.Add(teacherListBox.SelectedItem);
            subjectTeacherList.Add(teacherList[teacherListBox.SelectedIndex]);

            addBtn1.Enabled = false;
        }

        private void removeBtn1_Click(object sender, EventArgs e)
        {
            subjectTeacherList.RemoveAt(subjectTListBox.SelectedIndex);
            subjectTListBox.Items.Remove(subjectTListBox.SelectedItem);

            removeBtn1.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // update subject name
            using(MyDbContext db = new())
            {
                _subject.SubjectName = subjectNameInput.Text;
                db.Update(_subject);
                db.SaveChanges();
            }

            // update subject teachers
            using(MyDbContext db = new())
            {
                TeacherSubject del;
                do
                {
                    del = db.TeacherSubjects.FirstOrDefault(s => s.SubjectId == _subject.Id);
                    if (del != null)
                    {
                        db.TeacherSubjects.Remove(del);
                        db.SaveChanges();
                    }

                } while (del != null);

                foreach (var st in subjectTeacherList)
                {
                    TeacherSubject tmp = new()
                    {
                        UserId = st.Id,
                        SubjectId = _subject.Id
                    };
                    db.TeacherSubjects.Add(tmp);
                    db.SaveChanges();
                }
            }

            IsUpdated = true;

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
