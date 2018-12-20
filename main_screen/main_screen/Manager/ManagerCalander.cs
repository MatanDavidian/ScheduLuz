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
            log_in_page frmCal = new log_in_page();
            frmCal.Show();
            Visible = false;
        }

        private void ManagerCalander_Load(object sender, EventArgs e)
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

            /*
             * show events on calander.
             */

            int thisday = monthCalendar1.SelectionRange.Start.Day;
            int thismonth = monthCalendar1.SelectionRange.Start.Month;
            int thisyear = monthCalendar1.SelectionRange.Start.Year;

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

                            default:
                                break;
                        }
                        listView1.Items.Add(item);
                    }
                }

            }
        }

        private void fixed_btn_Click(object sender, EventArgs e)
        {
            Manager.fixed_schedule n = new Manager.fixed_schedule();
            n.Show();
            this.Hide();
        }
    }
}
