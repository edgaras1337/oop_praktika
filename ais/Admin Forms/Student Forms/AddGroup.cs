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
    public partial class AddGroup : Form
    {
        // update flag
        public bool IsUpdated { get; set; }
        public AddGroup()
        {
            InitializeComponent();
        }

        private void addSubjectBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            if (name != "")
            {
                // add group to db
                using MyDbContext db = new();
                db.Groups.Add(new Group()
                {
                    GroupName = name
                });
                db.SaveChanges();

                IsUpdated = true;
                Close();
            }
            else
            {
                MessageBox.Show
                (
                    "Please enter the group name!",
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
