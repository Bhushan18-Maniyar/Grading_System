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
    public partial class DeleteStudentRecord : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");
        string tname;
        public DeleteStudentRecord()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.tables", con);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    if ((string)r["name"] != "User")
                    {
                        recordname.Items.Add((string)r["name"]);
                    }
                }
                con.Close();
            }
            catch { }

        }

        private void recordname_SelectedIndexChanged(object sender, EventArgs e)
        {
            tname = recordname.SelectedItem.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [" + tname + "] WHERE Enrollment='" + enroll.Text + "'", con);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Student data deleted...", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("No data found..!!!", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch { }
        }
    }
}
