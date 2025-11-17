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
    public partial class Manage_Teachers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Manage_Teachers()
        {
            InitializeComponent();
        }
        private void loadInstructor()
        {
            instructor_id_box.Items.Clear();
            con.Open();
            string qry = @"select ID from instructor";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                instructor_id_box.Items.Add(rdr["ID"]);

            }
            rdr.Close();

            string all_data = @"select id,name,email, dob,phno, address, education, department, lastModified, role from instructor";
            SqlCommand cmd2 = new SqlCommand(all_data, con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr2);
            dataGridView1.DataSource = table;
            rdr2.Close();
            con.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            if (instructor_id_box.SelectedItem == null)
            {
                MessageBox.Show("Please select a ID first.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
         
                string id = instructor_id_box.SelectedItem.ToString();
                string name = name_txtbox.Text;
                string email = email_txtbox.Text;
                DateTime d = dob.Value;
                string phone = phone_txtbox.Text;
                string address = address_txtbox.Text;
                string edu = edu_txtbox.Text;
                string department = cmb_department.SelectedItem.ToString();
                string role = role_cmb.SelectedItem.ToString();


                con.Open();
                string upt_qry = @"update instructor set name=@name, email=@email, dob=@d, phno=@phone, address=@address , education=@edu, department=@dep, lastModified=@lastModified , role=@role where ID=@id";
                SqlCommand upt_cmd = new SqlCommand(upt_qry, con);
                upt_cmd.Parameters.AddWithValue("@name", name);
                upt_cmd.Parameters.AddWithValue("@email", email);
                upt_cmd.Parameters.AddWithValue("@d", d);
                upt_cmd.Parameters.AddWithValue("@phone", phone);
                upt_cmd.Parameters.AddWithValue("@address", address);
                upt_cmd.Parameters.AddWithValue("@lastModified", DateTime.Now);
                upt_cmd.Parameters.AddWithValue("@id", id);
                upt_cmd.Parameters.AddWithValue("@edu", edu);
                upt_cmd.Parameters.AddWithValue("@dep", department);
                upt_cmd.Parameters.AddWithValue("@role", role);

                upt_cmd.ExecuteNonQuery();

                MessageBox.Show("Data updated successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                con.Close();
                loadInstructor();
            

           
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manage_Instructor_Load(object sender, EventArgs e)
        {
            loadInstructor();
        }

        private void instructor_id_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string qry = @"select Name, email, dob, phno, address, education, department, role from instructor where ID = @p1";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@p1", instructor_id_box.SelectedItem);

            SqlDataReader rdr3 = cmd.ExecuteReader();
            if (rdr3.Read())
            {
                name_txtbox.Text = rdr3["Name"].ToString();
                email_txtbox.Text = rdr3["email"].ToString();
                dob.Text = rdr3["dob"].ToString();
                phone_txtbox.Text = rdr3["phno"].ToString();
                address_txtbox.Text = rdr3["address"].ToString();
                edu_txtbox.Text = rdr3["education"].ToString();
                cmb_department.Text = (rdr3["department"]).ToString();
                role_cmb.Text = (rdr3["role"]).ToString();

                
            }
            rdr3.Close();
            con.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (instructor_id_box.SelectedItem == null)
            {
                MessageBox.Show("Please select an ID first.", "Cannot delete data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = instructor_id_box.SelectedItem.ToString();



            con.Open();
            string delete_qry = @"delete from instructor where id=@id";
            SqlCommand delete_cmd = new SqlCommand(delete_qry, con);
            delete_cmd.Parameters.AddWithValue("@id", id);
            delete_cmd.ExecuteNonQuery();

            MessageBox.Show("Data deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();
            loadInstructor();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
