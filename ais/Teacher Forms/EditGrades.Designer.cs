
namespace ais.Teacher_Forms
{
    partial class EditGrades
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
            this.gradeGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeGrid
            // 
            this.gradeGrid.AllowUserToAddRows = false;
            this.gradeGrid.AllowUserToDeleteRows = false;
            this.gradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.grade});
            this.gradeGrid.Location = new System.Drawing.Point(40, 99);
            this.gradeGrid.Name = "gradeGrid";
            this.gradeGrid.RowHeadersVisible = false;
            this.gradeGrid.RowHeadersWidth = 51;
            this.gradeGrid.RowTemplate.Height = 29;
            this.gradeGrid.Size = new System.Drawing.Size(718, 247);
            this.gradeGrid.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Student Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name Surname";
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
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(319, 361);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(178, 39);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(354, 406);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(40, 27);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(190, 46);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "Edit Grades";
            // 
            // EditGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.gradeGrid);
            this.Name = "EditGrades";
            this.Text = "EditGrades";
            this.Load += new System.EventHandler(this.EditGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gradeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label headingLabel;
    }
}