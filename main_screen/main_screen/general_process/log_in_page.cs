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
using USER;
using database_location;
using System.IO;








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
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query = "Select permission from connection_details Where userName = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            /*creating text file for later use.
             * for permission only
             * M for manager
             * T for teacher
             * S for student
             */
            StreamWriter perFile = new StreamWriter("permissionFile.txt");



            if (dtbl.Rows.Count > 0)
            {
                /*
                 * the next code part is storing the user permission for later use 
                 */
                User user = new User();
                user.insertPermission(dtbl.Rows[0][0].ToString().Trim());
                user.insertUsername(textBox1.Text.Trim());
                user.insertPassword(textBox2.Text.Trim());
                
                string per = user.getPermission();

                if (per == "manager")
                {
                    ManagerCalander Mc = new ManagerCalander();
                    this.Hide();
                    perFile.Write("M");
                    perFile.Close();
                    Mc.Show();
                }
                if (per == "teacher" )
                {
                   TeacherCalander Tc = new TeacherCalander();
                    this.Hide();
                    perFile.Write("T");
                    perFile.Close();
                    Tc.Show();
                }
                if (per == "student")
                {
                    StudentCalander Sc = new StudentCalander();
                    this.Hide();
                    perFile.Write("S");
                    perFile.Close();
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
