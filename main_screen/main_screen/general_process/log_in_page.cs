using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;





    


namespace main_screen
{
    public partial class log_in_page : Form
    {
        public log_in_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\projectC#\ScheduLuz2\main_screen\main_screen\DataBases\ScheduLuz.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select permission from connection_details Where userName = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                string per= dtbl.Rows[0][0].ToString().Trim();
                if (per == "manager")
                {
                    ManagerCalander Mc = new ManagerCalander();
                    this.Hide();
                    Mc.Show();
                }
                if (per == "teacher" )
                {
                   TeacherCalander Tc = new TeacherCalander();
                    this.Hide();
                    Tc.Show();
                }
                if (per == "student")
                {
                    StudentCalander Sc = new StudentCalander();
                    this.Hide();
                    Sc.Show();
                }
            }
            else
            {
                MessageBox.Show("Check you username and password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
