using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningMannagementSystem
{
     
    public partial class Admin_Dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void loadStudent()
        {
            con.Open();
            string qry = @"select count(*) from students";
            SqlCommand cmd = new SqlCommand(qry, con);
            int count = (int)cmd.ExecuteScalar();

            stu_count.Text = count.ToString();
            con.Close();
        }
        private void loadInstructor()
        {
            con.Open();
            string count_in = @"select count(*) from instructor";
            SqlCommand in_cmd = new SqlCommand(count_in, con);
            int inCount = (int)in_cmd.ExecuteScalar();

            in_count.Text = inCount.ToString();
            con.Close();
        }
        private void loadCourse()
        {
            con.Open();
            string count_course = @"select count(*) from courses";
            SqlCommand course_cmd = new SqlCommand(count_course, con);
            int cCount = (int)course_cmd.ExecuteScalar();

            c_count.Text = cCount.ToString();

            con.Close();

        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            loadStudent();
            loadInstructor();
            loadCourse();



            

        }

        private void Admin_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Students manage_stu_board = new Manage_Students();
            manage_stu_board.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadStudent();
            con.Open();
            string qry = @"select studentID, name, email, phno, address from students";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           DialogResult result =   MessageBox.Show("Are you sure to logout ?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           if (result == DialogResult.OK)
           {
               this.Hide();
               LoginForm login = new LoginForm();
               login.ShowDialog();
               this.Close();
           }
           else
           {
               return;
           }
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Add_new_teachers cia = new Add_new_teachers();
            cia.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Teachers inForm = new Manage_Teachers();
            inForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadInstructor();
            con.Open();
            string view_in = @"select ID, name, email, dob, phno, address, education, department from instructor";
            SqlCommand cmd = new SqlCommand(view_in, con);
            SqlDataReader rdr_1 = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr_1);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void stu_count_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Add_new_teachers accForm = new Add_new_teachers();
            accForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_new_students register_form = new Add_new_students();
            register_form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Course courseForm = new Manage_Course();
            courseForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadCourse();
            con.Open();
            string view_in = @"SELECT c.course_id, 
                         c.course_name, 
                         c.course_code, 
                         c.semester, 
                         c.credits, 
                         c.instructor_id, 
                         i.name as instructor_name,
                         i.department,
                         i.phno
                  FROM courses c
                  INNER JOIN instructor i 
                  ON c.instructor_id = i.id";
            SqlCommand cmd = new SqlCommand(view_in, con);
            SqlDataReader rdr_1 = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr_1);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
