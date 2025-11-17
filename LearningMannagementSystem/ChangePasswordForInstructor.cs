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
    public partial class ChangePasswordForInstructor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        private int userid;
        private string id;
        public ChangePasswordForInstructor(int id)
        {
           
            InitializeComponent();
            userid = id;
        }

        public ChangePasswordForInstructor(string id)
        {
            // TODO: Complete member initialization
            this.id = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ChangePasswordForInstructor_Load(object sender, EventArgs e)
        {
          
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            

            string currentPwd = current_pwd.Text;
            string newPwd = password_txtbox.Text;

            string hashedCurrent = PasswordHelper.HashPassword(currentPwd);
            string hashedNew = PasswordHelper.HashPassword(newPwd);

             if (string.IsNullOrWhiteSpace(currentPwd) || string.IsNullOrEmpty(newPwd))
        {
            MessageBox.Show("Fill all fields !!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             return; // stop further execution
        } else 

            {
                con.Open();
            string fetch_pwd = @"select password from instructor where password=@password";
            SqlCommand cmd = new SqlCommand(fetch_pwd, con);
            cmd.Parameters.AddWithValue("@password", hashedCurrent);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string storedHash = rdr["password"].ToString();
                rdr.Close();
                if (storedHash != hashedCurrent)
                {
                    MessageBox.Show("Current password does not correct", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                 
                }
                    
                else
                {
                    if (new_pwd.Text.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Stop further execution
                    }
                    else
                    {
                       
                        string upt = @"update instructor set password=@newpwd, IsTempPassword=0, LastModified=@lastModified where id=@userid";
                        SqlCommand upt_cmd = new SqlCommand(upt, con);
                        upt_cmd.Parameters.AddWithValue("@lastModified", DateTime.Now);
                        upt_cmd.Parameters.AddWithValue("@userid", userid);
                        upt_cmd.Parameters.AddWithValue("@newpwd", hashedNew);
                        upt_cmd.ExecuteNonQuery();

                        MessageBox.Show("Password updated successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();
                        LoginForm login = new LoginForm();
                        login.Show();

                    }
                    
                  
                }

            }

         
            }

        }
    }
}
