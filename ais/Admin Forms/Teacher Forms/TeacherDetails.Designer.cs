
namespace ais
{
    partial class TeacherDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.subjectsListBox = new System.Windows.Forms.ListBox();
            this.addBtn1 = new System.Windows.Forms.Button();
            this.removeBtn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tSubjectListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(21, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(98, 46);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "Hello";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(109, 0);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(218, 27);
            this.nameInput.TabIndex = 6;
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(479, 4);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(218, 27);
            this.surnameInput.TabIndex = 7;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(109, 59);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(218, 27);
            this.usernameInput.TabIndex = 8;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(479, 55);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(218, 27);
            this.passwordInput.TabIndex = 9;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(3, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(248, 37);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(59, 56);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 29);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.HorizontalScrollbar = true;
            this.subjectsListBox.ItemHeight = 20;
            this.subjectsListBox.Location = new System.Drawing.Point(13, 35);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.Size = new System.Drawing.Size(250, 104);
            this.subjectsListBox.TabIndex = 12;
            this.subjectsListBox.SelectedIndexChanged += new System.EventHandler(this.subjectsListBox_SelectedIndexChanged);
            // 
            // addBtn1
            // 
            this.addBtn1.Location = new System.Drawing.Point(296, 35);
            this.addBtn1.Name = "addBtn1";
            this.addBtn1.Size = new System.Drawing.Size(81, 29);
            this.addBtn1.TabIndex = 15;
            this.addBtn1.Text = "Add";
            this.addBtn1.UseVisualStyleBackColor = true;
            this.addBtn1.Click += new System.EventHandler(this.addBtn1_Click);
            // 
            // removeBtn1
            // 
            this.removeBtn1.Location = new System.Drawing.Point(296, 80);
            this.removeBtn1.Name = "removeBtn1";
            this.removeBtn1.Size = new System.Drawing.Size(81, 32);
            this.removeBtn1.TabIndex = 16;
            this.removeBtn1.Text = "Remove Selected Subjects";
            this.removeBtn1.UseVisualStyleBackColor = true;
            this.removeBtn1.Click += new System.EventHandler(this.removeBtn1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Location = new System.Drawing.Point(376, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 103);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "All Subjects";
            // 
            // tSubjectListBox
            // 
            this.tSubjectListBox.FormattingEnabled = true;
            this.tSubjectListBox.HorizontalScrollbar = true;
            this.tSubjectListBox.ItemHeight = 20;
            this.tSubjectListBox.Location = new System.Drawing.Point(410, 35);
            this.tSubjectListBox.Name = "tSubjectListBox";
            this.tSubjectListBox.Size = new System.Drawing.Size(250, 104);
            this.tSubjectListBox.TabIndex = 19;
            this.tSubjectListBox.SelectedIndexChanged += new System.EventHandler(this.tSubjectListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(410, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Teacher Subjects";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tSubjectListBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.subjectsListBox);
            this.panel2.Controls.Add(this.addBtn1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.removeBtn1);
            this.panel2.Location = new System.Drawing.Point(173, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 142);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.nameInput);
            this.panel3.Controls.Add(this.surnameInput);
            this.panel3.Controls.Add(this.usernameInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.passwordInput);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(136, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 105);
            this.panel3.TabIndex = 23;
            // 
            // TeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headingLabel);
            this.Name = "TeacherDetails";
            this.Text = "TeacherDetails";
            this.Load += new System.EventHandler(this.TeacherDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox subjectsListBox;
        private System.Windows.Forms.Button addBtn1;
        private System.Windows.Forms.Button removeBtn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox tSubjectListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}