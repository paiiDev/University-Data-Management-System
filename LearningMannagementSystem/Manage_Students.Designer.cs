namespace LearningMannagementSystem
{
    partial class Manage_Students
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.student_id_box = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(517, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Product Sans Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(279, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(518, 37);
            this.label8.TabIndex = 40;
            this.label8.Text = "University Data Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Student Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(517, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 538);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Moccasin;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_btn.Location = new System.Drawing.Point(349, 16);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(139, 58);
            this.cancel_btn.TabIndex = 37;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(22, 16);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(139, 58);
            this.update_btn.TabIndex = 36;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(128, 321);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(58, 25);
            this.e.TabIndex = 30;
            this.e.Text = "Email";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(208, 373);
            this.dob.MaximumSize = new System.Drawing.Size(200, 50);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 22);
            this.dob.TabIndex = 29;
            // 
            // address_txtbox
            // 
            this.address_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.address_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_txtbox.Location = new System.Drawing.Point(208, 490);
            this.address_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.address_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(200, 22);
            this.address_txtbox.TabIndex = 28;
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phone_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_txtbox.Location = new System.Drawing.Point(208, 428);
            this.phone_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.phone_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(200, 22);
            this.phone_txtbox.TabIndex = 27;
            // 
            // email_txtbox
            // 
            this.email_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.email_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txtbox.Location = new System.Drawing.Point(208, 316);
            this.email_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.email_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(200, 22);
            this.email_txtbox.TabIndex = 25;
            this.email_txtbox.TextChanged += new System.EventHandler(this.email_txtbox_TextChanged);
            // 
            // name_txtbox
            // 
            this.name_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txtbox.Location = new System.Drawing.Point(208, 255);
            this.name_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.name_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(200, 22);
            this.name_txtbox.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Select student ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // student_id_box
            // 
            this.student_id_box.FormattingEnabled = true;
            this.student_id_box.Location = new System.Drawing.Point(208, 198);
            this.student_id_box.Name = "student_id_box";
            this.student_id_box.Size = new System.Drawing.Size(200, 24);
            this.student_id_box.TabIndex = 39;
            this.student_id_box.SelectedIndexChanged += new System.EventHandler(this.student_id_box_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.name_txtbox);
            this.panel2.Controls.Add(this.student_id_box);
            this.panel2.Controls.Add(this.email_txtbox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.phone_txtbox);
            this.panel2.Controls.Add(this.address_txtbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dob);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.e);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 619);
            this.panel2.TabIndex = 40;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_btn.Location = new System.Drawing.Point(186, 16);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(139, 58);
            this.delete_btn.TabIndex = 41;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.cancel_btn);
            this.panel3.Controls.Add(this.delete_btn);
            this.panel3.Controls.Add(this.update_btn);
            this.panel3.Location = new System.Drawing.Point(0, 626);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 94);
            this.panel3.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(517, 626);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1049, 94);
            this.panel4.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Product Sans", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 36);
            this.label9.TabIndex = 40;
            this.label9.Text = "All student data";
            // 
            // Manage_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 721);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(2000, 768);
            this.Name = "Manage_Students";
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox student_id_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
    }
}