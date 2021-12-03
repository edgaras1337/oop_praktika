
namespace ais.Teacher_Forms
{
    partial class TeacherWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectGrid = new System.Windows.Forms.DataGridView();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grades = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectGrid
            // 
            this.subjectGrid.AllowUserToAddRows = false;
            this.subjectGrid.AllowUserToDeleteRows = false;
            this.subjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectName,
            this.group,
            this.grades});
            this.subjectGrid.Location = new System.Drawing.Point(29, 92);
            this.subjectGrid.Name = "subjectGrid";
            this.subjectGrid.ReadOnly = true;
            this.subjectGrid.RowHeadersVisible = false;
            this.subjectGrid.RowHeadersWidth = 51;
            this.subjectGrid.RowTemplate.Height = 29;
            this.subjectGrid.Size = new System.Drawing.Size(748, 314);
            this.subjectGrid.TabIndex = 0;
            this.subjectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectGrid_CellContentClick);
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.subjectName.Width = 125;
            // 
            // group
            // 
            this.group.HeaderText = "Group";
            this.group.MinimumWidth = 6;
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.Width = 125;
            // 
            // grades
            // 
            this.grades.HeaderText = "Edit Grades";
            this.grades.MinimumWidth = 6;
            this.grades.Name = "grades";
            this.grades.ReadOnly = true;
            this.grades.Text = "Edit Grades";
            this.grades.UseColumnTextForButtonValue = true;
            this.grades.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subjects and Groups";
            // 
            // TeacherWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectGrid);
            this.Name = "TeacherWin";
            this.Text = "TeacherMainWin";
            this.Load += new System.EventHandler(this.TeacherMainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewButtonColumn grades;
        private System.Windows.Forms.Label label1;
    }
}