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

namespace main_screen.Teacher
{
    public partial class reception_hours : Form
    {
        Label[] labels = new Label[49];
        public reception_hours()
        {
            InitializeComponent();
        }

        private void reception_hours_Load(object sender, EventArgs e)
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Location = new Point(75, 120);
            Table.Size = new Size(536, 253);
            Table.AutoSize = true;
            Table.Name = "Desk";
            Table.ColumnCount = 7;
            Table.RowCount = 7;
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Controls.Add(Table);

            
            for (int i = 0; i < 6; i++)
            {
                labels[i] = new Label { BackColor = Color.Black, ForeColor = Color.White, Dock = DockStyle.Fill };
            }
            labels[0].Text = "Monday";
            Table.Controls.Add(labels[0], 1, 0);
            labels[1].Text = "Sunday";
            Table.Controls.Add(labels[1], 2, 0);
            labels[2].Text = "Tuesday";
            Table.Controls.Add(labels[2], 3, 0);
            labels[3].Text = "Wednesday";
            Table.Controls.Add(labels[3], 4, 0);
            labels[4].Text = "Thursday";
            Table.Controls.Add(labels[4], 5, 0);
            labels[5].Text = "Friday";
            Table.Controls.Add(labels[5], 6, 0);

            for (int i = 6; i < 12; i++)
            {
                labels[i] = new Label { BackColor = Color.DarkBlue, ForeColor = Color.White, Dock = DockStyle.Fill };
            }
            labels[6].Text = "8-10";
            Table.Controls.Add(labels[6], 0, 1);
            labels[7].Text = "10-12";
            Table.Controls.Add(labels[7], 0, 2);
            labels[8].Text = "12-14";
            Table.Controls.Add(labels[8], 0, 3);
            labels[9].Text = "14-16";
            Table.Controls.Add(labels[9], 0, 4);
            labels[10].Text = "16-18";
            Table.Controls.Add(labels[10], 0, 5);
            labels[11].Text = "18-20";
            Table.Controls.Add(labels[11], 0, 6);
            int k = 12;

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl;
            conn.Open();
            string query = "Select * from weekly_events where user_id_OR_class=" + log_in_page.userId+ "and event_kind='"+ "reception_hours"+"'" ;

            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            string hours;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    
                    labels[k] = new Label { BackColor = Color.DarkRed, Dock = DockStyle.Fill };
                    Table.Controls.Add(labels[k], j, i);
                    labels[k].Click += new System.EventHandler(labelClick);
                    labels[k].Text = labels[i+5].Text;
                    labels[k].TextAlign = ContentAlignment.MiddleCenter;
                    labels[k].ForeColor = Color.DarkRed;

