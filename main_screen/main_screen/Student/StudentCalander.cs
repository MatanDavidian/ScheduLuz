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
using check_funcs;

namespace main_screen
{
    public partial class StudentCalander : Form
    {
        public StudentCalander()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            log_in_page frmCal = new log_in_page();
            frmCal.Show();
            Visible = false;
        }

        private void add_event_Click(object sender, EventArgs e)
        {
            general_process.Add_event_form Mc = new general_process.Add_event_form();
            this.Hide();
            Mc.Show();
        }

        private void contact_page_Click(object sender, EventArgs e)
        {
            Student.ContactPage Mc = new Student.ContactPage();
            this.Hide();
            Mc.Show();
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            general_process.Profile profile = new general_process.Profile();
            this.Hide();
            profile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student.Multiplayer_event Mc = new Student.Multiplayer_event();
            this.Hide();
            Mc.Show();
        }

        private void mail_btn_Click(object sender, EventArgs e)
        {
            Student.Mail_form n = new Student.Mail_form();
            this.Hide();
            n.Show();
        }

        private void my_dear_diary_btn_Click(object sender, EventArgs e)
        {
            Student.identify n = new Student.identify();
            this.Hide();
            n.Show();
        }

        private void StudentCalander_Load(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string rownumOfMax = "0";
            con.Open();

            string query = "Select MAX(msg_id) from bulletin_board";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            if (dtb.Rows.Count > 0)
            {
                rownumOfMax = dtb.Rows[0][0].ToString();
                query = "Select msg from bulletin_board where msg_id ='" + rownumOfMax + "'";

                sda = new SqlDataAdapter(query, con);
                dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    motd_txt.Text = dtb.Rows[0][0].ToString();
                }
            }
        }
    }
}
