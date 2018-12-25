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
        private void show_edit_event_Load(object sender, EventArgs e)
        {
            Event.Event n = new Event.Event();
            n = n.getEvent(event_id,weekly);

            title_txt.Text = n.getTitle();
            place_txt.Text = n.getPlace();
            details_txt.Text = n.getDetails();
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
    }
}
