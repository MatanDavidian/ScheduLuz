using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using database_location;

namespace main_screen.Teacher
{
    public partial class ask_for_cancelation : Form
    {
        public ask_for_cancelation()
        {
            InitializeComponent();
        }
        Label[] labels = new Label[91];
        TableLayoutPanel Table = new TableLayoutPanel();
        DateTime dt = DateTime.Today;
        private void ask_for_cancelation_Load(object sender, EventArgs e)
        {
            Table.Controls.Clear();
            Table.RowStyles.Clear();

            Table.Location = new Point(70, 90);
            Table.Size = new Size(536, 250);
            Table.AutoSize = true;
            Table.Name = "Desk";
            Table.ColumnCount = 7;
            Table.RowCount = 13;
            Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            Table.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            this.Controls.Add(Table);


            for (int i = 0; i < 6; i++)
            {
                labels[i] = new Label { BackColor = Color.DarkGreen, ForeColor = Color.White, Dock = DockStyle.Fill };
                Table.Controls.Add(labels[i], i + 1, 0);
            }
            labels[0].Text = "Sunday";
            labels[1].Text = "Monday";
            labels[2].Text = "Tuesday";
            labels[3].Text = "Wednesday";
            labels[4].Text = "Thursday";
            labels[5].Text = "Friday";


            for (int i = 6; i < 18; i++)
            {
                labels[i] = new Label { BackColor = Color.Green, ForeColor = Color.White, Dock = DockStyle.Fill };
                Table.Controls.Add(labels[i], 0, i - 5);
            }
            labels[6].Text = "8-9";
            labels[7].Text = "9-10";
            labels[8].Text = "10-11";
            labels[9].Text = "11-12";
            labels[10].Text = "12-13";
            labels[11].Text = "13-14";
            labels[12].Text = "14-15";
            labels[13].Text = "15-16";
            labels[14].Text = "16-17";
            labels[15].Text = "17-18";
            labels[16].Text = "18-19";
            labels[17].Text = "19-20";

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl,dt_reqest, db_delete;
            conn.Open();

            string query = "Select * from weekly_events where user_id_OR_class='" + log_in_page.userId + "'";
            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);

            query = "Select * from Request_to_cancel";
            sda = new SqlDataAdapter(query, conn);
            dt_reqest = new DataTable();
            sda.Fill(dt_reqest);


            string hours;
            int k = 18;
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    labels[k] = new Label {Text="", BackColor = Color.LightGreen, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter};
                    Table.Controls.Add(labels[k], j, i);
                    
                    for (int m = 0; m < dtbl.Rows.Count; m++)
                    {
                        hours = dtbl.Rows[m]["start"].ToString().Trim() + "-" + dtbl.Rows[m]["ends"].ToString().Trim();
                        if (labels[i + 5].Text.Trim() == hours && labels[k % 6].Text.Trim() == dtbl.Rows[m]["day_in_week"].ToString().Trim())
                        {
                            labels[k].Text = dtbl.Rows[m]["title"].ToString().Trim();

                            for(int l=0;l< dt_reqest.Rows.Count; l++)
                            {
                                if(dtbl.Rows[m]["wEvent_id"].ToString().Trim()== dt_reqest.Rows[l]["wEvent_id"].ToString().Trim() && dt_reqest.Rows[l]["approved_condition"].ToString().Trim() != "approved")
                                {
                                    if(dt_reqest.Rows[l]["approved_condition"].ToString().Trim()== "rejected")
                                    {
                                        labels[k].BackColor = Color.Red;
                                    }
                                    else if (dt_reqest.Rows[l]["approved_condition"].ToString().Trim() == "approved")
                                    {
                                        labels[k].Text = "approved";
                                        labels[k].BackColor = Color.LimeGreen;
                                    }
                                    else if (dt_reqest.Rows[l]["approved_condition"].ToString().Trim() == "send")
                                    {
                                        labels[k].Text = "Request sent";
                                        labels[k].BackColor = Color.Yellow;
                                    }
                                }

                            }
                           
                            for (int l = 0; l < dt_reqest.Rows.Count; l++)
                            {
                                query = "Select * from Request_to_cancel where approved_condition= '" + "approved" + "'";
                                sda = new SqlDataAdapter(query, conn);
                                db_delete = new DataTable();
                                sda.Fill(db_delete);
                                if (db_delete.Rows.Count!=0 && dt_reqest.Rows[l]["approved_condition"].ToString().Trim() == "approved")
                                {
                                    labels[k].Text = "approved";
                                    labels[k].BackColor = Color.LimeGreen;
                                    labels[k].Click += new System.EventHandler(LabelClick);
                                    SqlCommand cmd = new SqlCommand("DELETE FROM Request_to_cancel WHERE wEvent_id ='" + dt_reqest.Rows[l]["wEvent_id"] + "'", conn);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            string id = dtbl.Rows[m]["wEvent_id"].ToString().Trim();
                            labels[k].Click += new System.EventHandler(LabelClick);

                        }
                    }  
                    k++;
                }
            }
        }

