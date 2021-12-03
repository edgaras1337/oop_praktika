
namespace ais
{
    partial class AddTeacher
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
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.surnameInputLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.createTeacherBtn = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tSubjectListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.subjectsListBox = new System.Windows.Forms.ListBox();
            this.addBtn1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.removeBtn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInputLabel
            // 
            this.nameInputLabel.AutoSize = true;
            this.nameInputLabel.Location = new System.Drawing.Point(102, 130);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(49, 20);
            this.nameInputLabel.TabIndex = 0;
            this.nameInputLabel.Text = "Name";
            // 
            // surnameInputLabel
            // 
            this.surnameInputLabel.AutoSize = true;
            this.surnameInputLabel.Location = new System.Drawing.Point(428, 133);
            this.surnameInputLabel.Name = "surnameInputLabel";
            this.surnameInputLabel.Size = new System.Drawing.Size(67, 20);
            this.surnameInputLabel.TabIndex = 1;
            this.surnameInputLabel.Text = "Surname";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(172, 130);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(206, 27);
            this.nameInput.TabIndex = 2;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(516, 130);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(206, 27);
            this.surnameInput.TabIndex = 3;
            this.surnameInput.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
            // 
            // createTeacherBtn
            // 
            this.createTeacherBtn.Location = new System.Drawing.Point(305, 479);
            this.createTeacherBtn.Name = "createTeacherBtn";
            this.createTeacherBtn.Size = new System.Drawing.Size(234, 42);
            this.createTeacherBtn.TabIndex = 4;
            this.createTeacherBtn.Text = "Create Account";
            this.createTeacherBtn.UseVisualStyleBackColor = true;
            this.createTeacherBtn.Click += new System.EventHandler(this.createTeacherBtn_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(516, 177);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(206, 27);
            this.passwordInput.TabIndex = 8;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(172, 180);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(206, 27);
            this.usernameInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tSubjectListBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.subjectsListBox);
            this.panel2.Controls.Add(this.addBtn1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.removeBtn1);
            this.panel2.Location = new System.Drawing.Point(111, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 142);
            this.panel2.TabIndex = 22;
            // 
            // tSubjectListBox
            // 
            this.tSubjectListBox.FormattingEnabled = true;
            this.tSubjectListBox.HorizontalScrollbar = true;
            this.tSubjectListBox.ItemHeight = 20;
            this.tSubjectListBox.Location = new System.Drawing.Point(379, 35);
            this.tSubjectListBox.Name = "tSubjectListBox";
            this.tSubjectListBox.Size = new System.Drawing.Size(250, 104);
            this.tSubjectListBox.TabIndex = 19;
            this.tSubjectListBox.SelectedIndexChanged += new System.EventHandler(this.tSubjectListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(379, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Teacher Subjects";
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
            this.addBtn1.Location = new System.Drawing.Point(281, 35);
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
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "All Subjects";
            // 
            // removeBtn1
            // 
            this.removeBtn1.Location = new System.Drawing.Point(281, 80);
            this.removeBtn1.Name = "removeBtn1";
            this.removeBtn1.Size = new System.Drawing.Size(81, 32);
            this.removeBtn1.TabIndex = 16;
            this.removeBtn1.Text = "Remove Selected Subjects";
            this.removeBtn1.UseVisualStyleBackColor = true;
            this.removeBtn1.Click += new System.EventHandler(this.removeBtn1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(124, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add Teacher Subjects:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(354, 527);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 33);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(258, 22);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(375, 46);
            this.headingLabel.TabIndex = 25;
            this.headingLabel.Text = "Create Teacher Account";
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 574);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createTeacherBtn);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.surnameInputLabel);
            this.Controls.Add(this.nameInputLabel);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Label surnameInputLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.Button createTeacherBtn;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox tSubjectListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox subjectsListBox;
        private System.Windows.Forms.Button addBtn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeBtn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label headingLabel;
    }
}