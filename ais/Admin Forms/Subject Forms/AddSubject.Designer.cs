
namespace ais
{
    partial class AddSubject
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addSubjectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(84, 101);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(102, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Subject Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(215, 101);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(250, 27);
            this.nameInput.TabIndex = 4;
            // 
            // addSubjectBtn
            // 
            this.addSubjectBtn.Location = new System.Drawing.Point(152, 411);
            this.addSubjectBtn.Name = "addSubjectBtn";
            this.addSubjectBtn.Size = new System.Drawing.Size(240, 45);
            this.addSubjectBtn.TabIndex = 5;
            this.addSubjectBtn.Text = "Add Subject";
            this.addSubjectBtn.UseVisualStyleBackColor = true;
            this.addSubjectBtn.Click += new System.EventHandler(this.addSubjectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(215, 472);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(128, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(264, 46);
            this.headingLabel.TabIndex = 8;
            this.headingLabel.Text = "Create a Subject";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Location = new System.Drawing.Point(73, 156);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(119, 20);
            this.teacherLabel.TabIndex = 1;
            this.teacherLabel.Text = "Subject Teachers";
            // 
            // teacherListBox
            // 
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.HorizontalScrollbar = true;
            this.teacherListBox.ItemHeight = 20;
            this.teacherListBox.Location = new System.Drawing.Point(215, 156);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.teacherListBox.Size = new System.Drawing.Size(250, 104);
            this.teacherListBox.TabIndex = 3;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 540);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSubjectBtn);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button addSubjectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.ListBox teacherListBox;
    }
}