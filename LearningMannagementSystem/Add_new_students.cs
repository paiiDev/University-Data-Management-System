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
    public partial class Add_new_students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PAII\Documents\LMSDB.mdf");
        public Add_new_students()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   

        private void reg_submit_Click(object sender, EventArgs e)
        {
            string name = name_txtbox.Text;
            string email = email_txtbox.Text;
            string pwd = PasswordHelper.HashPassword("stud@nt");
            DateTime d = dob.Value;
            string phone = phone_txtbox.Text;
            string address = address_txtbox.Text;

         


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
                    con.Open();
                    string qry = @"insert into students (name, email, password, dob, phno,address) values (@name, @email, @pwd, @d, @phone,  @address)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    cmd.Parameters.AddWithValue("@d", d);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    MessageBox.Show("New student added successfully!.", "Alert", MessageBoxButtons.OK);

                }

               
            }
                 

  
           

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
          
           
         
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void phone_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void e_Click(object sender, EventArgs e)
        {

        }
    }
}
