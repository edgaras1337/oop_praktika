
namespace ais
{
    partial class SubjectControl
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
            this.teacherControlPanel = new System.Windows.Forms.Panel();
            this.subjectGrid = new System.Windows.Forms.DataGridView();
            this.newRecordBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teacherControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherControlPanel
            // 
            this.teacherControlPanel.Controls.Add(this.subjectGrid);
            this.teacherControlPanel.Controls.Add(this.newRecordBtn);
            this.teacherControlPanel.Controls.Add(this.headingLabel);
            this.teacherControlPanel.Location = new System.Drawing.Point(3, 0);
            this.teacherControlPanel.Name = "teacherControlPanel";
            this.teacherControlPanel.Size = new System.Drawing.Size(785, 438);
            this.teacherControlPanel.TabIndex = 7;
            // 
            // subjectGrid
            // 
            this.subjectGrid.AllowUserToAddRows = false;
            this.subjectGrid.AllowUserToDeleteRows = false;
            this.subjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subjectName,
            this.edit,
            this.delete});
            this.subjectGrid.Location = new System.Drawing.Point(22, 173);
            this.subjectGrid.Name = "subjectGrid";
            this.subjectGrid.ReadOnly = true;
            this.subjectGrid.RowHeadersVisible = false;
            this.subjectGrid.RowHeadersWidth = 51;
            this.subjectGrid.RowTemplate.Height = 29;
            this.subjectGrid.Size = new System.Drawing.Size(751, 262);
            this.subjectGrid.TabIndex = 2;
            this.subjectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectGrid_CellContentClick);
            // 
            // newRecordBtn
            // 
            this.newRecordBtn.Location = new System.Drawing.Point(38, 114);
            this.newRecordBtn.Name = "newRecordBtn";
            this.newRecordBtn.Size = new System.Drawing.Size(138, 39);
            this.newRecordBtn.TabIndex = 1;
            this.newRecordBtn.Text = "New Record";
            this.newRecordBtn.UseVisualStyleBackColor = true;
            this.newRecordBtn.Click += new System.EventHandler(this.newRecordBtn_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(22, 12);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(341, 46);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Subject Control Panel";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 125;
            // 
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "Subject";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.subjectName.Width = 125;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit / See Details";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit / See Details";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete Subject";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete Subject";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // SubjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.teacherControlPanel);
            this.Name = "SubjectControl";
            this.Text = "SubjectControl";
            this.Load += new System.EventHandler(this.SubjectControl_Load);
            this.teacherControlPanel.ResumeLayout(false);
            this.teacherControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel teacherControlPanel;
        private System.Windows.Forms.DataGridView subjectGrid;
        private System.Windows.Forms.Button newRecordBtn;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}