namespace LearningMannagementSystem
{
    partial class Add_New_Course
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
            this.cmb_sem = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.instructor_id_box = new System.Windows.Forms.ComboBox();
            this.coursecode_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.credit_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cmb_sem);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.name_txtbox);
            this.panel1.Controls.Add(this.instructor_id_box);
            this.panel1.Controls.Add(this.coursecode_txtbox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.credit_txtbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.e);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 653);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmb_sem
            // 
            this.cmb_sem.FormattingEnabled = true;
            this.cmb_sem.Items.AddRange(new object[] {
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
            this.cmb_sem.Location = new System.Drawing.Point(233, 295);
            this.cmb_sem.Name = "cmb_sem";
            this.cmb_sem.Size = new System.Drawing.Size(200, 24);
            this.cmb_sem.TabIndex = 51;
            this.cmb_sem.SelectedIndexChanged += new System.EventHandler(this.cmb_sem_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(19, 568);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(214, 65);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.view_stu_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 33);
            this.label2.TabIndex = 50;
            this.label2.Text = "Add New Course";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(294, 568);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(214, 65);
            this.button6.TabIndex = 11;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // name_txtbox
            // 
            this.name_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txtbox.Location = new System.Drawing.Point(233, 166);
            this.name_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.name_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(200, 22);
            this.name_txtbox.TabIndex = 40;
            // 
            // instructor_id_box
            // 
            this.instructor_id_box.FormattingEnabled = true;
            this.instructor_id_box.Location = new System.Drawing.Point(233, 412);
            this.instructor_id_box.Name = "instructor_id_box";
            this.instructor_id_box.Size = new System.Drawing.Size(200, 24);
            this.instructor_id_box.TabIndex = 49;
            this.instructor_id_box.SelectedIndexChanged += new System.EventHandler(this.instructor_id_box_SelectedIndexChanged);
            // 
            // coursecode_txtbox
            // 
            this.coursecode_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.coursecode_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coursecode_txtbox.Location = new System.Drawing.Point(233, 227);
            this.coursecode_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.coursecode_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.coursecode_txtbox.Name = "coursecode_txtbox";
            this.coursecode_txtbox.Size = new System.Drawing.Size(200, 22);
            this.coursecode_txtbox.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Instructor";
            // 
            // credit_txtbox
            // 
            this.credit_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.credit_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.credit_txtbox.Location = new System.Drawing.Point(233, 353);
            this.credit_txtbox.MaximumSize = new System.Drawing.Size(200, 30);
            this.credit_txtbox.MinimumSize = new System.Drawing.Size(2, 30);
            this.credit_txtbox.Name = "credit_txtbox";
            this.credit_txtbox.Size = new System.Drawing.Size(200, 22);
            this.credit_txtbox.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Credits";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(78, 227);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(129, 25);
            this.e.TabIndex = 44;
            this.e.Text = "Course Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Course Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(559, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 562);
            this.dataGridView1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Product Sans Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 37);
            this.label8.TabIndex = 40;
            this.label8.Text = "ID and Instructor Name";
            // 
            // Add_New_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1177, 677);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Add_New_Course";
            this.Text = "Add_New_Course";
            this.Load += new System.EventHandler(this.Add_New_Course_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.ComboBox instructor_id_box;
        private System.Windows.Forms.TextBox coursecode_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox credit_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_sem;
        private System.Windows.Forms.Label label8;
    }
}