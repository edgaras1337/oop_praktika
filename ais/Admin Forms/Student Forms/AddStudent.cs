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
    public partial class AddStudent : Form
    {
        // role id from studentControl
        private readonly int _roleId;

        // update ref
        public bool IsUpdated { get; set; }

        // group list in combo box
        List<Group> groupListCB;

        public AddStudent(int roleId)
        {
            InitializeComponent();
            _roleId = roleId;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            IsUpdated = false;

            // load group combo box with existing groups
            groupListCB = new();
            using MyDbContext db = new();
            foreach(var g in db.Groups.ToList())
            {
                groupListCB.Add(g);
                groupComboBox.Items.Add(g.GroupName);
            }
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string surname = surnameInput.Text.Trim();
            string username = usernameInput.Text.Trim();
            string password = passwordInput.Text.Trim();

            // check if all fields are filled
            if (name != "" && surname != "" 
                && username != "" && password != "" 
                && groupComboBox.SelectedItem != null)
            {
                User student = new()
                {
                    Username = username,
                    Password = password,
                    Name = name,
                    Surname = surname,
                    GroupId = groupListCB[groupComboBox.SelectedIndex].Id
                };

                // add user to db
                using (MyDbContext db = new())
                {
                    db.Users.Add(student);
                    db.SaveChanges();

                    db.UserRoles.Add(new()
                    {
                        UserId = student.Id,
                        RoleId = _roleId
                    });
                    db.SaveChanges();
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

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            usernameInput.Text = nameInput.Text.Trim();
        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {
            passwordInput.Text = surnameInput.Text.Trim();
        }
    }
}
