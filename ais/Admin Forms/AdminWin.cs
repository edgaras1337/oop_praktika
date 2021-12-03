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
using MySql.Data.MySqlClient;

namespace ais
{
    public partial class AdminWin : Form
    {
        private readonly MyDbContext _context;

        public AdminWin(MyDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        // manage teachers window
        private void mngTeacherBtn_Click(object sender, EventArgs e)
        {
            TeacherControl tControlPanel = new();
            tControlPanel.Show();
        }

        // manage subjects window
        private void mngSubjectsBtn_Click(object sender, EventArgs e)
        {
            SubjectControl subjectControlPanel = new();
            subjectControlPanel.Show();
        }

        // manage groups window
        private void mngGroupsBtn_Click(object sender, EventArgs e)
        {
            GroupControl groupControlPanel = new();
            groupControlPanel.Show();
        }

        // manage students window
        private void mngStudentsBtn_Click(object sender, EventArgs e)
        {
            StudentControl studentControlPanel = new(_context);
            studentControlPanel.Show();
        }
    }
}
