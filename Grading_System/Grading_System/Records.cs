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
    public partial class Records : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");
        public Records()
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
            try
            {

                con.Open();
                string tname = recordname.SelectedItem.ToString();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM [" + tname + "]",con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt; ;
                con.Close();
                
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();
        }
    }
}
