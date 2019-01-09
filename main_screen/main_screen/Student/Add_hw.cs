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
    public partial class Add_hw_form : Form
    {
        public Add_hw_form()
        {
            InitializeComponent();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            StudentCalander n = new StudentCalander();
            this.Hide();
            n.Show();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            bool exe_flag = false;
            try
            {
                if (profassion_txt.Text.Length == 0)
                {
                    MessageBox.Show("please fill profassion");
                }
                else if (from_hour.Value > to_hour.Value)
                {
                    MessageBox.Show("your starting hour is later then your ending hour.");
                }
                else if (from_hour.Value == to_hour.Value)
                {
                    if (from_minute.Value >= to_minute.Value)
                    {
                        MessageBox.Show("your starting hour is later then your ending hour.");
                    }
                    else exe_flag = true;
                }
                else exe_flag = true;

                if (exe_flag)
                {

                    check_funcs.DBfuncs addEvent = new DBfuncs();
                    string userID = log_in_page.userId;
                    string title = "H.W in " + profassion_txt.Text;
                    string details = details_txt.Text;
                    string place = "";
                    string privacy = "private";
                    string up_for_cancellation = "YES";
                    DateTime date = dateTimePicker1.Value;
                    string hours_start = from_hour.Value.ToString(); ;
                    string hours_end = to_hour.Value.ToString();
                    string minutes_start = from_minute.Value.ToString();
                    string minutes_end = to_minute.Value.ToString();
                    string kind = "HW";



                    if (
                    addEvent.insertToEvents(userID, title, details, place, privacy, up_for_cancellation
                    , date, hours_start, hours_end, minutes_start, minutes_end, kind))
                    {
                        if (addEvent.insertToEvents(userID, "Submit" + title, "", place, privacy, up_for_cancellation,
                            dateTimePicker2.Value, "23", "23", "0", "59", kind))
                        {
                            MessageBox.Show("added!");
                        }
                        else
                        {
                            MessageBox.Show("Problem -  please check your values");
                        }

                    }
                    else
                    {
                        MessageBox.Show("problem detected. contact your ScheduluzGuide for more info.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("problem detected. contact your ScheduluzGuide for more info.");
            }

        }

        private void Add_hw_form_Load(object sender, EventArgs e)
        {
            DateTime D = new DateTime();
            D = DateTime.Today;
            dateTimePicker2.MinDate = D;
            dateTimePicker1.MinDate = D;
        }

        private void from_hour_ValueChanged(object sender, EventArgs e)
        {
            if (from_hour.Value == 24)
            {
                from_hour.Value = 0;
            }
            if (from_hour.Value >= 23)
            {
                to_hour.Value = 23;
            }
            else
            {
                to_hour.Value = from_hour.Value + 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime D = dateTimePicker1.Value;
            dateTimePicker2.MinDate = D;
        }
    }

}


