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
            dataBase loging_dataBase = new dataBase();
            SqlConnection conn = loging_dataBase.connect_to_scheduluz_DB();
            DateTime dt = DateTime.Now;
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO logins_report(date,user_id,user_name,connectORdisconnect) VALUES(@date,@user_id,@user_name,@connectORdisconnect) ", conn);
            cmd.Parameters.Add("@date", dt);
            cmd.Parameters.Add("@user_id", log_in_page.userId);
            cmd.Parameters.Add("@user_name", log_in_page.loginUserName);
            cmd.Parameters.Add("@connectORdisconnect", "disconnect");
            cmd.ExecuteNonQuery();

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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            List<ListViewItem> itemlist = new List<ListViewItem>();
            listView1.Items.Clear();

            int thisday = monthCalendar1.SelectionRange.Start.Day;
            int thismonth = monthCalendar1.SelectionRange.Start.Month;
            int thisyear = monthCalendar1.SelectionRange.Start.Year;
            string dayOfWeek = monthCalendar1.SelectionRange.Start.DayOfWeek.ToString();



            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();


            string id = "'" + log_in_page.userId.ToString() + "'";

            string query = "Select Event_ID from Events_to_Users where User_ID=" + id;



            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string event_id = "'" + dtb.Rows[i][0].ToString() + "'";

                string query2 = "Select * from Events where Event_id=" + event_id;

                SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                DataTable dtb2 = new DataTable();
                sda2.Fill(dtb2);
                /* 1/15/2019 00:00:00*/
                if (dtb2.Rows.Count > 0)
                {
                    if (dtb2.Rows[0]["date"].ToString() == thismonth.ToString() + "/" + thisday.ToString() + "/" + thisyear.ToString() + " 00:00:00")
                    {
                        string hours_end = dtb2.Rows[0]["hours_end"].ToString().Trim();

                        if (hours_end.Length < 2)
                        {
                            hours_end = "0" + hours_end;
                        }

                        string hours_start = dtb2.Rows[0]["hours_start"].ToString().Trim();

                        if (hours_start.Length < 2)
                        {
                            hours_start = "0" + hours_start;
                        }

                        string minutes_start = dtb2.Rows[0]["minutes_start"].ToString().Trim();

                        if (minutes_start.Length < 2)
                        {
                            minutes_start = "0" + minutes_start;
                        }

                        string minutes_end = dtb2.Rows[0]["minutes_end"].ToString().Trim();

                        if (minutes_end.Length < 2)
                        {
                            minutes_end = "0" + minutes_end;
                        }

                        ListViewItem item = new ListViewItem(dtb2.Rows[0]["Event_name"].ToString().Trim());
                        item.SubItems.Add(hours_start + ":" + minutes_start);
                        item.SubItems.Add(hours_end + ":" + minutes_end);

                        /*
                         * choosing color -- need to update if updated.
                         */
                        switch (dtb2.Rows[0]["event_kind"].ToString().Trim())
                        {
                            case "Muliplayer":
                                item.BackColor = Color.Orange;
                                break;

                            case "School":
                                item.BackColor = Color.YellowGreen;
                                break;

                            case "Regular":
                                item.BackColor = Color.SteelBlue;
                                break;
                            case "system-public":
                                item.BackColor = Color.HotPink;
                                break;

                            default:
                                break;
                        }
                        //listView1.Items.Add(item);
                        itemlist.Add(item);
                    }
                }

            }


            string user_class;
            User user = new User();
            user = user.GetUser(log_in_page.userId);
            user_class = user.getGrade() + "-" + user.getClassNumber();
            string query3 = "Select * from weekly_events where day_in_week='" + dayOfWeek + "' and user_id_OR_class='" + user_class + "'";

            SqlDataAdapter sda3 = new SqlDataAdapter(query3, conn);
            DataTable dtb3 = new DataTable();
            sda3.Fill(dtb3);

            for (int i = 0; i < dtb3.Rows.Count; i++)
            {
                string hours_end = dtb3.Rows[i]["ends"].ToString().Trim();

                if (hours_end.Length < 2)
                {
                    hours_end = "0" + hours_end;
                }

                string hours_start = dtb3.Rows[i]["start"].ToString().Trim();

                if (hours_start.Length < 2)
                {
                    hours_start = "0" + hours_start;
                }

                string minutes_start = "00";



                string minutes_end = "00";


                ListViewItem item = new ListViewItem(dtb3.Rows[i]["title"].ToString().Trim());
                item.SubItems.Add(hours_start + ":" + minutes_start);
                item.SubItems.Add(hours_end + ":" + minutes_end);
                item.BackColor = Color.IndianRed;

                //listView1.Items.Add(item);
                itemlist.Add(item);

            }

            //MessageBox.Show(itemlist[0].SubItems[1].ToString());

            for (int i = 0; i < itemlist.Count - 1; i++)
            {
                for (int j = 0; j < itemlist.Count - 1; j++)
                {
                    string firsthour = itemlist[j].SubItems[1].ToString();
                    string secondhour = itemlist[j + 1].SubItems[1].ToString();
                    if (compairhours(firsthour, secondhour))
                    {
                        ListViewItem temp = new ListViewItem();
                        temp = itemlist[j];
                        itemlist[j] = itemlist[j + 1];
                        itemlist[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < itemlist.Count; i++)
            {
                listView1.Items.Add(itemlist[i]);
            }

        }



        private Boolean compairhours(string a, string b)//if a>=b
        {
            string listsubitemshit = "ListViewSubItem: {";
            int dif = listsubitemshit.Length;
            //checks hours
            if (a[0 + dif] > b[0 + dif])
                return true;
            if (b[0 + dif] > a[0 + dif])
                return false;


            if (a[1 + dif] > b[1 + dif])
                return true;
            if (b[1 + dif] > a[1 + dif])
                return false;
            //skips a[2+dif] cus its ':'
            //checks minutes
            if (a[3 + dif] > b[3 + dif])
                return true;
            if (b[3 + dif] > a[3 + dif])
                return false;

            if (a[4 + dif] > b[4 + dif])
                return true;


            return false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Student.AppointmentPage n = new Student.AppointmentPage();
            this.Hide();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student.AnswerSurveys n = new Student.AnswerSurveys();
            this.Hide();
            n.Show();
        }

        private void motd_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
                
            
            
            
        
    

