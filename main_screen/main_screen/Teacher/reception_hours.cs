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
            labels[0].Text = "MONDAY";
            Table.Controls.Add(labels[0], 1, 0);
            labels[1].Text = "SUNDAY";
            Table.Controls.Add(labels[1], 2, 0);
            labels[2].Text = "TUESDAY";
            Table.Controls.Add(labels[2], 3, 0);
            labels[3].Text = "WEDNESDAY";
            Table.Controls.Add(labels[3], 4, 0);
            labels[4].Text = "THURSDAY";
            Table.Controls.Add(labels[4], 5, 0);
            labels[5].Text = "FRIDAY";
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
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    labels[k] = new Label { BackColor = Color.DarkRed, Dock = DockStyle.Fill };
                    Table.Controls.Add(labels[k], i, j);
                    labels[k].Click += new System.EventHandler(labelClick);
                    labels[k].Text = labels[i+5].Text;
                    labels[k].TextAlign = ContentAlignment.MiddleCenter;
                    labels[k].ForeColor = Color.DarkRed;
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
            /*
            for (int i = 12; i < 48; i++)
            {
                if(labels[i].BackColor==Color.LightGreen)
                {
                    dataBase dataBase = new dataBase();
                    SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,event_privacy,up_for_cancellation) VALUES(@Event_name,@event_kind,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@private_B,@up_for_cancellation) ", conn);

                    cmd.Parameters.Add("@up_for_cancellation", "NO");
                    cmd.Parameters.Add("@event_kind", "reception hours");
                    cmd.Parameters.Add("@Event_name", log_in_page.loginUserName.ToString()+ " reception hours");
                    cmd.Parameters.Add("@date", " ");
                    cmd.Parameters.Add("@hours_start", " ");
                    cmd.Parameters.Add("@minutes_start", " ");
                    cmd.Parameters.Add("@hours_end", " ");
                    cmd.Parameters.Add("@minutes_end", " ");
                    cmd.Parameters.Add("@Event_details", "my reception hours");
                    cmd.Parameters.Add("@private_B", "Public");
                    cmd.Parameters.Add("@Place", "SCHOOL");
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
                }
            }
            */
        }
    }
}