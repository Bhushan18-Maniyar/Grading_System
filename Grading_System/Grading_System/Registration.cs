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
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");

        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*INSERT INTO [User]
                  (UserName, password, [Class Name], Email)
VALUES ('BBM', 'abcdef', 'EC2', 'abc@gmail.com')
             */
            try
            {
                int count = 0;
                con.Open();
                SqlCommand cmd = new
                    SqlCommand("INSERT INTO [User] (UserName, password, [Class Name], Email) VALUES ('"+ username.Text +"', '"+ pass.Text +"', '"+ classname.Text +"', '"+ email.Text +"')", con);
                
                DataTable dt = new DataTable();
                //cmd.Fill(dt);
                count = cmd.ExecuteNonQuery();
                if (count>0)
                {

                    username.Text = "";
                    pass.Text = "";
                    email.Text = "";
                    classname.Text = "";
                    MessageBox.Show("Register Successfull", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Login l = new Login();
                    this.Hide();
                    l.Show();

                }
                else
                {
                    username.Text = "";
                    pass.Text = "";
                    email.Text = "";
                    classname.Text = "";
                    MessageBox.Show("Registration error occur ", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Hide();
                    //show after login page

                }
            }
            catch { }
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void classname_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Login l = new Login();
            this.Hide();
            l.Show();
        }
    }
}
