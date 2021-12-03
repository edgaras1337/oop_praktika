
namespace ais
{
    partial class SubjectDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.subjectNameInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectTListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.addBtn1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.removeBtn1 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(12, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(98, 46);
            this.headingLabel.TabIndex = 2;
            this.headingLabel.Text = "Hello";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject name";
            // 
            // subjectNameInput
            // 
            this.subjectNameInput.Location = new System.Drawing.Point(183, 98);
            this.subjectNameInput.Name = "subjectNameInput";
            this.subjectNameInput.Size = new System.Drawing.Size(227, 27);
            this.subjectNameInput.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subjectTListBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.teacherListBox);
            this.panel2.Controls.Add(this.addBtn1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.removeBtn1);
            this.panel2.Location = new System.Drawing.Point(54, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 142);
            this.panel2.TabIndex = 22;
            // 
            // subjectTListBox
            // 
            this.subjectTListBox.FormattingEnabled = true;
            this.subjectTListBox.HorizontalScrollbar = true;
            this.subjectTListBox.ItemHeight = 20;
            this.subjectTListBox.Location = new System.Drawing.Point(406, 35);
            this.subjectTListBox.Name = "subjectTListBox";
            this.subjectTListBox.Size = new System.Drawing.Size(250, 104);
            this.subjectTListBox.TabIndex = 19;
            this.subjectTListBox.SelectedIndexChanged += new System.EventHandler(this.subjectTListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(406, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subject Teachers";
            // 
            // teacherListBox
            // 
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.HorizontalScrollbar = true;
            this.teacherListBox.ItemHeight = 20;
            this.teacherListBox.Location = new System.Drawing.Point(13, 35);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(250, 104);
            this.teacherListBox.TabIndex = 12;
            this.teacherListBox.SelectedIndexChanged += new System.EventHandler(this.teacherListBox_SelectedIndexChanged);
            // 
            // addBtn1
            // 
            this.addBtn1.Location = new System.Drawing.Point(294, 35);
            this.addBtn1.Name = "addBtn1";
            this.addBtn1.Size = new System.Drawing.Size(81, 29);
            this.addBtn1.TabIndex = 15;
            this.addBtn1.Text = "Add";
            this.addBtn1.UseVisualStyleBackColor = true;
            this.addBtn1.Click += new System.EventHandler(this.addBtn1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "All Teachers";
            // 
            // removeBtn1
            // 
            this.removeBtn1.Location = new System.Drawing.Point(294, 80);
            this.removeBtn1.Name = "removeBtn1";
            this.removeBtn1.Size = new System.Drawing.Size(81, 32);
            this.removeBtn1.TabIndex = 16;
            this.removeBtn1.Text = "Remove Selected Subjects";
            this.removeBtn1.UseVisualStyleBackColor = true;
            this.removeBtn1.Click += new System.EventHandler(this.removeBtn1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(287, 357);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(216, 39);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(348, 409);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SubjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingLabel);
            this.Name = "SubjectDetails";
            this.Text = "SubjectDetails";
            this.Load += new System.EventHandler(this.SubjectDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectNameInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox subjectTListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.Button addBtn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeBtn1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}