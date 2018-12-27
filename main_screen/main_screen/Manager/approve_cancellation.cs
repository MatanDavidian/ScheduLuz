using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using database_location;
using System.Drawing;
using System.Collections.Generic;
namespace main_screen.Manager
{
    public partial class approve_cancellation : Form
    {
        public approve_cancellation()
        {
            InitializeComponent();
        }
        private void Return_Click(object sender, EventArgs e)
        {
            ManagerCalander n = new ManagerCalander();
            n.Show();
            this.Hide();
        }

        private void approve_cancellation_Load(object sender, EventArgs e)
        {
            //vScrollBar1 viewer = new vScrollBar1();
            //viewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            //vScrollBar1.AutoScrollOffset
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dt_reqest,dt_event,dt_users;
            conn.Open();

            string query = "Select * from Request_to_cancel where approved_condition= '" + "send" + "'";
            sda = new SqlDataAdapter(query, conn);
            dt_reqest = new DataTable();
            sda.Fill(dt_reqest);
          
            int help = 0;//check if has a request for cancelltion
            if (dt_reqest.Rows.Count > 0)
            {
                help = 1;
            }
            Label[] labels = new Label[dt_reqest.Rows.Count * 5 +(help*5)];
            Button[] buttons = new Button[dt_reqest.Rows.Count * 2];
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Controls.Clear();
            Table.RowStyles.Clear();

            Table.Location = new Point(50, 90);
            Table.Size = new Size(536, 250);
            Table.AutoSize = true;
            Table.Name = "Desk";
            Table.ColumnCount = 7;
            Table.RowCount = dt_reqest.Rows.Count + help;
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            Table.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            this.Controls.Add(Table);
            int k = 0;


            for (int i = 0; i < dt_reqest.Rows.Count+help; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    labels[k] = new Label { BackColor = Color.Wheat, ForeColor = Color.Black, Dock = DockStyle.Fill };
                    Table.Controls.Add(labels[k], j, i);

                    k++;
                }
                if (i != 0)
                {
                    query = "Select * from weekly_events Where wEvent_id ='" + dt_reqest.Rows[i - 1]["wEvent_id"] + "'";
                    sda = new SqlDataAdapter(query, conn);
                    dt_event = new DataTable();
                    sda.Fill(dt_event);

                    query = "Select * from users Where Id ='" + dt_reqest.Rows[i - 1]["user_id"] + "'";
                    sda = new SqlDataAdapter(query, conn);
                    dt_users = new DataTable();
                    sda.Fill(dt_users);

                    labels[k - 5].Text = dt_users.Rows[0]["name"].ToString().Trim() + " " + dt_users.Rows[0]["lastName"].ToString().Trim();
                    labels[k - 4].Text = dt_event.Rows[0]["title"].ToString().Trim();
                    labels[k - 3].Text = dt_event.Rows[0]["day_in_week"].ToString().Trim();
                    labels[k - 2].Text = dt_event.Rows[0]["start"].ToString().Trim() + "-" + dt_event.Rows[0]["ends"].ToString().Trim();
                    labels[k - 1].Text = dt_reqest.Rows[i-1]["reason"].ToString().Trim();
                }
            }
            if (help != 0)
            {
                labels[0].Text = "name";
                labels[0].BackColor = Color.Tan;
                labels[1].Text = "lesson";
                labels[1].BackColor = Color.Tan;
                labels[2].Text = "day";
                labels[2].BackColor = Color.Tan;
                labels[3].Text = "hour";
                labels[3].BackColor = Color.Tan;
                labels[4].Text = "reason";
                labels[4].BackColor = Color.Tan;
            }
            k =0;
            for (int i = help; i < dt_reqest.Rows.Count+ help; i++)
            {
                buttons[i - help] = new Button { Name=(i-help).ToString()+"S",BackColor = Color.SaddleBrown, ForeColor = Color.White, Dock = DockStyle.Fill, Text= "accept" };
                buttons[i - help].Click += new System.EventHandler(LabelClick);
                Table.Controls.Add(buttons[i - help], 5, i);

            }
            for (int i = help; i < dt_reqest.Rows.Count+ help; i++)
            {
                buttons[dt_reqest.Rows.Count+i-help] = new Button { Name = (i-help).ToString() + "D",BackColor = Color.SaddleBrown, ForeColor = Color.White, Dock = DockStyle.Fill, Text = "reject" };
                buttons[dt_reqest.Rows.Count+i- help].Click += new System.EventHandler(LabelClick);
                Table.Controls.Add(buttons[dt_reqest.Rows.Count+i - help], 6, i);
            }

        }

        private void LabelClick(object sender, EventArgs e)
        {
            var button = sender as Button;

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dt_reqest;
            conn.Open();

            string query = "Select * from Request_to_cancel where approved_condition= '"+"send" +"'";
            sda = new SqlDataAdapter(query, conn);
            dt_reqest = new DataTable();
            sda.Fill(dt_reqest);

            for (int i = 0; i < dt_reqest.Rows.Count; i++)
            {
                if (button.Name == i.ToString()+"S")
                {
                    SqlCommand cmd;
                    cmd = new SqlCommand("DELETE FROM weekly_events WHERE wEvent_id ='" + dt_reqest.Rows[i]["wEvent_id"] + "'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM Request_to_cancel WHERE wEvent_id ='" + dt_reqest.Rows[i]["wEvent_id"] + "'", conn);
                    cmd.ExecuteNonQuery();
                    Manager.approve_cancellation n = new Manager.approve_cancellation();
                    n.Show();
                    this.Hide();
                }
                else if (button.Name == i.ToString()+"D")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Request_to_cancel SET approved_condition ='" + "rejected" + "' WHERE wEvent_id ='" + dt_reqest.Rows[i]["wEvent_id"] + "'", conn);
                    cmd.ExecuteNonQuery();
                    Manager.approve_cancellation n = new Manager.approve_cancellation();
                    n.Show();
                    this.Hide();
                }
            }

        }
    }
}
