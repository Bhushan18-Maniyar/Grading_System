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
    public partial class DashBoard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");
        
        public DashBoard()
        {
            
            InitializeComponent();
        }

        private void classname_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void uname_Click(object sender, EventArgs e)
        {

        }

        private void updateprofile_Click(object sender, EventArgs e)
        {
            Updateprofile u = new Updateprofile();
            this.Hide();
            u.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            con.Open();
            uname.Text = Session.UNAME;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Username='"+Session.UNAME+"'",con);
            SqlDataReader s = cmd.ExecuteReader();
            while(s.Read())
            {
                uname.Text = s["UserName"].ToString();
                email.Text = s["Email"].ToString();
                classname.Text = s["Class Name"].ToString();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateRecord r = new CreateRecord();
            this.Hide();
            r.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteRecord d = new DeleteRecord();
            this.Hide();
            d.Show();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            InsertRecord r = new InsertRecord();
            this.Hide();
            r.Show();

        }

        private void shoeRecord_Click(object sender, EventArgs e)
        {

        }

        private void updateRecord_Click(object sender, EventArgs e)
        {
            UpdateStudentRecord s = new UpdateStudentRecord();
            this.Hide();
            s.Show();
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            DeleteStudentRecord dt = new DeleteStudentRecord();
            this.Hide();
            dt.Show();
        }

        private void showRecord_Click(object sender, EventArgs e)
        {
            Records r = new Records();
            this.Hide();
            r.Show();
            
        }
    }
}
