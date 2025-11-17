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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        Admin_Dashboard admin_board = new Admin_Dashboard();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            string email = email_txtbox.Text;
            string password = password_txtbox.Text;

            if (string.IsNullOrWhiteSpace(email_txtbox.Text) || string.IsNullOrEmpty(password_txtbox.Text))
            {
                MessageBox.Show("Fill all fields !!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // stop further execution
            }
            else
            {

                if (!email_txtbox.Text.Contains("@"))
                {
                    MessageBox.Show("Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    con.Open();
                    string qry = @"select count(*) from admin where email=@email and password=@password";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        this.Hide();
                        MessageBox.Show("Login successful.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        admin_board.ShowDialog();
                        this.Close();
                        return;

                    }




                    string entered_pwd = PasswordHelper.HashPassword(password);

                    string stu_qry = @"select count(*) from students where email=@email and password=@password";
                    SqlCommand stu_cmd = new SqlCommand(stu_qry, con);
                    stu_cmd.Parameters.AddWithValue("@email", email);
                    stu_cmd.Parameters.AddWithValue("@password", entered_pwd);
                    int stu_count = (int)stu_cmd.ExecuteScalar();
                    if (stu_count > 0)
                    {
                        this.Hide();
                        MessageBox.Show("Login successful.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Student_dashboard stu_board = new Student_dashboard();
                        stu_board.ShowDialog();
                        this.Close();
                    }




                    string temp_qry = "SELECT Id,Password, IsTempPassword FROM Instructor WHERE email=@instructor_email";
                    SqlCommand temp_cmd = new SqlCommand(temp_qry, con);
                    temp_cmd.Parameters.AddWithValue("@instructor_email", email);


                    SqlDataReader rdr = temp_cmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        string storedHash = rdr["password"].ToString();
                        int instructorId = Convert.ToInt32(rdr["Id"]);
                        bool isTemp = Convert.ToBoolean(rdr["IsTempPassword"]);
                        rdr.Close();



                        if (storedHash == entered_pwd)
                        {
                            if (isTemp)
                            {
                                MessageBox.Show("You must change your temporary password.");
                                ChangePasswordForInstructor cpfi = new ChangePasswordForInstructor(instructorId);
                                cpfi.ShowDialog();

                            }
                            else
                            {
                                string in_qry = @"select count(*) from instructor where email=@email and password=@password";
                                SqlCommand in_cmd = new SqlCommand(in_qry, con);
                                in_cmd.Parameters.AddWithValue("@email", email);
                                in_cmd.Parameters.AddWithValue("@password", entered_pwd);
                                int in_count = (int)in_cmd.ExecuteScalar();
                                if (in_count > 0)
                                {
                                    this.Hide();
                                    MessageBox.Show("Login successful.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    Instructor_dashboard ins_board = new Instructor_dashboard();
                                    ins_board.ShowDialog();
                                    this.Close();
                                }



                               
                            }

                            con.Close();
                            return; // ✅ stop here

                        }
                    }





                    MessageBox.Show("Email and Password are incorrect!!", "⚠️ Logi Failed", MessageBoxButtons.OK);
                    password_txtbox.Text = "";

                    con.Close();
                }

            }
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void LoginForm_Leave(object sender, EventArgs e)
        {
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.Close();
            this.Close();
        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
