using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ais.Models;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using ais.Teacher_Forms;
using ais.Student_Forms;

namespace ais
{
    public partial class LoginWin : Form
    {
        private readonly MyDbContext _context;
        User user;
        public LoginWin()
        {
            InitializeComponent();
            _context = new();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string unameInput = usernameInput.Text.Trim();
            string passInput = passwordInput.Text.Trim();

            if (unameInput != "" && passInput != "")
            {
                try
                {
                    user = _context.Users.FirstOrDefault(
                        u => u.Username == unameInput && u.Password == passInput
                    );

                    if (user != null)
                    {
                        var userRole = _context.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);
                        var role = _context.Roles.FirstOrDefault(r => r.Id == userRole.RoleId);

                        if (role.RoleName == "admin")
                        {
                            AdminWin adminWin = new(_context);
                            adminWin.FormClosed += new FormClosedEventHandler(userWin_FormClosed);
                            Hide();
                            adminWin.Show();
                        }
                        else if (role.RoleName == "teacher")
                        {
                            TeacherWin teacherWin = new(user);
                            teacherWin.FormClosed += new FormClosedEventHandler(userWin_FormClosed);
                            Hide();
                            teacherWin.Show();
                        }
                        else if (role.RoleName == "student")
                        {
                            StudentWin studentWin = new(user);
                            studentWin.FormClosed += new FormClosedEventHandler(userWin_FormClosed);
                            Hide();
                            studentWin.Show();
                        }
                        usernameInput.Text = "";
                        passwordInput.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Connection Error", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please enter your username and password!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }
        void userWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
