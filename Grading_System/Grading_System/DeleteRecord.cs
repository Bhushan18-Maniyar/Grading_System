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
    public partial class DeleteRecord : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void cencel_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();


        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DROP TABLE "+Session.UNAME+""+rname.Text+"",con);
            cmd.ExecuteNonQuery();
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();
            MessageBox.Show("Deleted", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