        private void LabelClick(object sender, EventArgs e)
        {

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl;
            conn.Open();

            var label = sender as Label;
            
            if(label.BackColor == Color.LightGreen) 
            {
                label.BackColor = Color.MediumSeaGreen;
            }
            else if (label.BackColor == Color.Red)
            {   
                string query = "Select wEvent_id from Request_to_cancel where user_id='" + log_in_page.userId + "'" + " and approved_condition ='" + "rejected" + "'";
                sda = new SqlDataAdapter(query, conn);
                dtbl = new DataTable();
                sda.Fill(dtbl);
                for(int i=0;i<dtbl.Rows.Count;i++)
                {
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Request_to_cancel WHERE wEvent_id ='" + dtbl.Rows[i]["wEvent_id"] + "'", conn);
                    cmd1.ExecuteNonQuery();
                }
                label.BackColor = Color.LightGreen;
            }
            else if (label.BackColor == Color.LimeGreen)
            {
                string query = "Select wEvent_id from Request_to_cancel where user_id='" + log_in_page.userId + "'" + " and approved_condition ='" + "approved" + "'";
                sda = new SqlDataAdapter(query, conn);
                dtbl = new DataTable();
                sda.Fill(dtbl);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Request_to_cancel WHERE wEvent_id ='" + dtbl.Rows[i]["wEvent_id"] + "'", conn);
                    cmd1.ExecuteNonQuery();
                }
                label.Text = "";
                label.BackColor = Color.LightGreen;
            }
            else if(label.BackColor == Color.MediumSeaGreen)
            {
                label.BackColor = Color.LightGreen;
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            TeacherCalander n = new TeacherCalander();
            n.Show();
            this.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string help;
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda0;
            DataTable dtbl0;

            conn.Open();

            string query0 = "Select * from weekly_events where user_Id_OR_class='" + log_in_page.userId + "'";
            sda0 = new SqlDataAdapter(query0, conn);
            dtbl0 = new DataTable();
            sda0.Fill(dtbl0);
            int eve_ask_cancel=0;
            for (int i = 18; i < 90; i++)
            {
                if (labels[i].BackColor == Color.MediumSeaGreen)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Request_to_cancel(user_id,wEvent_id,reason,approved_condition) VALUES(@user_id,@wEvent_id,@reason,@approved_condition) ", conn);

                    cmd.Parameters.Add("@approved_condition", "send");
                    cmd.Parameters.Add("@user_id", log_in_page.userId);
                    help = reason.Text;
                    help = help.Replace("'", string.Empty);
                    cmd.Parameters.Add("@reason", help);
                    for (int j=0;j<dtbl0.Rows.Count;j++)
                    {
                        if(dtbl0.Rows[j]["day_in_week"].ToString().Trim()== labels[i%6].Text &&
                            dtbl0.Rows[j]["start"].ToString().Trim() + "-" + dtbl0.Rows[j]["ends"].ToString().Trim() == labels[(i / 6)+3].Text)
                        {
                            eve_ask_cancel = int.Parse(dtbl0.Rows[j]["wEvent_id"].ToString().Trim());
                            cmd.Parameters.Add("@wEvent_id", eve_ask_cancel);
                            break;
                        }
                    }
                    cmd.ExecuteNonQuery();
                    labels[i].Text = "Request sent";
                    labels[i].BackColor = Color.Yellow;
                }

            }
            //MessageBox.Show("Your event added successfully");
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
