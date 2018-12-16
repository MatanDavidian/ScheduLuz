using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database_location;
using System.Data.SqlClient;
using System.IO;

using USER;

namespace main_screen.Student
{
    public partial class Multiplayer_event : Form
    {
        public ImageList imgs = new ImageList();
        public Multiplayer_event()
        {
            InitializeComponent();
        }

        private void Multiplayer_event_Load(object sender, EventArgs e)
        {
            hours_start.Minimum = 0;
            hours_start.Maximum = 24;
            minutes_start.Minimum = 0;
            minutes_start.Maximum = 60;
            hours_end.Minimum = 0;
            hours_end.Maximum = 24;
            minutes_end.Minimum = 0;
            minutes_end.Maximum = 60;
        }
        int count = 0;
        private void populate()
        {
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            con.Open();

            string fullName = friend_name.Text.ToString();
            var names = fullName.Split(' ');
            if (names.Length != 2)
            {
                friend_name.Clear();
                MessageBox.Show("illegal enter first name and last name separate.");
                con.Close();
            }
            else
            {
                string firstName = names[0];
                string lastName = names[1];
                string query = "Select * from users Where name = '" + firstName + "' and LastName = '" + lastName + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                int flag = 1;
                string help_full_name;
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    help_full_name = listView1.Items[i].Text.ToString().Trim();
                    if(help_full_name== fullName)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1 && dtbl.Rows.Count > 0 && dtbl.Rows[0][3].ToString().Trim() == "student" && (dtbl.Rows[0][1].ToString().Trim() + dtbl.Rows[0][2].ToString().Trim()).ToUpper() != log_in_page.loginUserName.ToUpper())
                {
                    byte[] img = null;


                    if (!dtbl.Rows[0].IsNull("picture"))
                    {
                        img = (byte[])dtbl.Rows[0][13];
                        MemoryStream memoryStream = new MemoryStream(img);
                        imgs.Images.Add(friend_name.Text.Trim(), Image.FromStream(memoryStream));
                    }
                    else
                    {
                        listView1.SmallImageList = null;
                    }

                    con.Close();
                    listView1.SmallImageList = imgs;
                    listView1.Items.Add(friend_name.Text.Trim(), count);
                    count++;
                }
                else if (dtbl.Rows.Count > 0 && (dtbl.Rows[0][1].ToString().Trim() + dtbl.Rows[0][2].ToString().Trim()).ToUpper() == log_in_page.loginUserName.ToUpper())
                {
                    MessageBox.Show("You are alreary invented.");
                }
                else if (dtbl.Rows.Count == 0)
                {
                    MessageBox.Show(firstName + " " + lastName + " dosent exist, try again.");
                }
                else if(flag==0)
                {
                    MessageBox.Show("you already invent" + fullName +" .");
                }
                else
                {
                    MessageBox.Show("You can Invents only your friends.");
                }
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            imgs.ImageSize = new Size(50, 50);
            populate();
            friend_name.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;

            MessageBox.Show(selected);
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //String selected = listView1.SelectedItems[0].Text;
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                  //  MessageBox.Show(selected + " delete.");
                    listView1.Items[i].Remove();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentCalander frmCal = new StudentCalander();
            frmCal.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,up_for_cancellation) VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@up_for_cancellation) ", conn);

            cmd.Parameters.Add("@up_for_cancellation", "YES");
            cmd.Parameters.Add("@event_kind", "Muliplayer");
            cmd.Parameters.Add("@Event_name", text_title.Text.ToString());
            cmd.Parameters.Add("@date", date.Text);
            cmd.Parameters.Add("@hours_start", hours_start.Value);
            cmd.Parameters.Add("@minutes_start", minutes_start.Text);
            cmd.Parameters.Add("@hours_end", hours_end.Text);
            cmd.Parameters.Add("@minutes_end", minutes_end.Text);
            //cmd.Parameters.Add("@time_before", time_before.SelectedItem.ToString());
            cmd.Parameters.Add("@Event_details", richTextBox1.Text.ToString());
            
            cmd.Parameters.Add("@Place", Place.Text.ToString());
            cmd.ExecuteNonQuery();
            //take the max id event from Event table
            string query = "Select MAX(Event_id) from Events";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            int eve_id = int.Parse(dtbl.Rows[0][0].ToString().Trim());
            int usr_id;
            String fullName;
            //insert the max id event and the event id to Events_to_Users table
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                fullName = listView1.Items[i].Text.ToString().Trim();
                var names = fullName.Split(' ');
                if (names.Length != 2)
                {
                    friend_name.Clear();
                    MessageBox.Show("illegal enter first name and last name separate.");
                    conn.Close();
                }
                else
                {
                    string firstName = names[0];
                    string lastName = names[1];
                    query = "Select * from users Where name = '" + firstName + "' and LastName = '" + lastName + "'";                    sda = new SqlDataAdapter(query, conn);
                    dtbl = new DataTable();
                    sda.Fill(dtbl);
                    usr_id = int.Parse(dtbl.Rows[0][0].ToString().Trim());

                    cmd = new SqlCommand("INSERT INTO Events_to_Users (User_ID,Event_ID) VALUES(@User_ID,@Event_ID) ", conn);
                    cmd.Parameters.Add("@User_ID", usr_id);
                    cmd.Parameters.Add("@Event_ID", eve_id);
                    cmd.ExecuteNonQuery();
                }
                StudentCalander n = new StudentCalander();
                n.Show();
                this.Hide();
            }
            

            MessageBox.Show("Your event added successfully");
            conn.Close();
            text_title.Clear();
            richTextBox1.Clear();
            Place.Clear();
            listView1.Clear();
    
        }

        private void hours_start_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
