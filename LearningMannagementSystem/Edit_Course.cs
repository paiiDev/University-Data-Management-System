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
    public partial class Edit_Course : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Edit_Course()
        {
            InitializeComponent();
        }

        private void Edit_Course_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {

            cmb_course_id.Items.Clear();
            instructor_id_box.Items.Clear();
            con.Open();

            
            string qry = @"select course_id from courses";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmb_course_id.Items.Add(rdr["course_id"]);

            }
            rdr.Close();

            string view_c = @"
SELECT c.course_id, 
       c.course_name, 
       c.course_code, 
       c.semester, 
       c.credits, 
       i.id as instructor_id,   -- ✅ take from instructor table
       i.name as instructor_name,
       i.department,
       i.phno
FROM courses c
RIGHT JOIN instructor i 
ON c.instructor_id = i.id

UNION

SELECT c.course_id, 
       c.course_name, 
       c.course_code, 
       c.semester, 
       c.credits, 
       i.id as instructor_id,   -- ✅ here also
       i.name as instructor_name,
       i.department,
       i.phno
FROM courses c
LEFT JOIN instructor i 
ON c.instructor_id = i.id";



            SqlCommand cmd4 = new SqlCommand(view_c, con);
            SqlDataReader rdr_1 = cmd4.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr_1);
            dataGridView1.DataSource = table;


            
            string id_qry = @"Select id from instructor";
            SqlCommand cmd2 = new SqlCommand(id_qry, con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())
            {
                instructor_id_box.Items.Add(rdr2["ID"]);

            }

            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmb_course_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string qry = @"select course_name, course_code, semester, credits, instructor_id from courses where course_id = @p1";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@p1", cmb_course_id.SelectedItem);

            SqlDataReader rdr3 = cmd.ExecuteReader();
            if (rdr3.Read())
            {
                course_name.Text = rdr3["course_name"].ToString();
                course_code.Text = rdr3["course_code"].ToString();
                cmb_semester.SelectedItem = rdr3["semester"].ToString();
                credits.Text = rdr3["credits"].ToString();
                instructor_id_box.Text = rdr3["instructor_id"].ToString();
            }
            rdr3.Close();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cmb_course_id.SelectedItem == null)
            {
                MessageBox.Show("Please select an ID first.", "Cannot delete data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = cmb_course_id.SelectedItem.ToString();



            con.Open();
            string delete_qry = @"delete from courses where course_id=@id";
            SqlCommand delete_cmd = new SqlCommand(delete_qry, con);
            delete_cmd.Parameters.AddWithValue("@id", id);
            delete_cmd.ExecuteNonQuery();

            MessageBox.Show("Data deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();
            loadData();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (cmb_course_id.SelectedItem == null)
            {
                MessageBox.Show("Please select ID first.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = cmb_course_id.SelectedItem.ToString();
            string name = course_name.Text;
            string c_code = course_code.Text;
            string semester = cmb_semester.SelectedItem.ToString();
            string cred = credits.Text;
            string instructor_id = instructor_id_box.SelectedItem.ToString();


            con.Open();
            string upt_qry = @"update courses set course_name=@name, course_code=@c_code, semester=@semester, credits=@cred, instructor_id=@instructor_id where course_id=@id";
            SqlCommand upt_cmd = new SqlCommand(upt_qry, con);
            upt_cmd.Parameters.AddWithValue("@name", name);
            upt_cmd.Parameters.AddWithValue("@c_code", c_code);
            upt_cmd.Parameters.AddWithValue("@semester", semester);
            upt_cmd.Parameters.AddWithValue("@cred", cred);
            upt_cmd.Parameters.AddWithValue("@instructor_id", instructor_id);
            upt_cmd.Parameters.AddWithValue("@id", id);
            upt_cmd.ExecuteNonQuery();

            MessageBox.Show("Data updated successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            con.Close();
          
            loadData();

            course_name.Text = "";
            course_code.Text = "";
            credits.Text = "";

            cmb_course_id.SelectedIndex = -1;
            cmb_semester.SelectedIndex = -1;
            instructor_id_box.SelectedIndex = -1;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instructor_id_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
