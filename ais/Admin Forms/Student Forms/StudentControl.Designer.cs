
namespace ais
{
    partial class StudentControl
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
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.newRecordBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teacherControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherControlPanel
            // 
            this.teacherControlPanel.Controls.Add(this.studentGrid);
            this.teacherControlPanel.Controls.Add(this.newRecordBtn);
            this.teacherControlPanel.Controls.Add(this.headingLabel);
            this.teacherControlPanel.Location = new System.Drawing.Point(8, 6);
            this.teacherControlPanel.Name = "teacherControlPanel";
            this.teacherControlPanel.Size = new System.Drawing.Size(892, 438);
            this.teacherControlPanel.TabIndex = 9;
            // 
            // studentGrid
            // 
            this.studentGrid.AllowUserToAddRows = false;
            this.studentGrid.AllowUserToDeleteRows = false;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.group,
            this.edit,
            this.delete});
            this.studentGrid.Location = new System.Drawing.Point(22, 173);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.ReadOnly = true;
            this.studentGrid.RowHeadersVisible = false;
            this.studentGrid.RowHeadersWidth = 51;
            this.studentGrid.RowTemplate.Height = 29;
            this.studentGrid.Size = new System.Drawing.Size(857, 262);
            this.studentGrid.TabIndex = 2;
            this.studentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellContentClick);
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
            this.headingLabel.Size = new System.Drawing.Size(347, 46);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Student Control Panel";
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 125;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.surname.Width = 125;
            // 
            // group
            // 
            this.group.DataPropertyName = "group";
            this.group.HeaderText = "Group";
            this.group.MinimumWidth = 6;
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.group.Width = 125;
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
            this.delete.HeaderText = "Delete Student";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete Student";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 463);
            this.Controls.Add(this.teacherControlPanel);
            this.Name = "StudentControl";
            this.Text = "StudentControl";
            this.Load += new System.EventHandler(this.StudentControl_Load);
            this.teacherControlPanel.ResumeLayout(false);
            this.teacherControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel teacherControlPanel;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Button newRecordBtn;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}