
namespace ais
{
    partial class AdminWin
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
            this.mngTeacherBtn = new System.Windows.Forms.Button();
            this.mngGroupsBtn = new System.Windows.Forms.Button();
            this.mngSubjectsBtn = new System.Windows.Forms.Button();
            this.mngButtonsPanel = new System.Windows.Forms.Panel();
            this.mngStudentsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mngButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mngTeacherBtn
            // 
            this.mngTeacherBtn.Location = new System.Drawing.Point(77, 52);
            this.mngTeacherBtn.Name = "mngTeacherBtn";
            this.mngTeacherBtn.Size = new System.Drawing.Size(206, 43);
            this.mngTeacherBtn.TabIndex = 1;
            this.mngTeacherBtn.Text = "Manage Teachers";
            this.mngTeacherBtn.UseVisualStyleBackColor = true;
            this.mngTeacherBtn.Click += new System.EventHandler(this.mngTeacherBtn_Click);
            // 
            // mngGroupsBtn
            // 
            this.mngGroupsBtn.Location = new System.Drawing.Point(77, 175);
            this.mngGroupsBtn.Name = "mngGroupsBtn";
            this.mngGroupsBtn.Size = new System.Drawing.Size(206, 41);
            this.mngGroupsBtn.TabIndex = 2;
            this.mngGroupsBtn.Text = "Manage Student Groups";
            this.mngGroupsBtn.UseVisualStyleBackColor = true;
            this.mngGroupsBtn.Click += new System.EventHandler(this.mngGroupsBtn_Click);
            // 
            // mngSubjectsBtn
            // 
            this.mngSubjectsBtn.Location = new System.Drawing.Point(77, 117);
            this.mngSubjectsBtn.Name = "mngSubjectsBtn";
            this.mngSubjectsBtn.Size = new System.Drawing.Size(206, 39);
            this.mngSubjectsBtn.TabIndex = 3;
            this.mngSubjectsBtn.Text = "Manage Subjects";
            this.mngSubjectsBtn.UseVisualStyleBackColor = true;
            this.mngSubjectsBtn.Click += new System.EventHandler(this.mngSubjectsBtn_Click);
            // 
            // mngButtonsPanel
            // 
            this.mngButtonsPanel.Controls.Add(this.mngStudentsBtn);
            this.mngButtonsPanel.Controls.Add(this.mngTeacherBtn);
            this.mngButtonsPanel.Controls.Add(this.mngSubjectsBtn);
            this.mngButtonsPanel.Controls.Add(this.mngGroupsBtn);
            this.mngButtonsPanel.Location = new System.Drawing.Point(283, 118);
            this.mngButtonsPanel.Name = "mngButtonsPanel";
            this.mngButtonsPanel.Size = new System.Drawing.Size(351, 319);
            this.mngButtonsPanel.TabIndex = 4;
            // 
            // mngStudentsBtn
            // 
            this.mngStudentsBtn.Location = new System.Drawing.Point(77, 232);
            this.mngStudentsBtn.Name = "mngStudentsBtn";
            this.mngStudentsBtn.Size = new System.Drawing.Size(206, 41);
            this.mngStudentsBtn.TabIndex = 4;
            this.mngStudentsBtn.Text = "Manage Individual Students";
            this.mngStudentsBtn.UseVisualStyleBackColor = true;
            this.mngStudentsBtn.Click += new System.EventHandler(this.mngStudentsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(346, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control Panel";
            // 
            // AdminWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mngButtonsPanel);
            this.Name = "AdminWin";
            this.Text = "lab";
            this.mngButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mngTeacherBtn;
        private System.Windows.Forms.Button mngGroupsBtn;
        private System.Windows.Forms.Button mngSubjectsBtn;
        private System.Windows.Forms.Panel mngButtonsPanel;
        private System.Windows.Forms.Button mngStudentsBtn;
        private System.Windows.Forms.Label label1;
    }
}