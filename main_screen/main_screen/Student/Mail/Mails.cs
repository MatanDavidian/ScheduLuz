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

namespace main_screen.Student
{
    public partial class Mail_form : Form
    {
        public Mail_form()
        {
            InitializeComponent();
        }

        private void new_msg_btn_Click(object sender, EventArgs e)
        {
            Mail.NewMessage n = new Mail.NewMessage();
            n.Show();
            this.Hide();

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            StudentCalander s = new StudentCalander();
            s.Show();
            this.Hide();

        }

        private void msg_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mail_form_Load(object sender, EventArgs e)
        {
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();



                string query = "Select * from Mail_box Where user_id_get = '" + log_in_page.userId + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);

                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    User SentUser = new User();
                    SentUser = SentUser.GetUser(dtb.Rows[i]["user_id_send"].ToString().Trim());

                    ListViewItem item = new ListViewItem(SentUser.getName() + " " + SentUser.getLastName());
                    item.SubItems.Add(dtb.Rows[i]["subject"].ToString().Trim());
                    item.SubItems.Add(dtb.Rows[i]["date_and_time"].ToString().Trim());
                    item.SubItems.Add(dtb.Rows[i]["msg_txt"].ToString().Trim());

                    msg_lst.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }

            
        }
    }
}
