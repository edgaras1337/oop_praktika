
namespace ais
{
    partial class GroupDetails
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headingLabel = new System.Windows.Forms.Label();
            this.subjectGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.addSubjectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectRadioBtn = new System.Windows.Forms.RadioButton();
            this.studentRadioBtn = new System.Windows.Forms.RadioButton();
            this.subjectPanel = new System.Windows.Forms.Panel();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).BeginInit();
            this.subjectPanel.SuspendLayout();
            this.studentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(417, 614);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 30;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(356, 562);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(216, 39);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupNameInput
            // 
            this.groupNameInput.Location = new System.Drawing.Point(227, 117);
            this.groupNameInput.Name = "groupNameInput";
            this.groupNameInput.Size = new System.Drawing.Size(227, 27);
            this.groupNameInput.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Change Group Name";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(41, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(98, 46);
            this.headingLabel.TabIndex = 25;
            this.headingLabel.Text = "Hello";
            // 
            // subjectGrid
            // 
            this.subjectGrid.AllowUserToAddRows = false;
            this.subjectGrid.AllowUserToDeleteRows = false;
            this.subjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subjectName,
            this.subjectTeacher,
            this.delete});
            this.subjectGrid.Location = new System.Drawing.Point(10, 61);
            this.subjectGrid.Name = "subjectGrid";
            this.subjectGrid.ReadOnly = true;
            this.subjectGrid.RowHeadersVisible = false;
            this.subjectGrid.RowHeadersWidth = 51;
            this.subjectGrid.RowTemplate.Height = 29;
            this.subjectGrid.Size = new System.Drawing.Size(804, 262);
            this.subjectGrid.TabIndex = 31;
            this.subjectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectGrid_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "Subject";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.Width = 125;
            // 
            // subjectTeacher
            // 
            this.subjectTeacher.HeaderText = "Teacher";
            this.subjectTeacher.MinimumWidth = 6;
            this.subjectTeacher.Name = "subjectTeacher";
            this.subjectTeacher.ReadOnly = true;
            this.subjectTeacher.Width = 125;
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
            // subjectComboBox
            // 
            this.subjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(129, 5);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(190, 28);
            this.subjectComboBox.TabIndex = 32;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(428, 4);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(190, 28);
            this.teacherComboBox.TabIndex = 33;
            // 
            // addSubjectBtn
            // 
            this.addSubjectBtn.Location = new System.Drawing.Point(650, 4);
            this.addSubjectBtn.Name = "addSubjectBtn";
            this.addSubjectBtn.Size = new System.Drawing.Size(107, 29);
            this.addSubjectBtn.TabIndex = 34;
            this.addSubjectBtn.Text = "Add";
            this.addSubjectBtn.UseVisualStyleBackColor = true;
            this.addSubjectBtn.Click += new System.EventHandler(this.addSubjectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Teacher";
            // 
            // subjectRadioBtn
            // 
            this.subjectRadioBtn.AutoSize = true;
            this.subjectRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectRadioBtn.Location = new System.Drawing.Point(335, 166);
            this.subjectRadioBtn.Name = "subjectRadioBtn";
            this.subjectRadioBtn.Size = new System.Drawing.Size(132, 32);
            this.subjectRadioBtn.TabIndex = 38;
            this.subjectRadioBtn.TabStop = true;
            this.subjectRadioBtn.Text = "Subject List";
            this.subjectRadioBtn.UseVisualStyleBackColor = true;
            this.subjectRadioBtn.CheckedChanged += new System.EventHandler(this.subjectRadioBtn_CheckedChanged);
            // 
            // studentRadioBtn
            // 
            this.studentRadioBtn.AutoSize = true;
            this.studentRadioBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentRadioBtn.Location = new System.Drawing.Point(473, 166);
            this.studentRadioBtn.Name = "studentRadioBtn";
            this.studentRadioBtn.Size = new System.Drawing.Size(135, 32);
            this.studentRadioBtn.TabIndex = 39;
            this.studentRadioBtn.TabStop = true;
            this.studentRadioBtn.Text = "Student List";
            this.studentRadioBtn.UseVisualStyleBackColor = true;
            // 
            // subjectPanel
            // 
            this.subjectPanel.Controls.Add(this.label2);
            this.subjectPanel.Controls.Add(this.subjectGrid);
            this.subjectPanel.Controls.Add(this.subjectComboBox);
            this.subjectPanel.Controls.Add(this.teacherComboBox);
            this.subjectPanel.Controls.Add(this.label3);
            this.subjectPanel.Controls.Add(this.addSubjectBtn);
            this.subjectPanel.Location = new System.Drawing.Point(63, 204);
            this.subjectPanel.Name = "subjectPanel";
            this.subjectPanel.Size = new System.Drawing.Size(823, 333);
            this.subjectPanel.TabIndex = 40;
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.studentGrid);
            this.studentPanel.Location = new System.Drawing.Point(63, 204);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(820, 333);
            this.studentPanel.TabIndex = 41;
            // 
            // studentGrid
            // 
            this.studentGrid.AllowUserToAddRows = false;
            this.studentGrid.AllowUserToDeleteRows = false;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.groupName});
            this.studentGrid.Location = new System.Drawing.Point(13, 0);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.ReadOnly = true;
            this.studentGrid.RowHeadersVisible = false;
            this.studentGrid.RowHeadersWidth = 51;
            this.studentGrid.RowTemplate.Height = 29;
            this.studentGrid.Size = new System.Drawing.Size(804, 333);
            this.studentGrid.TabIndex = 32;
            // 
            // sId
            // 
            this.sId.DataPropertyName = "id";
            this.sId.HeaderText = "Id";
            this.sId.MinimumWidth = 6;
            this.sId.Name = "sId";
            this.sId.ReadOnly = true;
            this.sId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sId.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // groupName
            // 
            this.groupName.DataPropertyName = "groupName";
            this.groupName.HeaderText = "Group";
            this.groupName.MinimumWidth = 6;
            this.groupName.Name = "groupName";
            this.groupName.ReadOnly = true;
            this.groupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.groupName.Width = 125;
            // 
            // GroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 659);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.subjectPanel);
            this.Controls.Add(this.studentRadioBtn);
            this.Controls.Add(this.subjectRadioBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingLabel);
            this.Name = "GroupDetails";
            this.Text = "EditGroup";
            this.Load += new System.EventHandler(this.Group_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).EndInit();
            this.subjectPanel.ResumeLayout(false);
            this.subjectPanel.PerformLayout();
            this.studentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox groupNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridView subjectGrid;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Button addSubjectBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectTeacher;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton subjectRadioBtn;
        private System.Windows.Forms.RadioButton studentRadioBtn;
        private System.Windows.Forms.Panel subjectPanel;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
    }
}