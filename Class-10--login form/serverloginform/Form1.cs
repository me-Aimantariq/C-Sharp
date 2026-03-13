using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serverloginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=STUDENTS;Initial Catalog=login;Integrated Security=True;"))
            {
                
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Students(id,username,password) VALUES (@id,@username,@password)", con))
                    {
                        cmd.Parameters.AddWithValue("@username",textBox2.Text);
                        cmd.Parameters.AddWithValue("@password",textBox1.Text);
                     cmd.Parameters.AddWithValue("@id",textBox3.Text);
                    cmd.ExecuteNonQuery();

                    }
                }
            MessageBox.Show(
                "Data Saver ",
                "success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=STUDENTS;Initial Catalog=login;Integrated Security=True;"))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                   "Update students SET Username=@Username, Password=@Password WHERE id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@username", textBox2.Text);
                    cmd.Parameters.AddWithValue("@password", textBox1.Text);
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show(
                "Data Saver ",
                "success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(
                "Data Source=STUDENTS;Initial Catalog=login;Integrated Security=True;"))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(
                       "Delete from students WHERE id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", textBox3.Text);
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show(
                    "Data Saver ",
                    "success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
             "Data Source=STUDENTS;Initial Catalog=login;Integrated Security=True;"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Students", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
