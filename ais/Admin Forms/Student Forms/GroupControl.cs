using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ais.Models;

namespace ais
{
    public partial class GroupControl : Form
    {
        // lists
        private List<Group> groupList;

        // windows
        private AddGroup addGroupWin;
        private GroupDetails groupDetails;

        public GroupControl()
        {
            InitializeComponent();
        }

        void updateGroup()
        {
            using MyDbContext db = new();
            groupList = db.Groups.ToList();
            groupGrid.DataSource = groupList;
        }

        private void GroupControl_Load(object sender, EventArgs e)
        {
            groupGrid.AutoGenerateColumns = false;
            groupGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            id.Width = 100;
            edit.Width = 150;
            delete.Width = 150;

            updateGroup();
        }

        private void newRecordBtn_Click(object sender, EventArgs e)
        {
            addGroupWin = new();
            addGroupWin.Show();
            addGroupWin.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
        }

        private void updateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(addGroupWin != null && addGroupWin.IsUpdated)
            {
                updateGroup();
            }
        }

        private void groupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check for edit or delete btn column
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                groupDetails = new(groupList[e.RowIndex]);
                groupDetails.Show();
                groupDetails.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
            }
            else if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show
                (
                    "Are you sure you want to delete this group and all students within?",
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    // pick the group from list
                    var group = groupList[e.RowIndex];

                    // create list of users from the group
                    List<User> users = new();
                    using (MyDbContext db = new())
                    {
                        var u = db
                            .Users
                            .AsNoTracking()
                            .Where(u => u.GroupId == group.Id);

                        foreach (var x in u)
                        {
                            users.Add(x);
                        }
                    }

                    // delete tables with user fk
                    using (MyDbContext db = new())
                    {
                        foreach (var user in users)
                        {
                            // delete subjectGrade tbl rows
                            var grades = db
                                .SubjectGrades
                                .AsNoTracking()
                                .Where(g => g.UserId == user.Id);

                            db.SubjectGrades.RemoveRange(grades);
                            db.SaveChanges();

                            // delete userRole tbl rows
                            var ur = db.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);
                            db.UserRoles.Remove(ur);
                            db.SaveChanges();

                            // delete user tbl rows
                            db.Users.Remove(user);
                            db.SaveChanges();
                        }
                    }

                    // delete tables with group fk
                    using (MyDbContext db = new())
                    {
                        var groupSubjects = db
                            .GroupSubjects
                            .Where(gs => gs.GroupId == group.Id);
                        foreach (var gs in groupSubjects)
                        {
                            db.GroupSubjects.Remove(gs);
                        }
                        db.Groups.Remove(group);

                        db.SaveChanges();
                    }

                    // update dgv
                    updateGroup();

                    MessageBox.Show
                    (
                        "Group removed succesfully!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
    }
}
