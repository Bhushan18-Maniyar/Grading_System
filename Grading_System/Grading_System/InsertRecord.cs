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
    public partial class InsertRecord : Form
    {
        string grade = "ZZ";
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\bhushan\documents\visual studio 2010\Projects\Grading_System\Grading_System\DatabaseUser.mdf;Integrated Security=True;User Instance=True;");
        public InsertRecord()
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
                    if ((string)r["name"]!= "User")
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
                
                SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" + recordname.SelectedItem.ToString() + "'", con);
                SqlDataReader r = cmd.ExecuteReader();
                String[] s = new String[5];
                
                int i = 0;
                while(r.Read())
                {
                
                    if (r["COLUMN_NAME"].ToString() != "Name" && r["COLUMN_NAME"].ToString() != "Enrollment" && r["COLUMN_NAME"].ToString() != "Average" && r["COLUMN_NAME"].ToString() != "Grade")
                    {
                        s[i] = r["COLUMN_NAME"].ToString();
                        i++;
                     }
                }
                sub1.Text = s[0] + " : ";
                sub2.Text = s[1] + " : ";
                sub3.Text = s[2] + " : ";
                sub4.Text = s[3] + " : ";
                sub5.Text = s[4] + " : ";
                con.Close();
            }
            catch { }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int[] a = new int[5];
                a[0] = Convert.ToInt32(sub1t.Text);
                a[1] = Convert.ToInt32(sub2t.Text);
                a[2] = Convert.ToInt32(sub3t.Text);
                a[3] = Convert.ToInt32(sub4t.Text);
                a[4] = Convert.ToInt32(sub5t.Text);
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += a[i];
                }
                float avg = sum / 5;
                string avgfinal = avg + "";
                
                if (avg >= 85 && avg <= 100)
                {
                    grade = "AA";
                }
                else if(avg >= 75 && avg<=84)
                {
                    grade = "AB";
                }
                else if (avg >= 65 && avg <= 74)
                {
                    grade = "BB";
                }
                else if (avg >= 55 && avg <= 64)
                {
                    grade = "BC";
                }
                else if (avg >= 45 && avg <= 54)
                {
                    grade = "CC";
                }
                else if (avg >= 40 && avg <= 44)
                {
                    grade = "CD";
                }
                else if (avg > 35 && avg <= 39)
                {
                    grade = "DD";
                }
                else if (avg <= 35)
                {
                    grade = "AB";
                }

                //"INSERT INTO [User] (UserName, password, [Class Name], Email) VALUES ('"+ username.Text +"', '"+ pass.Text +"', '"+ classname.Text +"', '"+ email.Text +"')"
                SqlCommand cmd = new SqlCommand("INSERT INTO [" + recordname.SelectedItem.ToString() + "] Values('" + stname.Text + "','" + enroll.Text + "','" + a[0] + "','" + a[1] + "','" + a[2] + "','" + a[3] + "','" + a[4] + "','" + avgfinal + "','"+grade+"')", con);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    sub1t.Text = "";
                    sub2t.Text = "";
                    sub3t.Text = "";
                    sub4t.Text = "";
                    sub5t.Text = "";
                    MessageBox.Show("Record Inserted..", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Error in Insertion..!!", "Grading_System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }

        }
    }
}
