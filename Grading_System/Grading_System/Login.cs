using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grading_System
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");
        public Login()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            this.Hide();
            rg.Show();
            //this.Close();

        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                SqlDataAdapter cmd = new
                    SqlDataAdapter("Select count (*) FROM [User] WHERE UserName='" + username.Text + "'and password='" + password.Text + "'", con);
                //count = Convert.ToInt32(cmd.ExecuteScalar());
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Session.UNAME = username.Text;
                    username.Text = "";
                    password.Text = "";
                    MessageBox.Show("Login Successfull", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                    //show after login page
                    DashBoard d = new DashBoard();
                    this.Hide();
                    d.Show();



                }
                else
                {
                    username.Text = "";
                    password.Text = "";
                    con.Close();
                    MessageBox.Show("Login Failed", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error) 
            {
                Console.WriteLine(error.Message); 
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            About b = new About();
            this.Hide();
            b.Show();
        }
    }
}
