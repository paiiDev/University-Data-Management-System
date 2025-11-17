namespace LearningMannagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Product Sans Black", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 328);
            this.label1.TabIndex = 0;
            this.label1.Text = "University Data \r\nManagement\r\nSystem\r\n(UDMS)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(776, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(63, 140);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(73, 30);
            this.e.TabIndex = 2;
            this.e.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(142, 303);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(190, 55);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.password_txtbox);
            this.panel1.Controls.Add(this.email_txtbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.e);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(779, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 394);
            this.panel1.TabIndex = 9;
            // 
            // password_txtbox
            // 
            this.password_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txtbox.Location = new System.Drawing.Point(221, 217);
            this.password_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.password_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = 'x';
            this.password_txtbox.Size = new System.Drawing.Size(200, 22);
            this.password_txtbox.TabIndex = 8;
            // 
            // email_txtbox
            // 
            this.email_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.email_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtbox.Location = new System.Drawing.Point(221, 140);
            this.email_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.email_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(200, 22);
            this.email_txtbox.TabIndex = 7;
            this.email_txtbox.TextChanged += new System.EventHandler(this.email_txtbox_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1400, 768);
            this.Name = "LoginForm";
            this.Text = "UDMS Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Click += new System.EventHandler(this.LoginForm_Leave);
            this.Leave += new System.EventHandler(this.LoginForm_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;

    }
}

