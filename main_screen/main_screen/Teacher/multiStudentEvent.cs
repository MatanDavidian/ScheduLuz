using database_location;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace main_screen.Teacher
{
    public partial class multiStudentEvent : Form
    {
        public multiStudentEvent()
        {
            InitializeComponent();
        }

        private void to_txt_TextChanged(object sender, EventArgs e)
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

        

        private void multiStudentEvent_Load(object sender, EventArgs e)
        {
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(student_lst.Items.Contains(to_txt.Text) && !send_to_lst.Items.Contains(to_txt.Text.ToUpper()))
            {
                send_to_lst.Items.Add(to_txt.Text.ToUpper());
                to_txt.Clear();
            }
            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            send_to_lst.Items.Clear();

            
            
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

        private void create_btn_Click(object sender, EventArgs e)
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
            else
            {

                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                conn.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,up_for_cancellation) VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@up_for_cancellation) ", conn);

                SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,up_for_cancellation) VALUES(@Event_name,@event_kind,@up_for_cancellation) ", conn);
                cmd.Parameters.Add("@up_for_cancellation", "YES");
                cmd.Parameters.Add("@event_kind", "Muliplayer");
                cmd.Parameters.Add("@Event_name", title_txt.Text);
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





                SqlCommand cmd1 = new SqlCommand("UPDATE Events SET event_privacy ='public' WHERE Event_id ='" + event_id + "'", conn);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("UPDATE Events SET Event_details ='" + details_txt.Text + "'WHERE Event_id ='" + event_id + "'", conn);
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
                cmd = new SqlCommand("INSERT INTO Events_to_Users(Event_ID,User_ID) VALUES(@Event_ID,@User_ID) ", conn);
                cmd.Parameters.Add("@Event_ID", event_Id);
                cmd.Parameters.Add("@User_ID", log_in_page.userId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Your Event has added.");

                TeacherCalander n = new TeacherCalander();
                n.Show();
                this.Hide();
            }

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            TeacherCalander n = new TeacherCalander();
            n.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();

            string query;

            if(class_num_cb.Text=="ALL")
            {
                query = "Select name,lastName from users where grade ='" + grade_cb.Text + "'";
            }
            else
            {
                query = "Select name,lastName from users where grade ='" + grade_cb.Text + "' and classNumber='"+class_num_cb.Text+"'";
            }
            
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            for (int i = 0; i<dtb.Rows.Count; i++)
            {
                string student = dtb.Rows[i]["name"].ToString().Trim().ToUpper() + " " + dtb.Rows[i]["lastName"].ToString().Trim().ToUpper();
                if(!send_to_lst.Items.Contains(student))
                send_to_lst.Items.Add(student);
            }
        }
    }
    
}
