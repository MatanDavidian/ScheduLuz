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

namespace main_screen.Student
{
    public partial class AppointmentPage : Form
    {
        
        public AppointmentPage()
        {
            InitializeComponent();
        }

        private void AppointmentPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentCalander frmCal = new StudentCalander();
            frmCal.Show();
            Visible = false;
        }
        Label[] labels = new Label[49];
        TableLayoutPanel Table = new TableLayoutPanel();
        String global_teacher_name;
        DateTime dt = DateTime.Today;

        private void submit_Click(object sender, EventArgs e)
        {
            
            
            Table.Controls.Clear();
            Table.RowStyles.Clear();

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
            labels[0].Text = "Sunday";
            Table.Controls.Add(labels[0], 1, 0);
            labels[1].Text = "Monday"; 
            Table.Controls.Add(labels[1], 2, 0);
            labels[2].Text = "Tuesday";
            Table.Controls.Add(labels[2], 3, 0);
            labels[3].Text = "Wednesday";
            Table.Controls.Add(labels[3], 4, 0);
            labels[4].Text = "Thursday";
            Table.Controls.Add(labels[4], 5, 0);
            labels[5].Text = "Friday";
            Table.Controls.Add(labels[5], 6, 0);

            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                labels[0].Name = (int.Parse(dt.Day.ToString())).ToString();
                labels[1].Name = (int.Parse(dt.Day.ToString()) + 1).ToString();
                labels[2].Name = (int.Parse(dt.Day.ToString()) + 2).ToString();
                labels[3].Name = (int.Parse(dt.Day.ToString()) + 3).ToString();
                labels[4].Name = (int.Parse(dt.Day.ToString()) + 4).ToString();
                labels[5].Name = (int.Parse(dt.Day.ToString()) + 5).ToString();
            }
            else if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                labels[0].Name = (int.Parse(dt.Day.ToString()) + 6).ToString();
                labels[1].Name = (int.Parse(dt.Day.ToString())).ToString();
                labels[2].Name = (int.Parse(dt.Day.ToString()) + 1).ToString();
                labels[3].Name = (int.Parse(dt.Day.ToString()) + 2).ToString();
                labels[4].Name = (int.Parse(dt.Day.ToString()) + 3).ToString();
                labels[5].Name = (int.Parse(dt.Day.ToString()) + 4).ToString();
            }
            else if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                labels[0].Name = (int.Parse(dt.Day.ToString()) + 5).ToString();
                labels[1].Name = (int.Parse(dt.Day.ToString()) + 6).ToString();
                labels[2].Name = (int.Parse(dt.Day.ToString())).ToString();
                labels[3].Name = (int.Parse(dt.Day.ToString()) + 1).ToString();
                labels[4].Name = (int.Parse(dt.Day.ToString()) + 2).ToString();
                labels[5].Name = (int.Parse(dt.Day.ToString()) + 3).ToString();
            }
            else if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                labels[0].Name = (int.Parse(dt.Day.ToString()) + 4).ToString();
                labels[1].Name = (int.Parse(dt.Day.ToString()) + 5).ToString();
                labels[2].Name = (int.Parse(dt.Day.ToString()) + 6).ToString();
                labels[3].Name = (int.Parse(dt.Day.ToString())).ToString();
                labels[4].Name = (int.Parse(dt.Day.ToString()) + 1).ToString();
                labels[5].Name = (int.Parse(dt.Day.ToString()) + 2).ToString();
            }
            else if (dt.DayOfWeek == DayOfWeek.Thursday)
            {
                labels[0].Name = (int.Parse(dt.Day.ToString()) + 3).ToString();
                labels[1].Name = (int.Parse(dt.Day.ToString()) + 4).ToString();
                labels[2].Name = (int.Parse(dt.Day.ToString()) + 5).ToString();
                labels[3].Name = (int.Parse(dt.Day.ToString()) + 6).ToString();
                labels[4].Name = (int.Parse(dt.Day.ToString())).ToString();
                labels[5].Name = (int.Parse(dt.Day.ToString()) + 1).ToString();
            }
            else if (dt.DayOfWeek == DayOfWeek.Friday)
            {
                labels[0].Name = (int.Parse(dt.Day.ToString()) + 2).ToString();
                labels[1].Name = (int.Parse(dt.Day.ToString()) + 3).ToString();
                labels[2].Name = (int.Parse(dt.Day.ToString()) + 4).ToString();
                labels[3].Name = (int.Parse(dt.Day.ToString()) + 5).ToString();
                labels[4].Name = (int.Parse(dt.Day.ToString()) + 6).ToString();
                labels[5].Name = (int.Parse(dt.Day.ToString())).ToString();
            }
            else if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                labels[0].Name = (int.Parse(dt.Day.ToString()) + 1).ToString();
                labels[1].Name = (int.Parse(dt.Day.ToString()) + 2).ToString();
                labels[2].Name = (int.Parse(dt.Day.ToString()) + 3).ToString();
                labels[3].Name = (int.Parse(dt.Day.ToString()) + 4).ToString();
                labels[4].Name = (int.Parse(dt.Day.ToString()) + 5).ToString();
                labels[5].Name = (int.Parse(dt.Day.ToString()) + 6).ToString();
            }
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
            

            string fullName = teacher_name.Text.ToString();
            var names = fullName.Split(' ');
            if (names.Length != 2)
            {
                teacher_name.Clear();
                MessageBox.Show("illegal name, enter first name and last name separate.");
                return ;
            }
            global_teacher_name = fullName;
            string firstName = names[0];
            string lastName = names[1];
            string queryteach = "Select * from users Where name = '" + firstName + "' and LastName = '" + lastName + "'";//Take all the teacher information
            dataBase dataBaseteach = new dataBase();
            SqlConnection conteach = dataBaseteach.connect_to_scheduluz_DB();
            SqlDataAdapter sdateach;
            DataTable dtblteach;
            conteach.Open();

            sdateach = new SqlDataAdapter(queryteach, conteach);
            dtblteach = new DataTable();
            sdateach.Fill(dtblteach);//Teacher user all details
            if(dtblteach.Rows.Count==0)
            {
                teacher_name.Clear();
                MessageBox.Show(fullName + " Does not exist. ");
                return;
            }
            if (dtblteach.Rows[0]["permission"].ToString().Trim() != "teacher")
            {
                teacher_name.Clear();
                MessageBox.Show(fullName + " Not a teacher. ");
                return;
            }

            //the next code take the teacher reception time
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl;
            conn.Open();
            string query = "Select * from weekly_events where user_id_OR_class=" + dtblteach.Rows[0]["Id"] + "and event_kind='" + "reception_hours" + "'";

            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            string hours;
            int k = 12;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {

                    labels[k] = new Label { BackColor = Color.DarkRed, Dock = DockStyle.Fill };
                    Table.Controls.Add(labels[k], j, i);
                    labels[k].Text = labels[i + 5].Text;//the hours text
                    labels[k].TextAlign = ContentAlignment.MiddleCenter;
                    labels[k].ForeColor = Color.Black;

                    for (int m = 0; m < dtbl.Rows.Count; m++)
                    {
                        hours = dtbl.Rows[m]["start"].ToString().Trim() + "-" + dtbl.Rows[m]["ends"].ToString().Trim();
                        if (labels[k].Text.Trim() == hours && labels[k % 6].Text.Trim() == dtbl.Rows[m]["day_in_week"].ToString().Trim())
                        {
                            labels[k].BackColor = Color.LightGreen;
                            labels[k].ForeColor = Color.Black;
                        }
                    }
                    if(labels[k].BackColor == Color.LightGreen)
                    {/* + "and event_kind='" + "reception_hours" + "'"*/
                        labels[k].Click += new System.EventHandler(LabelClick);
                        SqlDataAdapter sda0;
                        DataTable dtbl0, dtbl1;
                        string already_exist;
                        string query0 = "Select * from Events_to_Users where User_Id='" + log_in_page.userId + "'";
                        sda0 = new SqlDataAdapter(query0, conn);
                        dtbl0 = new DataTable();
                        sda0.Fill(dtbl0);
                        bool flag=false;
                        for (int m = 0; m < dtbl0.Rows.Count; m++)//***CHECK IF THE EVENT IS ALREADY EXIST.
                        {//labels[i].Text.ToString().Trim() == already_exist && 

                            query0 = "Select * from Events where Event_id = '" + dtbl0.Rows[m]["Event_ID"] + "'";
                            sda0 = new SqlDataAdapter(query0, conn);
                            dtbl1 = new DataTable();
                            sda0.Fill(dtbl1);

                            already_exist = dtbl1.Rows[0]["hours_start"].ToString().Trim() + "-" + dtbl1.Rows[0]["hours_end"].ToString().Trim();
                            DateTime.TryParse(dtbl1.Rows[0]["date"].ToString().Trim(), out dt);
                            if (dtbl1.Rows[0]["event_kind"].ToString().Trim() == "reception_hour" && labels[i+5].Text.ToString().Trim() == already_exist && labels[k % 6].Name == dt.Day.ToString().Trim())
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag)//IF the event already exist.
                        {
                            flag = false;
                            labels[k].BackColor = Color.YellowGreen;
                        }
                        //cmd.ExecuteNonQuery();

                        
                    }
                    
                    k++;
                }
            }

        }
        private void LabelClick(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label.BackColor == Color.YellowGreen)
            {
                label.ForeColor = Color.Black;
                label.BackColor = Color.LightGreen;
            }
            else
            {
                label.ForeColor = Color.Black;
                label.BackColor = Color.YellowGreen;
            }
        }

        private void teacher_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string day;
            string start, end;
            int int_start, int_end;
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda0, sda2;
            DataTable dtbl0, dtbl1, dtbl2;

            conn.Open();
            //string find_
            string query0 = "Select * from Events_to_Users where User_Id='" + log_in_page.userId + "'";/* + "and event_kind='" + "reception_hours" + "'"*/
            sda0 = new SqlDataAdapter(query0, conn);
            dtbl0 = new DataTable();
            sda0.Fill(dtbl0);
            string already_exist;
            bool flag = false;
            bool flag2 = false;
            for (int i = 12; i < 48; i++)
            {
                if (labels[i].BackColor == Color.YellowGreen)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,up_for_cancellation) VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@up_for_cancellation) ", conn);

                    cmd.Parameters.Add("@up_for_cancellation", "NO");
                    cmd.Parameters.Add("@event_kind", "reception_hour");
                    cmd.Parameters.Add("@Event_name", "reception hour");

                    dt=dt.AddDays(int.Parse(labels[i % 6].Name)- dt.Day);
                    cmd.Parameters.Add("@date", dt);

                    var hours = (labels[i].Text.ToString()).Split('-');//label text = hours start and end.
                    start = hours[0];
                    end = hours[1];
                    int_start = int.Parse(start);
                    int_end = int.Parse(end);

                    cmd.Parameters.Add("@hours_start", int_start);
                    cmd.Parameters.Add("@minutes_start", "0");
                    cmd.Parameters.Add("@hours_end", int_end);
                    cmd.Parameters.Add("@minutes_end", "0");
                    cmd.Parameters.Add("@Event_details", "reception hour of: " + global_teacher_name);

                    cmd.Parameters.Add("@Place", "at school.");

                    

                    for (int m = 0; m < dtbl0.Rows.Count; m++)//***CHECK IF THE EVENT IS ALREADY EXIST.
                    {//labels[i].Text.ToString().Trim() == already_exist && 

                        query0 = "Select * from Events where Event_id = '" + dtbl0.Rows[m]["Event_ID"] + "'";
                        sda0 = new SqlDataAdapter(query0, conn);
                        dtbl1 = new DataTable();
                        sda0.Fill(dtbl1);
                        if (dtbl1.Rows.Count > 0)
                        {
                            already_exist = dtbl1.Rows[0]["hours_start"].ToString().Trim() + "-" + dtbl1.Rows[0]["hours_end"].ToString().Trim();
                            DateTime.TryParse(dtbl1.Rows[0]["date"].ToString().Trim(), out dt);
                            if (dtbl1.Rows[0]["event_kind"].ToString().Trim() == "reception_hour" && labels[i].Text.ToString().Trim() == already_exist && labels[i % 6].Name == dt.Day.ToString().Trim())
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                    if (flag)//IF the event already exist.
                    {
                        flag = false;
                        continue;
                    }

                    cmd.ExecuteNonQuery();


                    //take the max id event from Event table
                    string query = "Select MAX(Event_ID) from Events";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    int eve_id = int.Parse(dtbl.Rows[0][0].ToString().Trim());

                    //insert the max id event and the event id to events to users table
                    cmd = new SqlCommand("INSERT INTO Events_to_Users (Event_ID,User_ID) VALUES(@Event_ID,@User_ID) ", conn);
                    cmd.Parameters.Add("@Event_ID", eve_id);
                    cmd.Parameters.Add("@User_ID", log_in_page.userId);
                    cmd.ExecuteNonQuery();
                }
                else if(labels[i].BackColor == Color.LightGreen)
                {
                    for (int m = 0; m < dtbl0.Rows.Count; m++)//***CHECK IF THE EVENT IS ALREADY EXIST AND HAS TO BE DELETED.
                    {

                        query0= "Select * from Events where Event_id = '" + dtbl0.Rows[m]["Event_ID"] + "'";
                        sda0 = new SqlDataAdapter(query0, conn);
                        dtbl1 = new DataTable();
                        sda0.Fill(dtbl1);


                        if (dtbl1.Rows.Count > 0)
                        {
                            already_exist = dtbl1.Rows[0]["hours_start"].ToString().Trim() + "-" + dtbl1.Rows[0]["hours_end"].ToString().Trim();
                            //DateTime day_on_week;
                            DateTime.TryParse(dtbl1.Rows[0]["date"].ToString().Trim(), out dt);

                            if (dtbl1.Rows[0]["event_kind"].ToString().Trim() == "reception_hour" && labels[i].Text.ToString().Trim() == already_exist && labels[i % 6].Name == dt.Day.ToString().Trim())
                            {


                                SqlCommand cmd1 = new SqlCommand("DELETE FROM Events WHERE Event_id ='" + dtbl1.Rows[0]["Event_id"] + "'", conn);
                                cmd1.ExecuteNonQuery();
                                cmd1 = new SqlCommand("DELETE FROM Events_to_Users WHERE Event_ID ='" + dtbl1.Rows[0]["Event_id"] + "'", conn);
                                cmd1.ExecuteNonQuery();

                            }
                        }
                    }
                }
            }
            //MessageBox.Show("Your event added successfully");
            conn.Close();
        }
    }
}