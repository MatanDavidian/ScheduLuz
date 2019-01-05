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
using USER;
using database_location;


namespace main_screen.Teacher
{
    public partial class AppointmentBetweenStudents : Form
    {
        public AppointmentBetweenStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

   
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void student_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = student_lst.SelectedIndex;
                to_txt.Text = student_lst.Items[index].ToString();
            }
            catch
            {

            }
        }

        private void to_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            TeacherCalander n = new TeacherCalander();
            this.Hide();
            n.Show();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (title_txt.Text == "")
            {
                MessageBox.Show("please fill the title");
            }
            else if (place_txt.Text == "")
            {
                MessageBox.Show("please fill the place");

            }
            else if (hours_start.Value > hours_end.Value)
            {
                MessageBox.Show("your start hours is later than your end hours.");
            }
            else if (hours_start.Value == hours_end.Value && minutes_start.Value >= minutes_end.Value)
            {
                MessageBox.Show("your start hour is later or equal to your end hour.");
            }
            else if (send_to_lst.Items.Count == 0)
            {
                MessageBox.Show("there are no student to invite.");
            }
            else if (send_to_lst.Items.Count == 1)
            {
                MessageBox.Show("please choose two students.");
            }
            else
            {
                string help;
                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                conn.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,up_for_cancellation) VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@up_for_cancellation) ", conn);

                SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,up_for_cancellation) VALUES(@Event_name,@event_kind,@up_for_cancellation) ", conn);
                cmd.Parameters.Add("@up_for_cancellation", "YES");
                cmd.Parameters.Add("@event_kind", "Muliplayer");
                help = title_txt.Text;
                help = help.Replace("'", string.Empty);
                cmd.Parameters.Add("@Event_name", help);
                cmd.ExecuteNonQuery();


                //cmd.ExecuteNonQuery();

                //take the max id event from Event table
                string query = "Select MAX(Event_id) from Events";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                string event_id = "";

                if (dtb.Rows.Count > 0)
                {
                    event_id = dtb.Rows[0][0].ToString().Trim();
                }


                int event_Id = Int32.Parse(event_id);

                help = place_txt.Text;
                help = help.Replace("'", string.Empty);
                SqlCommand cmd0 = new SqlCommand("UPDATE Events SET event_place ='" + help + "' WHERE Event_id ='" + event_id + "'", conn);
                cmd0.ExecuteNonQuery();


                SqlCommand cmd1 = new SqlCommand("UPDATE Events SET event_privacy ='public' WHERE Event_id ='" + event_id + "'", conn);
                cmd1.ExecuteNonQuery();
                help = details_txt.Text;
                help = help.Replace("'", string.Empty);
                SqlCommand cmd2 = new SqlCommand("UPDATE Events SET Event_details ='" + help + "'WHERE Event_id ='" + event_id + "'", conn);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("UPDATE Events SET date ='" + date_pkr.Text + "'WHERE Event_id ='" + event_id + "'", conn);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd4 = new SqlCommand("UPDATE Events SET hours_start ='" + hours_start.Text + "'WHERE Event_id ='" + event_id + "'", conn);
                cmd4.ExecuteNonQuery();

                SqlCommand cmd5 = new SqlCommand("UPDATE Events SET minutes_start ='" + minutes_start.Text + "'WHERE Event_id ='" + event_id + "'", conn);
                cmd5.ExecuteNonQuery();

                SqlCommand cmd6 = new SqlCommand("UPDATE Events SET hours_end ='" + hours_end.Text + "'WHERE Event_id ='" + event_id + "'", conn);
                cmd6.ExecuteNonQuery();

                SqlCommand cmd7 = new SqlCommand("UPDATE Events SET minutes_end ='" + minutes_end.Text + "'WHERE Event_id ='" + event_id + "'", conn);
                cmd7.ExecuteNonQuery();

                for (int i = 0; i < send_to_lst.Items.Count; i++)
                {
                    string username = send_to_lst.Items[i].ToString().Replace(" ", "");

                    string queryTogetStudentID = "Select id from connection_details Where userName = '" + username + "'";
                    SqlDataAdapter sda6 = new SqlDataAdapter(queryTogetStudentID, conn);
                    DataTable dtb6 = new DataTable();
                    sda6.Fill(dtb6);
                    string sendToId = dtb6.Rows[0][0].ToString().Trim();

                    cmd = new SqlCommand("INSERT INTO Events_to_Users(Event_ID,User_ID) VALUES(@Event_ID,@User_ID) ", conn);
                    cmd.Parameters.Add("@Event_ID", event_Id);
                    cmd.Parameters.Add("@User_ID", sendToId);

                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Your Event has added for: " + username);
                }

                MessageBox.Show("The meeting was scheduled.");

                TeacherCalander n = new TeacherCalander();
                n.Show();
                this.Hide();
            }
        }

        private void to_txt_TextChanged_1(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query = "Select id,name,lastName from users Where permission = 'student'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            student_lst.Items.Clear();

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string temp = dtb.Rows[i]["name"].ToString().Trim().ToUpper() + " " + dtb.Rows[i]["lastName"].ToString().Trim().ToUpper();

                if (temp.Contains(to_txt.Text.ToUpper()) && !send_to_lst.Items.Contains(temp))
                {
                    student_lst.Items.Add(dtb.Rows[i]["name"].ToString().Trim() + " " + dtb.Rows[i]["lastName"].ToString().Trim());
                }
            }
        }

        private void student_lst_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int index = student_lst.SelectedIndex;
                to_txt.Text = student_lst.Items[index].ToString();
            }
            catch
            {

            }
        }

     

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            if (send_to_lst.Items.Count<2 && student_lst.Items.Contains(to_txt.Text) && !send_to_lst.Items.Contains(to_txt.Text.ToUpper()))
            {
                send_to_lst.Items.Add(to_txt.Text.ToUpper());
                to_txt.Clear();
            }
        }

        private void clear_btn_Click_1(object sender, EventArgs e)
        {
            send_to_lst.Items.Clear();
        }

        private void send_to_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentBetweenStudents_Load(object sender, EventArgs e)
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
    }
}
