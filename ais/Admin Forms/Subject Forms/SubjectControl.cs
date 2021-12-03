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
    public partial class SubjectControl : Form
    {
        // subject list from db
        private List<Subject> subjectList;

        // windows
        private SubjectDetails detailsWin;
        private AddSubject addSubjectWin;
        public SubjectControl()
        {
            InitializeComponent();
        }

        private void updateList()
        {
            // update dgv data
            using (MyDbContext db = new())
            {
                subjectList = db.Subjects.ToList();
            }
            
            subjectGrid.DataSource = subjectList;
        }

        private void SubjectControl_Load(object sender, EventArgs e)
        {
            subjectGrid.AutoGenerateColumns = false;
            subjectGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            id.Width = 100;
            edit.Width = 150;
            delete.Width = 150;

            updateList();
        }

        private void newRecordBtn_Click(object sender, EventArgs e)
        {
            addSubjectWin = new();
            addSubjectWin.Show();
            addSubjectWin.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
        }

        private void updateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update dgv if anything has been changed
            if (addSubjectWin != null && addSubjectWin.IsUpdated)
            {
                updateList();
            }
            if (detailsWin != null && detailsWin.IsUpdated)
            {
                updateList();
            }
        }

        private void subjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                // open details window with selected subject
                detailsWin = new(subjectList[e.RowIndex]);
                detailsWin.Show();
                detailsWin.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
            }
            else if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show
                (
                    "Are you sure you want to delete this subject?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    var subject = subjectList[e.RowIndex];

                    // remove from db
                    using (MyDbContext db = new())
                    {
                        var dts = db.TeacherSubjects.Where(s => s.SubjectId == subject.Id);
                        foreach (var ts in dts)
                        {
                            using (MyDbContext db2 = new())
                            {
                                // remove group subject
                                var gss = db2.GroupSubjects.Where(gs => gs.TeacherSubjectId == ts.Id);
                                db2.GroupSubjects.RemoveRange(gss);

                                // remove subject grades
                                var sgs = db2.SubjectGrades.Where(sg => sg.TeacherSubjectId == ts.Id);
                                db2.SubjectGrades.RemoveRange(sgs);

                                db2.SaveChanges();
                            }

                            // remove teacher subjects
                            db.TeacherSubjects.Remove(ts);
                        }

                        db.Subjects.Remove(subject);
                        db.SaveChanges();
                    }
                    // remove from list
                    subjectList.Remove(subject);

                    updateList();

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
    }
}
