namespace LearningMannagementSystem
{
    partial class ChangePasswordForInstructor
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
            this.label8 = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.new_pwd = new System.Windows.Forms.Label();
            this.current_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Product Sans Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 37);
            this.label8.TabIndex = 40;
            this.label8.Text = "Change Password";
            // 
            // password_txtbox
            // 
            this.password_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txtbox.Location = new System.Drawing.Point(304, 200);
            this.password_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.password_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = 'x';
            this.password_txtbox.Size = new System.Drawing.Size(200, 30);
            this.password_txtbox.TabIndex = 42;
            // 
            // new_pwd
            // 
            this.new_pwd.AutoSize = true;
            this.new_pwd.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pwd.Location = new System.Drawing.Point(92, 200);
            this.new_pwd.Name = "new_pwd";
            this.new_pwd.Size = new System.Drawing.Size(174, 30);
            this.new_pwd.TabIndex = 41;
            this.new_pwd.Text = "New Password";
            // 
            // current_pwd
            // 
            this.current_pwd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.current_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_pwd.Location = new System.Drawing.Point(304, 142);
            this.current_pwd.MaximumSize = new System.Drawing.Size(200, 30);
            this.current_pwd.MinimumSize = new System.Drawing.Size(2, 30);
            this.current_pwd.Name = "current_pwd";
            this.current_pwd.PasswordChar = 'x';
            this.current_pwd.Size = new System.Drawing.Size(200, 30);
            this.current_pwd.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "Current Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(198, 320);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(190, 55);
            this.login_btn.TabIndex = 45;
            this.login_btn.Text = "Submit";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.current_pwd);
            this.panel1.Controls.Add(this.new_pwd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.password_txtbox);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 384);
            this.panel1.TabIndex = 46;
            // 
            // ChangePasswordForInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 442);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePasswordForInstructor";
            this.Text = "ChangePasswordForInstructor";
            this.Load += new System.EventHandler(this.ChangePasswordForInstructor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label new_pwd;
        private System.Windows.Forms.TextBox current_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel panel1;

    }
}