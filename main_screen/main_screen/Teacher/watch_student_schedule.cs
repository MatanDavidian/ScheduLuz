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

namespace main_screen.Teacher
{
    public partial class watch_student_schedule : Form
    {
        string student_id;
        public watch_student_schedule()
        {
            InitializeComponent();
        }

        private void to_txt_TextChanged(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = false;

            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query = "Select id,name,lastName from users Where permission = 'student'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            student_lst.Items.Clear();

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string temp = dtb.Rows[i]["name"].ToString().Trim().ToUpper() + " " + dtb.Rows[i]["lastName"].ToString().Trim().ToUpper();

                if (temp.Contains(student_name_txt.Text.ToUpper()))
                {
                    student_lst.Items.Add(dtb.Rows[i]["name"].ToString().Trim() + " " + dtb.Rows[i]["lastName"].ToString().Trim());
                }
            }
        }

        private void load_student_btn_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            profilePic_img.Image = null;
            monthCalendar1.Enabled = true;


            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string queryTogetStudentID = "Select id from connection_details Where userName = '" + student_name_txt.Text.Replace(" ","") + "'";
            SqlDataAdapter sda6 = new SqlDataAdapter(queryTogetStudentID, con);
            DataTable dtb6 = new DataTable();
            sda6.Fill(dtb6);

            if(dtb6.Rows.Count > 0)
            {
                student_id = dtb6.Rows[0][0].ToString().Trim();
                User student = new User();
                student = student.GetUser(student_id);


                


                address_txt.Text = student.getAddress();
                birthdate_pckr.Text = student.getBirthDate();
                freetext_txt.Text = student.getFreeTxt();
                hobies_txt.Text = student.getHobies();
                Email_1st.Text = student.getEmail();
                phone_txt.Text = student.getPhoneNumber();
                PEmail_txt.Text = student.getParentEmail();
                

                


                /*
                 * picture
                 */

                
                con.Open();

                string query2 = "select picture from users where id='" + student_id + "'";

                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader dataRead = cmd.ExecuteReader();
                dataRead.Read();

                try
                {
                    byte[] img = null;
                    if (dataRead.HasRows)
                    {
                        img = (byte[])dataRead[0];
                    }

                    if (img == null)
                    {
                        profilePic_img.Image = null;


                    }

                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(img);
                        profilePic_img.Image = Image.FromStream(memoryStream);
                    }
                }

                catch
                {

                }
                con.Close();

            }
            else
            {
                MessageBox.Show("There is no such a student.");
                monthCalendar1.Enabled = false;
            }



            

                List<ListViewItem> itemlist = new List<ListViewItem>();
                listView1.Items.Clear();

                int thisday = monthCalendar1.SelectionRange.Start.Day;
                int thismonth = monthCalendar1.SelectionRange.Start.Month;
                int thisyear = monthCalendar1.SelectionRange.Start.Year;
                string dayOfWeek = monthCalendar1.SelectionRange.Start.DayOfWeek.ToString();



                dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                conn.Open();


                string id = "'" + student_id + "'";

                string query = "Select Event_ID from Events_to_Users where User_ID=" + id;



                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);

                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    string event_id = "'" + dtb.Rows[i][0].ToString() + "'";

                    string query2 = "Select * from Events where Event_id=" + event_id + " and event_privacy = 'Public'";

                    SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                    DataTable dtb2 = new DataTable();
                    sda2.Fill(dtb2);
                /* 1/15/2019 00:00:00*/
                
                    if (dtb2.Rows.Count > 0)
                    {
                        if (dtb2.Rows[0]["date"].ToString() == thisday.ToString() + "/" + thismonth.ToString() + "/" + thisyear.ToString() + " 00:00:00")
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
                user = user.GetUser(student_id);
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
                    item.BackColor = Color.Orange;

                    //listView1.Items.Add(item);
                    itemlist.Add(item);

                }

                //MessageBox.Show(itemlist[0].SubItems[1].ToString());

                for (int i = 0; i < itemlist.Count - 2; i++)
                {
                    for (int j = 0; j < itemlist.Count - 2; j++)
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

        private void student_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = student_lst.SelectedIndex;
                student_name_txt.Text = student_lst.Items[index].ToString();
            }
            catch { }
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


            string id = "'" + student_id + "'";

            string query = "Select Event_ID from Events_to_Users where User_ID=" + id;



            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string event_id = "'" + dtb.Rows[i][0].ToString() + "'";

                string query2 = "Select * from Events where Event_id=" + event_id+ " and event_privacy = 'Public'";

                SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                DataTable dtb2 = new DataTable();
                sda2.Fill(dtb2);
                /* 1/15/2019 00:00:00*/
                
                if (dtb2.Rows.Count > 0)
                {
                    string day= thisday.ToString();
                    string month= thismonth.ToString();
                    if (day.Length < 2)
                    {
                        day = "0" + day;
                    }
                    if (month.Length < 2)
                    {
                        month = "0" + month;
                    }
                    if (dtb2.Rows[0]["date"].ToString() == day + "/" + month + "/" + thisyear.ToString() + " 00:00:00")
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
            user = user.GetUser(student_id);
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
                item.BackColor = Color.Orange;

                //listView1.Items.Add(item);
                itemlist.Add(item);

            }

            //MessageBox.Show(itemlist[0].SubItems[1].ToString());

            for (int i = 0; i < itemlist.Count - 2; i++)
            {
                for (int j = 0; j < itemlist.Count - 2; j++)
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

        private void return_btn_Click(object sender, EventArgs e)
        {
            TeacherCalander n = new TeacherCalander();
            n.Show();
            this.Hide();
        }

        private void watch_student_schedule_Load(object sender, EventArgs e)
        {

        }
    }


}
