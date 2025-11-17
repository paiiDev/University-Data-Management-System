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
    public partial class Manage_Students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Manage_Students()
        {
            InitializeComponent();
        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void loadStudents()
        {
            student_id_box.Items.Clear();
            con.Open();
            string qry = @"select studentID from students";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                student_id_box.Items.Add(rdr["StudentID"]);

            }
            rdr.Close();

            string all_data = @"select studentID,name,email, dob,phno, address, lastModified from students";
            SqlCommand cmd2 = new SqlCommand(all_data, con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr2);
            dataGridView1.DataSource = table;
            rdr2.Close();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void student_id_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string qry = @"select Name, email, dob, phno, address from students where StudentID = @p1";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@p1", student_id_box.SelectedItem);

            SqlDataReader rdr3 = cmd.ExecuteReader();
            if (rdr3.Read())
            {
                name_txtbox.Text = rdr3["Name"].ToString();
                email_txtbox.Text = rdr3["email"].ToString();
                dob.Text = rdr3["dob"].ToString();
                phone_txtbox.Text = rdr3["phno"].ToString();
                address_txtbox.Text = rdr3["address"].ToString();
            }
            rdr3.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
            
           
       

        private void update_btn_Click(object sender, EventArgs e)
        {

            if (student_id_box.SelectedItem == null)
            {
                MessageBox.Show("Please select ID first.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string  id = student_id_box.SelectedItem.ToString();
            string  name = name_txtbox.Text;
            string email = email_txtbox.Text;
            DateTime  d = dob.Value;
            string phone = phone_txtbox.Text;
            string address = address_txtbox.Text;


            con.Open();
            string upt_qry = @"update students set name=@name, email=@email, dob=@d, phno=@phone, address=@address , lastModified=@lastModified where studentID=@id";
            SqlCommand upt_cmd = new SqlCommand(upt_qry, con);
            upt_cmd.Parameters.AddWithValue("@name", name);
            upt_cmd.Parameters.AddWithValue("@email", email);
            upt_cmd.Parameters.AddWithValue("@d", d);
            upt_cmd.Parameters.AddWithValue("@phone", phone);
            upt_cmd.Parameters.AddWithValue("@address", address);
            upt_cmd.Parameters.AddWithValue("@lastModified", DateTime.Now);
            upt_cmd.Parameters.AddWithValue("@id", id);
            upt_cmd.ExecuteNonQuery();

            MessageBox.Show("Data updated successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            con.Close();
            loadStudents();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {


            if (student_id_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an ID first.", "Cannot delete data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = student_id_box.SelectedItem.ToString();
            


            con.Open();
            string delete_qry = @"delete from students where studentID=@id";
            SqlCommand delete_cmd = new SqlCommand(delete_qry, con);
            delete_cmd.Parameters.AddWithValue("@id", id);
            delete_cmd.ExecuteNonQuery();

            MessageBox.Show("Data deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();
            loadStudents();
           
            
           
        }
    }
}
