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
using Event;
using database_location;
using System.IO;
using check_funcs;

namespace main_screen.general_process
{
    public partial class show_edit_event : Form
    {
        public show_edit_event()
        {
            InitializeComponent();
        }
        public static string event_id;
        public static bool weekly;
        public static bool editalbe;
        private void show_edit_event_Load(object sender, EventArgs e)
        {
            delete_btn.Visible = false;
            Event.Event n = new Event.Event();
            n = n.getEvent(event_id,weekly);

            title_txt.Text = n.getTitle();
            place_txt.Text = n.getPlace();
            details_txt.Text = n.getDetails();
            if(n.getKind().ToLower() == "regular")
            {
                editalbe = true;
            }
            else if (n.getKind().ToLower() =="muliplayer" && log_in_page.permission.ToLower() != "student")
            {
                editalbe = true;
            }
            else if (n.getKind().ToLower() == "system-public" && log_in_page.permission.ToLower() == "manager")
            {
                editalbe = true;
            }
            else
            {
                editalbe = false;
            }
            if(editalbe)
            {
                delete_btn.Visible = true;
            }
                if (!weekly)
            {
                date.Value = n.getTheDate();
                day_in_week.Visible = false;
            }
            if(weekly)
            {
                date.Visible = false;
                day_in_week.Text = "Every " + n.getDayInWeek();
            }

            hours_start.Value = Int32.Parse(n.getHours_start());
            hours_end.Value = Int32.Parse(n.getHours_end());
            minutes_start.Value = Int32.Parse(n.getMinutes_start());
            minutes_end.Value = Int32.Parse(n.getMinutes_end());
            if(n.IsPrivate())
            {
                private_B.Checked = true;
                public_B.Checked = false;
            }
            else
            {
                private_B.Checked = false;
                public_B.Checked = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (log_in_page.permission.ToLower() == "manager")
            {
                ManagerCalander n = new ManagerCalander();
                n.Show();
                this.Hide();
            }
            else if (log_in_page.permission.ToLower() == "teacher")
            {
                TeacherCalander n = new TeacherCalander();
                n.Show();
                this.Hide();
            }
            else
            {
                StudentCalander n = new StudentCalander();
                n.Show();
                this.Hide();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (weekly && log_in_page.permission.ToLower() == "manager")
            {
                event_gb.Enabled = true;
                day_in_week_cb.Visible = true;
            }


            if (!weekly && editalbe)
                event_gb.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (title_txt.Text == "")
            {
                MessageBox.Show("please fill the title.");
            }
            else if (place_txt.Text == "")
            {
                MessageBox.Show("please fill the place.");
            }

            else if (hours_start.Value > hours_end.Value)
            {
                MessageBox.Show("your end time is before your start time.");
            }
            else if (hours_end.Value == hours_start.Value && minutes_end.Value <= minutes_start.Value)
            {
                MessageBox.Show("your end time is before your start time.");
            }
            else
            {
                string privacy = "";
                Event.Event n = new Event.Event();
                if (private_B.Checked == true)
                {
                    privacy = "private";
                }
                else if (public_B.Checked == true)
                {
                    privacy = "public";
                }
                bool updated = n.updateEvent(weekly, event_id, title_txt.Text, place_txt.Text, day_in_week_cb.Text, date.Value, hours_start.Value.ToString(), hours_end.Value.ToString(), minutes_start.Value.ToString(), minutes_end.Value.ToString(), details_txt.Text, privacy);
                if (updated)
                {
                    MessageBox.Show("updated");
                    button2.PerformClick();
                }
                else
                {
                    MessageBox.Show("not updated");
                }
            }
        }

        private void hours_start_ValueChanged(object sender, EventArgs e)
        {
            if (hours_start.Value == 24)
            {
                hours_start.Value = 0;
            }
            if (hours_start.Value >= 23)
            {
                hours_end.Value = 23;
            }
            else
            {
                hours_end.Value = hours_start.Value + 1;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Event.Event n = new Event.Event();
            n.deleteEvent(weekly, event_id);
            MessageBox.Show("Your event is deleted.");
            button2.PerformClick();
       }
    }
}
