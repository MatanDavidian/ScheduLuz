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
    public partial class ManagerCalander : Form
    {
        public ManagerCalander()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.add_user frmAEF = new Manager.add_user();
            frmAEF.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            general_process.Add_event_form Mc = new general_process.Add_event_form();
            this.Hide();
            Mc.Show();
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

        private void ManagerCalander_Load(object sender, EventArgs e)
        {
            DateTime now_dt = DateTime.Now;//END YEAR button visible or invisible according the date.
            DateTime start = new DateTime(int.Parse(now_dt.Year.ToString().Trim()), 10, 1);
            DateTime end = new DateTime(int.Parse(now_dt.Year.ToString().Trim())+1, 12, 31);
            if (now_dt.Ticks >= start.Ticks && now_dt.Ticks <= end.Ticks)
            {
                EndYear_btn.Visible = true;
            }
        
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
                    if (dtb2.Rows[0]["date"].ToString() == monthCalendar1.SelectionRange.Start.ToString())
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
                        item.SubItems.Add(event_id);

                        /*
                         * choosing color -- need to update if updated.
                         */
                        switch (dtb2.Rows[0]["event_kind"].ToString().Trim())
                        {
                            case "Muliplayer":
                                item.BackColor = Color.DeepSkyBlue;
                                break;

                            case "School":
                                item.BackColor = Color.Red;
                                break;

                            case "Regular":
                                item.BackColor = Color.SteelBlue;
                                break;
                            case "system-public":
                                item.BackColor = Color.Red;
                                break;
                            case "HW":
                                item.BackColor = Color.YellowGreen;
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
                item.SubItems.Add(dtb3.Rows[i]["wEvent_id"].ToString().Trim());
                item.BackColor = Color.Orange;

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


            dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string rownumOfMax = "0";
            con.Open();

            query = "Select MAX(msg_id) from bulletin_board";

            sda = new SqlDataAdapter(query, con);
            dtb = new DataTable();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            general_process.Profile profile = new general_process.Profile();
            profile.Show();
            Visible = false;
        }

        private void BBorad_btn_Click(object sender, EventArgs e)
        {
            Manager.BBoard n = new Manager.BBoard();
            n.Show();
            this.Hide();

        }

        private void motd_txt_Click(object sender, EventArgs e)
        {

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
                    if (dtb2.Rows[0]["date"].ToString() == monthCalendar1.SelectionRange.Start.ToString())
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
                        item.SubItems.Add(event_id);

                        /*
                         * choosing color -- need to update if updated.
                         */
                        switch (dtb2.Rows[0]["event_kind"].ToString().Trim())
                        {
                            case "Muliplayer":
                                item.BackColor = Color.DeepSkyBlue;
                                break;

                            case "School":
                                item.BackColor = Color.Red;
                                break;

                            case "Regular":
                                item.BackColor = Color.SteelBlue;
                                break;
                            case "system-public":
                                item.BackColor = Color.Red;
                                break;
                            case "HW":
                                item.BackColor = Color.YellowGreen;
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
                item.SubItems.Add(dtb3.Rows[i]["wEvent_id"].ToString().Trim());
                item.BackColor = Color.Orange;

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



        private void fixed_btn_Click(object sender, EventArgs e)
        {
            Manager.fixed_schedule n = new Manager.fixed_schedule();
            n.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            general_process.ManagerAndTeacher_view_contacts n = new general_process.ManagerAndTeacher_view_contacts();
            n.Show();
            this.Hide();
        }

        private void public_event_btn_Click(object sender, EventArgs e)
        {
            Manager.public_event n = new Manager.public_event();
            n.Show();
            this.Hide();
        }

        private void motd_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem item = listView1.SelectedItems[0];
                if (item.BackColor == Color.Orange)
                    general_process.show_edit_event.weekly = true;
                else
                    general_process.show_edit_event.weekly = false;

                general_process.show_edit_event.event_id = item.SubItems[3].Text.ToString();




                general_process.show_edit_event show = new general_process.show_edit_event();
                show.Show();
                this.Hide();


            }
        }

            private void button8_Click(object sender, EventArgs e)
        {
            Manager.LoginsReport n = new Manager.LoginsReport();
            n.Show();
            this.Hide();
        }

        private void fixed_btn_Click_1(object sender, EventArgs e)
        {
            Manager.fixed_schedule n = new Manager.fixed_schedule();
            n.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Manager.approve_cancellation n = new Manager.approve_cancellation();
            n.Show();
            this.Hide();
        }

        private void contact_page_btn_Click(object sender, EventArgs e)
        {
            general_process.ManagerAndTeacher_view_contacts n = new general_process.ManagerAndTeacher_view_contacts();
            n.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Manager.delete_user n = new Manager.delete_user();
            n.Show();
            this.Hide();
        }

        private void public_event_btn_Click_1(object sender, EventArgs e)
        {

            Manager.public_event n = new Manager.public_event();
            n.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove all the 12 grades student and remove all schedule?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes again
                    dataBase dataBase = new dataBase();
                    SqlConnection conn = dataBase.connect_to_scheduluz_DB();
                    SqlDataAdapter sda;
                    DataTable dt_lastyearusers, dt_students;
                    conn.Open();

                    string query = "Select Id from users where grade= "+ 12;
                    sda = new SqlDataAdapter(query, conn);
                    dt_lastyearusers = new DataTable();
                    sda.Fill(dt_lastyearusers);

                    for(int i=0;i< dt_lastyearusers.Rows.Count;i++)
                    {
                        string sendToId = dt_lastyearusers.Rows[i]["Id"].ToString().Trim();

                        User n = new User();
                        n.DeleteUser(sendToId);
                    }
                    for (int i = 7; i <= 12; i++)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM weekly_events WHERE user_id_OR_class ='"+i.ToString()+"'", conn);
                        cmd.ExecuteNonQuery();
                        for (int j = 1; j <= 3; j++)
                        {
                            SqlCommand cmd1 = new SqlCommand("DELETE FROM weekly_events WHERE user_id_OR_class ='" + i.ToString()+"-"+j.ToString() + "'", conn);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    /*
                    SqlCommand cmd = new SqlCommand("DELETE FROM weekly_events WHERE user_id_OR_class ='" +"12-1"+"'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM weekly_events WHERE user_id_OR_class ='" + "12-2" + "'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM weekly_events WHERE user_id_OR_class ='" + "12-3" + "'", conn);
                    cmd.ExecuteNonQuery();
                    */
                    query = "Select * from users where permission = '" +"student"+"'";
                    sda = new SqlDataAdapter(query, conn);
                    dt_students = new DataTable();
                    sda.Fill(dt_students);
                    for(int i=0;i< dt_students.Rows.Count;i++)
                    {
                        SqlCommand cmd2 = new SqlCommand("UPDATE users SET grade ='" + (int.Parse(dt_students.Rows[i]["grade"].ToString().Trim())+1).ToString() + "' WHERE id ='" + dt_students.Rows[i]["Id"] + "'", conn);
                        cmd2.ExecuteNonQuery();
                    }
                    if (dt_lastyearusers.Rows.Count > 0)
                    {
                        MessageBox.Show("All student at 12 grade are deleted and all the schedule.");
                    }
                    else
                        MessageBox.Show("There not student at 12 grade.");
                }
                else
                {
                    // user clicked no
                    log_in_page n = new log_in_page();
                    n.Show();
                    this.Hide();

                }
            }
            else
            {
                // user clicked no
                log_in_page n = new log_in_page();
                n.Show();
                this.Hide();

            }

        }
    }
}

