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
    public partial class CreateRecord : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");
        public CreateRecord()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("CREATE TABLE [" + Session.UNAME + "" + rname.Text + "] (Name varchar(20) NOT NULL,Enrollment varchar(20) NOT NULL," + sub1.Text + " int NOT NULL ," + sub2.Text + " int NOT NULL ," + sub3.Text + " int NOT NULL ," + sub4.Text + " int NOT NULL ," + sub5.Text + " int NOT NULL,Average VARCHAR(5) NOT NULL,Grade varchar(5) NOT NULL)", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Created Successfull", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
                DashBoard d = new DashBoard();
                this.Hide();
                d.Show();
                
            }
            catch { }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();
        }

        
    }
}
