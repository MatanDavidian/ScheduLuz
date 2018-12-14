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
    public partial class TeacherCalander : Form
    {
        public TeacherCalander()
        {
            InitializeComponent();
        }

        private void add_event_Click(object sender, EventArgs e)
        {
            general_process.Add_event_form Mc = new general_process.Add_event_form();
            this.Hide();
            Mc.Show();
        }

        private void TeacherCalander_Load(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();

            string query;

           
            query = "Select item from checklists where user_id ='" + log_in_page.userId + "'";
            

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                checklist.Items.Add(dtb.Rows[i]["item"].ToString().Trim());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            log_in_page frmCal = new log_in_page();
            frmCal.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher.SendEmail frmCal = new Teacher.SendEmail();
            frmCal.Show();
            Visible = false;
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            general_process.Profile profile = new general_process.Profile();
            this.Hide();
            profile.Show();
        }

        private void multi_studnt_event_btn_Click(object sender, EventArgs e)
        {
            Teacher.multiStudentEvent n = new Teacher.multiStudentEvent();
            n.Show();
            this.Hide();
        }

        private void add_chklist_btn_Click(object sender, EventArgs e)
        {
            if(add_chklist_txt.Text=="")
            {
                MessageBox.Show("You realy got nothig to do?");
            }
            else
            {
                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO checklists(user_id,item) VALUES(@id,@item) ", conn);
                cmd.Parameters.Add("@id", log_in_page.userId);
                cmd.Parameters.Add("@item", add_chklist_txt.Text);

                cmd.ExecuteNonQuery();

                checklist.Items.Add(add_chklist_txt.Text);
                conn.Close();

                add_chklist_txt.Text = "";


            }
        }
    }
}