                    for (int m = 0; m < dtbl.Rows.Count; m++)
                    {
                        hours = dtbl.Rows[m]["start"].ToString().Trim() + "-" + dtbl.Rows[m]["ends"].ToString().Trim();
                        if (labels[k].Text.Trim() == hours && labels[k%6].Text.Trim() == dtbl.Rows[m]["day_in_week"].ToString().Trim())
                        {
                            labels[k].BackColor = Color.LightGreen;
                        }
                    }
                    k++;
                }
            }

        }

        private void labelClick(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label.BackColor == Color.DarkRed)
            {
                label.ForeColor = Color.Black;
                label.BackColor = Color.LightGreen;
            }
            else
            {
                label.BackColor = Color.DarkRed;
                label.ForeColor = Color.DarkRed;
            }
        }
    

    private void button2_Click(object sender, EventArgs e)
        {
            TeacherCalander frmCal = new TeacherCalander();
            frmCal.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string day;
            string start,end;
            int int_start, int_end;
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda0, sda2;
            DataTable dtbl0, dtbl2;

            conn.Open();

            string query0 = "Select * from weekly_events where user_id_OR_class=" + log_in_page.userId + "and event_kind='" + "reception_hours" + "'";
            sda0 = new SqlDataAdapter(query0, conn);
            dtbl0 = new DataTable();
            sda0.Fill(dtbl0);
            string already_exist;
            bool flag = false;

            for (int i = 12; i < 48; i++)
            {
                if(labels[i].BackColor==Color.LightGreen)
                { 
                    SqlCommand cmd = new SqlCommand("INSERT INTO weekly_events(user_id_OR_class,day_in_week,start,ends,event_kind,title) VALUES(@user_id_OR_class,@day_in_week,@start,@ends,@event_kind,@title) ", conn);
                    string helpstring = log_in_page.loginUserName + " reception hours.";
                    cmd.Parameters.Add("@title", helpstring);
                    cmd.Parameters.Add("@user_id_OR_class", log_in_page.userId);
                    day = labels[i % 6].Text.ToString();//i%6 get the day
                    cmd.Parameters.Add("@day_in_week", day);
                    var hours = (labels[i].Text.ToString()).Split('-');//label text = hours start and end.
                    start = hours[0];
                    end = hours[1];
                    int_start=int.Parse(start);
                    int_end = int.Parse(end);
                    cmd.Parameters.Add("@start", int_start);
                    cmd.Parameters.Add("@ends", int_end);
                    cmd.Parameters.Add("@event_kind", "reception_hours");
                    for (int m = 0; m < dtbl0.Rows.Count; m++)//***CHECK IF THE EVENT IS ALREADY EXIST.
                    {
                        already_exist = dtbl0.Rows[m]["start"].ToString().Trim() + "-" + dtbl0.Rows[m]["ends"].ToString().Trim();
                        if (labels[i].Text.ToString().Trim() == already_exist && labels[i % 6].Text.Trim() == dtbl0.Rows[m]["day_in_week"].ToString().Trim())
                        {
                            flag = true;
                            break;
                        }
                    }
                    if(flag)//IF the event already exist.
                    {
                        flag = false;
                        continue;
                    }
                    cmd.ExecuteNonQuery();

                    //take the max id event from Event table
                    string query = "Select MAX(wEvent_id) from weekly_events";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    int eve_id = int.Parse(dtbl.Rows[0][0].ToString().Trim());
                    
                    //insert the max id event and the event id to weekly events to users table
                    cmd = new SqlCommand("INSERT INTO weekly_events_to_users (wEvent_id,user_id) VALUES(@wEvent_id,@user_id) ", conn);
                    cmd.Parameters.Add("@wEvent_id", eve_id); 
                    cmd.Parameters.Add("@user_id", log_in_page.userId);
                    cmd.ExecuteNonQuery();   
                }
                else
                {
                    for (int m = 0; m < dtbl0.Rows.Count; m++)//***CHECK IF THE EVENT IS ALREADY EXIST AND HS TO BE DELETED.
                    {
                        already_exist = dtbl0.Rows[m]["start"].ToString().Trim() + "-" + dtbl0.Rows[m]["ends"].ToString().Trim();
                        if (labels[i].Text.ToString().Trim() == already_exist && labels[i % 6].Text.Trim() == dtbl0.Rows[m]["day_in_week"].ToString().Trim())
                        {
                            string query2="Select wEvent_id from weekly_events where user_id_OR_class = '" + log_in_page.userId + "' and start='" + dtbl0.Rows[m]["start"] + "' and event_kind='" + "reception_hours" + "' and day_in_week ='" + labels[i % 6].Text.Trim()+"'";
                            sda2 = new SqlDataAdapter(query2, conn);
                            dtbl2 = new DataTable();
                            sda2.Fill(dtbl2);
                            SqlCommand cmd1 = new SqlCommand("DELETE FROM weekly_events_to_users WHERE wEvent_id ='" + dtbl2.Rows[0][0] + "'", conn);
                            cmd1.ExecuteNonQuery();
                            cmd1 = new SqlCommand("DELETE FROM weekly_events WHERE wEvent_id ='" + dtbl2.Rows[0][0] + "'", conn);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }
            }
            //MessageBox.Show("Your event added successfully");
            conn.Close();

        }
    }
}