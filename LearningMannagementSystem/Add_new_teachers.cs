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
    public partial class Add_new_teachers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Add_new_teachers()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_instructor_acc_Load(object sender, EventArgs e)
        {

        }

        private void reg_submit_Click(object sender, EventArgs e)
        {
          


            
            if (string.IsNullOrWhiteSpace(email_txtbox.Text))
        {
            MessageBox.Show("Fill all fields !!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             return; // stop further execution
        } else {

            if (!email_txtbox.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                  string name = username_txtbox.Text;
            string email = email_txtbox.Text;
           
            DateTime d = dob.Value;
            string phone = phone_txtbox.Text;
            string address = address_txtbox.Text;
            string education = education_box.Text;
            string department = cmb_department.SelectedItem.ToString();

          

            string temp_pwd = "instruct0r";
            string hashedPassword = PasswordHelper.HashPassword(temp_pwd);
                string role = role_box.SelectedItem.ToString();
                 con.Open();
            string qry = @"INSERT INTO Instructor (name, Email, Password, Role, IsTempPassword, Education, Department, Phno, Address, dob) 
               VALUES (@username, @email, @pass, 'Instructor', 1, @edu, @exp, @ph, @address, @dob)";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@username", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", hashedPassword);
            cmd.Parameters.AddWithValue("@edu", education);
            cmd.Parameters.AddWithValue("@exp", department);
            cmd.Parameters.AddWithValue("@ph", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dob", d);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Account created successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            con.Close();
            username_txtbox.Text = "";
             email_txtbox.Text ="";

            phone_txtbox.Text = "";
          address_txtbox.Text = "";
           education_box.Text = "";
           
            }
                }
           
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
