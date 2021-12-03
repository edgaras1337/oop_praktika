
namespace ais
{
    partial class AddGroup
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addSubjectBtn = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(189, 23);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(211, 46);
            this.headingLabel.TabIndex = 9;
            this.headingLabel.Text = "Add a Group";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(238, 214);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addSubjectBtn
            // 
            this.addSubjectBtn.Location = new System.Drawing.Point(176, 173);
            this.addSubjectBtn.Name = "addSubjectBtn";
            this.addSubjectBtn.Size = new System.Drawing.Size(240, 35);
            this.addSubjectBtn.TabIndex = 14;
            this.addSubjectBtn.Text = "Add Group";
            this.addSubjectBtn.UseVisualStyleBackColor = true;
            this.addSubjectBtn.Click += new System.EventHandler(this.addSubjectBtn_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(189, 103);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(264, 27);
            this.nameInput.TabIndex = 13;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(86, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 20);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Group Name";
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 272);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addSubjectBtn);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.headingLabel);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addSubjectBtn;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
    }
}