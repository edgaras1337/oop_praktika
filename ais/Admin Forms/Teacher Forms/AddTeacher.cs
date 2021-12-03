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
    public partial class AddTeacher : Form
    {
        // passed role id
        private readonly int _roleId;

        // lists
        private List<Subject> teacherSubjectList;
        private List<Subject> subjectList;

        // update ref
        public bool IsUpdated { get; set; }

        public AddTeacher(int roleId)
        {
            InitializeComponent();
            _roleId = roleId;
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            IsUpdated = false;

            removeBtn1.Enabled = false;
            addBtn1.Enabled = false;

            // initialize values with subject data
            using (MyDbContext db = new())
            {
                subjectList = db.Subjects.ToList();
            }
            
            if (subjectList != null)
            {
                foreach (var s in subjectList)
                {
                    subjectsListBox.Items.Add(s.SubjectName);
                }
            }
            teacherSubjectList = new();
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            usernameInput.Text = nameInput.Text;
        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {
            passwordInput.Text = surnameInput.Text;
        }

        private void subjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = subjectList.FirstOrDefault(
                s => s.SubjectName == subjectsListBox.SelectedItem.ToString());

            if (!teacherSubjectList.Any() || 
                teacherSubjectList.FirstOrDefault(s => s.SubjectName == selectedItem.SubjectName) == null)
            {
                addBtn1.Enabled = true;
            }
            else
            {
                addBtn1.Enabled = false;
            }
        }

        private void tSubjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeBtn1.Enabled = true;
        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            tSubjectListBox.Items.Add(subjectsListBox.SelectedItem);
            teacherSubjectList.Add(subjectList[subjectsListBox.SelectedIndex]);

            addBtn1.Enabled = false;
        }

        private void removeBtn1_Click(object sender, EventArgs e)
        {
            teacherSubjectList.RemoveAt(tSubjectListBox.SelectedIndex);
            tSubjectListBox.Items.Remove(tSubjectListBox.SelectedItem);

            removeBtn1.Enabled = false;
        }

        private void createTeacherBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string surname = surnameInput.Text.Trim();
            string username = usernameInput.Text.Trim();
            string password = passwordInput.Text.Trim();
            if (name != "" && surname != "" && username != "" && password != "")
            {
                User teacher = new()
                {
                    Username = username,
                    Password = password,
                    Name = name,
                    Surname = surname,
                };

                // add user, user role and teacher subject to db
                using(MyDbContext db = new())
                {
                    db.Users.Add(teacher);
                    db.SaveChanges();

                    db.UserRoles.Add(new()
                    {
                        UserId = teacher.Id,
                        RoleId = _roleId
                    });
                    db.SaveChanges();

                    if (teacherSubjectList.Any())
                    {
                        foreach (var ts in teacherSubjectList)
                        {
                            TeacherSubject tmp = new()
                            {
                                UserId = teacher.Id,
                                SubjectId = ts.Id
                            };
                            db.TeacherSubjects.Add(tmp);
                            db.SaveChanges();
                        }
                    }
                }
                
                MessageBox.Show
                (
                    "Account was created succesfully!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                IsUpdated = true;
                Close();
            }
            else
            {
                MessageBox.Show
                (
                    "Please enter name and surname of the user!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
