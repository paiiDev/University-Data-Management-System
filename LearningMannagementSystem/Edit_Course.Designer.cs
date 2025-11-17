namespace LearningMannagementSystem
{
    partial class Edit_Course
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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_course_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_semester = new System.Windows.Forms.ComboBox();
            this.course_name = new System.Windows.Forms.TextBox();
            this.instructor_id_box = new System.Windows.Forms.ComboBox();
            this.course_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 33);
            this.label2.TabIndex = 50;
            this.label2.Text = "Edit Course";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Product Sans Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(950, 596);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 37);
            this.label8.TabIndex = 64;
            this.label8.Text = "All Data";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(546, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 565);
            this.dataGridView1.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cmb_course_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_semester);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.course_name);
            this.panel1.Controls.Add(this.instructor_id_box);
            this.panel1.Controls.Add(this.course_code);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.credits);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 565);
            this.panel1.TabIndex = 62;
            // 
            // cmb_course_id
            // 
            this.cmb_course_id.FormattingEnabled = true;
            this.cmb_course_id.Items.AddRange(new object[] {
            "Semester I",
            "Semester II",
            "Semester III",
            "Semester IV",
            "Semester V",
            "Semester VI",
            "Semester VII",
            "Semester VIII",
            "Semester IX",
            "Semester X"});
            this.cmb_course_id.Location = new System.Drawing.Point(239, 168);
            this.cmb_course_id.Name = "cmb_course_id";
            this.cmb_course_id.Size = new System.Drawing.Size(200, 24);
            this.cmb_course_id.TabIndex = 53;
            this.cmb_course_id.SelectedIndexChanged += new System.EventHandler(this.cmb_course_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Course ID";
            // 
            // cmb_semester
            // 
            this.cmb_semester.FormattingEnabled = true;
            this.cmb_semester.Items.AddRange(new object[] {
            "Semester I",
            "Semester II",
            "Semester III",
            "Semester IV",
            "Semester V",
            "Semester VI",
            "Semester VII",
            "Semester VIII",
            "Semester IX",
            "Semester X"});
            this.cmb_semester.Location = new System.Drawing.Point(239, 344);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.Size = new System.Drawing.Size(200, 24);
            this.cmb_semester.TabIndex = 51;
            // 
            // course_name
            // 
            this.course_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.course_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.course_name.Location = new System.Drawing.Point(239, 215);
            this.course_name.MaximumSize = new System.Drawing.Size(200, 30);
            this.course_name.MinimumSize = new System.Drawing.Size(2, 30);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(200, 22);
            this.course_name.TabIndex = 40;
            // 
            // instructor_id_box
            // 
            this.instructor_id_box.FormattingEnabled = true;
            this.instructor_id_box.Location = new System.Drawing.Point(239, 461);
            this.instructor_id_box.Name = "instructor_id_box";
            this.instructor_id_box.Size = new System.Drawing.Size(200, 24);
            this.instructor_id_box.TabIndex = 49;
            this.instructor_id_box.SelectedIndexChanged += new System.EventHandler(this.instructor_id_box_SelectedIndexChanged);
            // 
            // course_code
            // 
            this.course_code.BackColor = System.Drawing.SystemColors.HighlightText;
            this.course_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.course_code.Location = new System.Drawing.Point(239, 276);
            this.course_code.MaximumSize = new System.Drawing.Size(200, 30);
            this.course_code.MinimumSize = new System.Drawing.Size(2, 30);
            this.course_code.Name = "course_code";
            this.course_code.Size = new System.Drawing.Size(200, 22);
            this.course_code.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Teacher";
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.SystemColors.HighlightText;
            this.credits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.credits.Location = new System.Drawing.Point(239, 402);
            this.credits.MaximumSize = new System.Drawing.Size(200, 30);
            this.credits.MinimumSize = new System.Drawing.Size(2, 30);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(200, 22);
            this.credits.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Credits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Course Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 46;
            this.label10.Text = "Semester";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(81, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "Course Name";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(194, 597);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 60);
            this.button6.TabIndex = 11;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(14, 596);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(162, 60);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Update";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Moccasin;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_btn.Location = new System.Drawing.Point(373, 598);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(151, 58);
            this.cancel_btn.TabIndex = 65;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(546, 579);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(980, 77);
            this.dataGridView2.TabIndex = 66;
            // 
            // Edit_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 668);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Edit_Course";
            this.Text = "Edit_Course";
            this.Load += new System.EventHandler(this.Edit_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_course_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_semester;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox course_name;
        private System.Windows.Forms.ComboBox instructor_id_box;
        private System.Windows.Forms.TextBox course_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox credits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DataGridView dataGridView2;

    }
}