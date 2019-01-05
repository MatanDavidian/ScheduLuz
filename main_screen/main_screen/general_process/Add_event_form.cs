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
using database_location;
using System.IO;
using System.Drawing.Drawing2D;


namespace main_screen.general_process
{
    public partial class Add_event_form : Form
    {
        public Add_event_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    StreamReader per = new StreamReader("permissionFile.txt");  //reads the permission from permission file.
       //     string permission = per.ReadLine();                         //now we will check the permission
            if (log_in_page.permission == "manager")                                   //according to that, we wil be able to determine 
            {                                                           //wich screed to go back to.
                ManagerCalander managerCalander = new ManagerCalander();
                managerCalander.Show();
                Visible = false;

            }
            else if (log_in_page.permission == "teacher")
            {
                TeacherCalander teacherCalander = new TeacherCalander();
                teacherCalander.Show();
                Visible = false;

            }

            else if (log_in_page.permission == "student")
            {
                StudentCalander frmCal = new StudentCalander();
                frmCal.Show();
                Visible = false;
            }

            //per.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_title.Text == "")
            {
                MessageBox.Show("please fill the title.");
            }
            else if (Place.Text == "")
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





                try
                {
                    dataBase dataBase = new dataBase();
                    SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,event_privacy,up_for_cancellation) VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@private_B,@up_for_cancellation) ", conn);

                    cmd.Parameters.Add("@up_for_cancellation", "NO");
                    cmd.Parameters.Add("@event_kind", "Regular");
                    cmd.Parameters.Add("@Event_name", text_title.Text.ToString());
                    cmd.Parameters.Add("@date", date.Text);
                    cmd.Parameters.Add("@hours_start", hours_start.Value);
                    cmd.Parameters.Add("@minutes_start", minutes_start.Text);
                    cmd.Parameters.Add("@hours_end", hours_end.Text);
                    cmd.Parameters.Add("@minutes_end", minutes_end.Text);
                    //cmd.Parameters.Add("@time_before", time_before.SelectedItem.ToString());
                    cmd.Parameters.Add("@Event_details", richTextBox1.Text.ToString());
                    if (private_B.Checked)
                    {
                        cmd.Parameters.Add("@private_B", "Private");
                    }
                    else
                    {
                        cmd.Parameters.Add("@private_B", "Public");
                    }
                    cmd.Parameters.Add("@Place", Place.Text.ToString());
                    cmd.ExecuteNonQuery();
                    //take the max id event from Event table
                    string query = "Select MAX(Event_id) from Events";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    int eve_id = int.Parse(dtbl.Rows[0][0].ToString().Trim());
                    //insert the max id event and the event id to Events_to_Users table
                    cmd = new SqlCommand("INSERT INTO Events_to_Users (User_ID,Event_ID) VALUES(@User_ID,@Event_ID) ", conn);
                    cmd.Parameters.Add("@User_ID", log_in_page.userId);
                    cmd.Parameters.Add("@Event_ID", eve_id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your event added successfully");
                    conn.Close();
                    text_title.Clear();
                    richTextBox1.Clear();
                    Place.Clear();
                }
                catch
                {
                    MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
                }
            }
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        


        private void Add_event_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduLuzDataSet2.Events' table. You can move, or remove it, as needed.
            //this.eventsTableAdapter.Fill(this.scheduLuzDataSet2.Events);
            //string premmition= log_in_page.permission;
            hours_start.Minimum = 0;
            hours_start.Maximum = 24;
            minutes_start.Minimum = 0;
            minutes_start.Maximum = 60;
            hours_end.Minimum = 0;
            hours_end.Maximum = 24;
            minutes_end.Minimum = 0;
            minutes_end.Maximum = 60;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {
            
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

        private void hours_end_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minutes_start_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
