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
    public partial class AddSubject : Form
    {
        // update red
        public bool IsUpdated { get; set; }

        // lists
        private List<User> teacherList;
        private List<User> selectedTeacherList;

        public AddSubject()
        {
            InitializeComponent();
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            // get user role tbl rows
            List<UserRole> userRoles;
            using(MyDbContext db = new())
            {
                var role = db.Roles.FirstOrDefault(r => r.RoleName == "teacher");
                userRoles = db.UserRoles.Where(r => r.RoleId == role.Id).ToList();
            }

            // add teachers to list box
            teacherList = new();
            selectedTeacherList = new();
            using (MyDbContext db = new())
            {
                foreach (var ur in userRoles)
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == ur.UserId);
                    if (user != null)
                    {
                        teacherList.Add(user);
                        teacherListBox.Items.Add(user.Id + " " + user.Name + " " + user.Surname);
                    }
                }
            }
        }

        private void addSubjectBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            if(name != "" && teacherListBox.SelectedItems.Count > 0)
            {
                Subject subject = new()
                {
                    SubjectName = name
                };
                // add subject to db
                using (MyDbContext db = new())
                {
                    db.Subjects.Add(subject);
                    db.SaveChanges();
                }

                // add selected teacher to a list
                foreach (int i in teacherListBox.SelectedIndices)
                {
                    selectedTeacherList.Add(teacherList[i]);
                }

                // add teacher subjects with selected teachers into db
                using(MyDbContext db = new())
                {
                    foreach (var t in selectedTeacherList)
                    {
                        db.TeacherSubjects.Add(new()
                        {
                            UserId = t.Id,
                            SubjectId = subject.Id
                        });
                        db.SaveChanges();
                    }
                }


                IsUpdated = true;
                Close();
            }
            else
            {
                MessageBox.Show
                (
                    "Please fill out all fields!",
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
