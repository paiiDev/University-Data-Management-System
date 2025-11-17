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
    public partial class Manage_Course : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Manage_Course()
        {
            InitializeComponent();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Edit_Course editForm = new Edit_Course();
            editForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Course newcourseForm = new Add_New_Course();
            newcourseForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manage_Course_Load(object sender, EventArgs e)
        {

            con.Open();
            string view_c = @"SELECT c.course_id, 
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

            SqlCommand cmd4 = new SqlCommand(view_c, con);
            SqlDataReader rdr_1 = cmd4.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr_1);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string view_c = @"SELECT c.course_id, 
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

            SqlCommand cmd4 = new SqlCommand(view_c, con);
            SqlDataReader rdr_1 = cmd4.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr_1);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
