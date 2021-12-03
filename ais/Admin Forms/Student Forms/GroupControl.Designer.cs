
namespace ais
{
    partial class GroupControl
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
            this.groupGrid = new System.Windows.Forms.DataGridView();
            this.newRecordBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teacherControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherControlPanel
            // 
            this.teacherControlPanel.Controls.Add(this.groupGrid);
            this.teacherControlPanel.Controls.Add(this.newRecordBtn);
            this.teacherControlPanel.Controls.Add(this.headingLabel);
            this.teacherControlPanel.Location = new System.Drawing.Point(8, 6);
            this.teacherControlPanel.Name = "teacherControlPanel";
            this.teacherControlPanel.Size = new System.Drawing.Size(785, 438);
            this.teacherControlPanel.TabIndex = 8;
            // 
            // groupGrid
            // 
            this.groupGrid.AllowUserToAddRows = false;
            this.groupGrid.AllowUserToDeleteRows = false;
            this.groupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.groupName,
            this.edit,
            this.delete});
            this.groupGrid.Location = new System.Drawing.Point(22, 173);
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.ReadOnly = true;
            this.groupGrid.RowHeadersVisible = false;
            this.groupGrid.RowHeadersWidth = 51;
            this.groupGrid.RowTemplate.Height = 29;
            this.groupGrid.Size = new System.Drawing.Size(751, 262);
            this.groupGrid.TabIndex = 2;
            this.groupGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupGrid_CellContentClick);
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
            this.headingLabel.Size = new System.Drawing.Size(324, 46);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Group Control Panel";
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
            // groupName
            // 
            this.groupName.DataPropertyName = "groupName";
            this.groupName.HeaderText = "Group Name";
            this.groupName.MinimumWidth = 6;
            this.groupName.Name = "groupName";
            this.groupName.ReadOnly = true;
            this.groupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.groupName.Width = 125;
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
            this.delete.HeaderText = "Delete Group";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete Group";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.teacherControlPanel);
            this.Name = "GroupControl";
            this.Text = "StudentWin";
            this.Load += new System.EventHandler(this.GroupControl_Load);
            this.teacherControlPanel.ResumeLayout(false);
            this.teacherControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel teacherControlPanel;
        private System.Windows.Forms.DataGridView groupGrid;
        private System.Windows.Forms.Button newRecordBtn;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}