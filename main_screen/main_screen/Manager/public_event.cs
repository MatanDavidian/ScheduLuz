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


namespace main_screen.Manager
{
    public partial class public_event : Form
    {
        public public_event()
        {
            InitializeComponent();
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





                //try
                //{
                    dataBase dataBase = new dataBase();
                    SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,event_privacy,up_for_cancellation) VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@private_B,@up_for_cancellation) ", conn);

                    cmd.Parameters.Add("@up_for_cancellation", "NO");
                    cmd.Parameters.Add("@event_kind", "system-public");
                    cmd.Parameters.Add("@Event_name", text_title.Text.ToString());
                    cmd.Parameters.Add("@date", date.Text);
                    cmd.Parameters.Add("@hours_start", hours_start.Value);
                    cmd.Parameters.Add("@minutes_start", minutes_start.Text);
                    cmd.Parameters.Add("@hours_end", hours_end.Text);
                    cmd.Parameters.Add("@minutes_end", minutes_end.Text);
                    //cmd.Parameters.Add("@time_before", time_before.SelectedItem.ToString());
                    cmd.Parameters.Add("@Event_details", richTextBox1.Text.ToString());
                    cmd.Parameters.Add("@private_B", "Public");                    
                    cmd.Parameters.Add("@Place", Place.Text.ToString());
                    cmd.ExecuteNonQuery();


                    //take the max id event from Event table
                    string query = "Select MAX(Event_id) from Events";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    int eve_id = int.Parse(dtbl.Rows[0][0].ToString().Trim());
                    //insert the max id event and the event id to Events_to_Users table
                    
                    query = "Select id from users";
                    SqlDataAdapter sda2 = new SqlDataAdapter(query, conn);
                    DataTable dtbl2 = new DataTable();
                    sda2.Fill(dtbl2);
                    for (int i = 0; i < dtbl2.Rows.Count; i++)
                    {
                        cmd = new SqlCommand("INSERT INTO Events_to_Users (User_ID,Event_ID) VALUES(@User_ID,@Event_ID) ", conn);
                        cmd.Parameters.Add("@User_ID", dtbl2.Rows[i]["id"]);
                        cmd.Parameters.Add("@Event_ID", eve_id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Your event added successfully");
                    conn.Close();
                    text_title.Clear();
                    richTextBox1.Clear();
                    Place.Clear();
                //}
                //catch
                //{
                //    MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
                //}
            }

        }

        private void public_event_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerCalander n = new ManagerCalander();
            this.Hide();
            n.Show();
        }
    }
}
