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
    public partial class Add_New_Course : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Add_New_Course()
        {
            InitializeComponent();
        }

        private void cmb_sem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_Course_Load(object sender, EventArgs e)
        {
            con.Open();
            string id_qry = @"Select id from instructor";
            SqlCommand cmd = new SqlCommand(id_qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                instructor_id_box.Items.Add(rdr["ID"]);

            }
            rdr.Close();

            string view_c = @"SELECT id, name, department from instructor";

            SqlCommand cmd4 = new SqlCommand(view_c, con);
            SqlDataReader rdr_1 = cmd4.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr_1);
            dataGridView1.DataSource = table;
           
            con.Close();
        }

        private void instructor_id_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_stu_btn_Click(object sender, EventArgs e)
        {
            string course_name = name_txtbox.Text;
            string cousre_code = coursecode_txtbox.Text;
            string semester = cmb_sem.SelectedItem.ToString();
            string credits = credit_txtbox.Text;
            string instructor_id = instructor_id_box.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(course_name))
            {
                MessageBox.Show("Fill all fields !!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // stop further execution
            }
            else
            {
                con.Open();


              
             
                    string insert_qry = @"insert into courses (course_name, course_code, semester, credits, instructor_id) values (@c_name, @c_code, @sem, @cred, @inst_id)";
                    SqlCommand cmd3 = new SqlCommand(insert_qry, con);
                    cmd3.Parameters.AddWithValue("@c_name", course_name);
                    cmd3.Parameters.AddWithValue("@c_code", cousre_code);
                    cmd3.Parameters.AddWithValue("@sem", semester);
                    cmd3.Parameters.AddWithValue("@cred", credits);
                    cmd3.Parameters.AddWithValue("@inst_id", instructor_id);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Cousre added successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                
               
            }

          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
