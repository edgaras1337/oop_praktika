
namespace ais.Student_Forms
{
    partial class StudentWin
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.gradeGrid = new System.Windows.Forms.DataGridView();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(39, 21);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(141, 46);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "heading";
            // 
            // gradeGrid
            // 
            this.gradeGrid.AllowUserToAddRows = false;
            this.gradeGrid.AllowUserToDeleteRows = false;
            this.gradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject,
            this.name,
            this.grade});
            this.gradeGrid.Location = new System.Drawing.Point(39, 95);
            this.gradeGrid.Name = "gradeGrid";
            this.gradeGrid.RowHeadersVisible = false;
            this.gradeGrid.RowHeadersWidth = 51;
            this.gradeGrid.RowTemplate.Height = 29;
            this.gradeGrid.Size = new System.Drawing.Size(718, 308);
            this.gradeGrid.TabIndex = 1;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.subject.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Teacher";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 125;
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grade.Width = 125;
            // 
            // StudentWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeGrid);
            this.Controls.Add(this.headingLabel);
            this.Name = "StudentWin";
            this.Text = "StudentWin";
            this.Load += new System.EventHandler(this.StudentWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridView gradeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
    }
}