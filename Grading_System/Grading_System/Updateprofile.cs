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
    public partial class Updateprofile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");

        public Updateprofile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();

        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [User] SET UserName = '"+uname.Text+"', password = '"+pass.Text+"', [Class Name] = '"+classname.Text+"', Email = '"+email.Text+"'WHERE  (UserName = '"+Session.UNAME+"')", con);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                DashBoard d = new DashBoard();
                this.Hide();
                d.Show();
                MessageBox.Show("Updated Successfully !!!", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                DashBoard d = new DashBoard();
                this.Hide();
                d.Show();
                MessageBox.Show("there is some problem occur in updation...!", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            con.Close();
        }
    }
}
