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

namespace main_screen.Student.Mail
{
    public partial class NewMessage : Form
    {
        public NewMessage()
        {
            InitializeComponent();
        }

        private string reciver_id;
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query = "Select id,name,lastName from users Where permission = 'student'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            student_lst.Items.Clear();

            for(int i=0; i<dtb.Rows.Count; i++)
            {
                string temp = dtb.Rows[i]["name"].ToString().Trim().ToUpper() + " " + dtb.Rows[i]["lastName"].ToString().Trim().ToUpper();
                
                if (temp.Contains(to_txt.Text.ToUpper()))
                {
                    student_lst.Items.Add(dtb.Rows[i]["name"].ToString().Trim()+" "+ dtb.Rows[i]["lastName"].ToString().Trim());
                }                
            }
            
            
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            Mail_form m = new Mail_form();
            m.Show();
            this.Hide();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();

                string reciver_username = to_txt.Text.Replace(" ", "");

                string query = "Select id from connection_details Where userName = '" + reciver_username + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    reciver_id = dtb.Rows[0][0].ToString().Trim();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Mail_box (user_id_send,user_id_get,date_and_time,msg_txt,subject) VALUES (@user_id_send,@user_id_get,@date_and_time,@msg_txt,@subject)", con);
                    cmd.Parameters.Add("@user_id_send", log_in_page.userId);
                    cmd.Parameters.Add("@user_id_get", reciver_id);
                    cmd.Parameters.Add("@date_and_time", DateTime.Now);
                    cmd.Parameters.Add("@msg_txt", msg_txt.Text);
                    cmd.Parameters.Add("@subject", subject_txt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Message has been sent.");

                    Mail_form n = new Mail_form();
                    n.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong student name.");
                }
            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }
        }

        private void student_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = student_lst.SelectedIndex;
                to_txt.Text = student_lst.Items[index].ToString();
            }
            catch
            {

            }
        }

        private void NewMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
