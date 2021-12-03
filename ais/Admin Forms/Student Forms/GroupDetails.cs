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
    public partial class GroupDetails : Form
    {
        private Group _group;

        // subject list in dgv from db
        private List<Subject> subjectListDb;

        // subject list to pick from in combo box (not in db)
        private List<Subject> subjectListCB;

        // lists of items to be added to db

        private List<GroupSubject> groupSubjectToDb;

        // lists of items to be deleted from db
        private List<GroupSubject> delGroupSubjects;

        // teacher list to pick from in combo box
        private List<User> teacherListCB;

        public GroupDetails(Group group)
        {
            InitializeComponent();
            _group = group;
        }

        private void Group_Details_Load(object sender, EventArgs e)
        {
            subjectRadioBtn.Checked = true;

            headingLabel.Text = _group.GroupName + " Group Details";
            groupNameInput.Text = _group.GroupName;

            subjectGrid.AutoGenerateColumns = false;
            subjectGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            id.Width = 100;
            delete.Width = 150;

            // create lists
            groupSubjectToDb = new();
            delGroupSubjects = new();
            subjectListCB = new();
            subjectListDb = new();

            // fill dgv with subjects that are in the db
            // fill subjectList with subjects that are in the db
            List<GroupSubject> groupSubjects = new();
            using(MyDbContext db = new())
            {
                groupSubjects = db.
                    GroupSubjects
                    .Where(g => g.GroupId == _group.Id)
                    .ToList();

            }

            using (MyDbContext db = new())
            {
                foreach (var gs in groupSubjects)
                {
                
                    var ts = db.TeacherSubjects.FirstOrDefault(ts => ts.Id == gs.TeacherSubjectId);
                    var subject = db.Subjects.FirstOrDefault(s => s.Id == ts.SubjectId);
                    var teacher = db.Users.FirstOrDefault(t => t.Id == ts.UserId);

                    subjectListDb.Add(subject);

                    DataGridViewRow row = new();
                    row.CreateCells(subjectGrid);

                    row.Cells[0].Value = gs.Id;
                    row.Cells[1].Value = subject.SubjectName;
                    row.Cells[2].Value = teacher.Name + " " + teacher.Surname;

                    subjectGrid.Rows.Add(row);
                }
            }

            // fill subject list combo box with subjects which are not in db
            using (MyDbContext db = new())
            {
                foreach (var s in db.Subjects.ToList())
                {
                    if (subjectListDb.Count == 0)
                    {
                        subjectListCB.Add(s);
                        subjectComboBox.Items.Add(s.SubjectName);
                    }
                    else if (!subjectListDb.Any(x => x.Id == s.Id))
                    {
                        subjectListCB.Add(s);
                        subjectComboBox.Items.Add(s.SubjectName);
                    }
                }
            }

            // load student panel
            studentGrid.AutoGenerateColumns = false;
            studentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sId.Width = 100;

            using (MyDbContext db = new())
            {
                var students = db.Users.Where(s => s.GroupId == _group.Id);

                foreach (var s in students)
                {
                    DataGridViewRow row = new();
                    row.CreateCells(studentGrid);

                    row.Cells[0].Value = s.Id;
                    row.Cells[1].Value = s.Name;
                    row.Cells[2].Value = s.Surname;
                    row.Cells[3].Value = _group.GroupName;

                    studentGrid.Rows.Add(row);
                }
            }
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on cbox index change, clear the teacher combo box
            // create new teacher combo box
            teacherComboBox.Items.Clear();
            teacherListCB = new();

            var subject = subjectListCB[subjectComboBox.SelectedIndex];
            List<TeacherSubject> teacherSubjects = new();
            using(MyDbContext db = new())
            {
                teacherSubjects = db.
                    TeacherSubjects
                    .Where(ts => ts.SubjectId == subject.Id)
                    .ToList();
            }
            
            using(MyDbContext db = new())
            {
                foreach (var ts in teacherSubjects)
                {
                    var teacher = db.Users.FirstOrDefault(t => t.Id == ts.UserId);

                    teacherListCB.Add(teacher);
                    teacherComboBox.Items.Add(teacher.Name + " " + teacher.Surname);
                }
            }
        }

        private void addSubjectBtn_Click(object sender, EventArgs e)
        {
            // check if anything is selected
            if(subjectComboBox.SelectedIndex > -1 && teacherComboBox.SelectedIndex > -1)
            {
                // get the selected subject and teacher
                var subject = subjectListCB[subjectComboBox.SelectedIndex];

                var teacher = teacherListCB[teacherComboBox.SelectedIndex];

                // remove the selected subject from combobox and clear selection
                subjectComboBox.Items.RemoveAt(subjectComboBox.SelectedIndex);
                subjectComboBox.SelectedIndex = -1;

                // clear teacher cbox selection and remove items
                teacherComboBox.Items.Clear();
                teacherComboBox.SelectedIndex = -1;

                // remove subject from the subject cb list
                subjectListCB.Remove(subject);

                // add a row with the new subject in dgv
                DataGridViewRow row = new();
                row.CreateCells(subjectGrid);

                row.Cells[1].Value = subject.SubjectName;
                row.Cells[2].Value = teacher.Name + " " + teacher.Surname;

                subjectGrid.Rows.Add(row);

                // add the group subject to a list which may be added to db later if changes are saved
                using MyDbContext db = new();
                var ts = db.TeacherSubjects.FirstOrDefault(
                    ts => ts.SubjectId == subject.Id && ts.UserId == teacher.Id);

                groupSubjectToDb.Add(new GroupSubject()
                {
                    GroupId = _group.Id,
                    TeacherSubjectId = ts.Id
                });
                
            }
            else
            {
                MessageBox.Show(
                    "Please fill out all fields!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string groupName = groupNameInput.Text.Trim();
            if(groupName != "")
            {
                using (MyDbContext db = new())
                {
                    // update group name
                    _group.GroupName = groupName;
                    db.Update(_group);
                    db.SaveChanges();

                    // update group subjects
                    foreach (var gs in groupSubjectToDb)
                    {
                        db.GroupSubjects.Add(gs);
                        db.SaveChanges();
                    }

                    // remove group subjects
                    foreach (var dgs in delGroupSubjects)
                    {
                        db.GroupSubjects.Remove(dgs);
                        db.SaveChanges();
                    }
                }

                Close();
            }
            else
            {
                MessageBox.Show
                (
                    "Invalid group name change!",
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

        private void subjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check for delete column
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show
                (
                    "Are you sure you want to remove this subject from the group?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                
                if (dr == DialogResult.Yes)
                {
                    // subject name for dgv
                    var subjectName = subjectGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

                    using(MyDbContext db = new())
                    {
                        // adding the deleted subject back to combo box options
                        subjectComboBox.Items.Add(subjectName);
                        subjectListCB.Add(db.Subjects.FirstOrDefault(s => s.SubjectName == subjectName));

                        // if the group subject obj doesnt have id value it is not in the db
                        // if it has, it is put in a list and removed from db if changes are saved
                        var id = subjectGrid.Rows[e.RowIndex].Cells[0].Value;
                        if (id != null)
                        {
                            delGroupSubjects.Add(db.GroupSubjects.FirstOrDefault(gs => gs.Id == (int)id));
                        }
                        else
                        {
                            // counting the index of item in groupSubjectDb
                            int index = 0;
                            for(int i = 0; i < e.RowIndex; i++)
                            {
                                if (subjectGrid.Rows[i].Cells[0].Value == null)
                                {
                                    index++;
                                }
                            }
                            groupSubjectToDb.RemoveAt(index);
                        }
                        // removing the row from dgv
                        subjectGrid.Rows.RemoveAt(e.RowIndex);
                    }

                    MessageBox.Show
                    (
                        "Subject removed succesfully!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void subjectRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (subjectRadioBtn.Checked)
            {
                subjectPanel.Show();
                studentPanel.Hide();
            }
            else
            {
                subjectPanel.Hide();
                studentPanel.Show();
            }
        }
    }
}
