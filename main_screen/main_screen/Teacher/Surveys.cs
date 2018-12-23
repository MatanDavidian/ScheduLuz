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
    public partial class Surveys : Form
    {
        public Surveys()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            TeacherCalander frmCal = new TeacherCalander();
            frmCal.Show();
            Visible = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }


        private void Submit_Click(object sender, EventArgs e)
        {
            if (question_txt.Text == "")
            {
                MessageBox.Show("please fill the title");
            }
            else if (answersOpA.Text == "")
            {
                MessageBox.Show("please fill the place");

            }
            else if (answersOpB.Text == "")
            {
                MessageBox.Show("please fill the place");

            }
            else if (answersOpC.Text == "")
            {
                MessageBox.Show("please fill the place");

            }
            else if (answersOpD.Text == "")
            {
                MessageBox.Show("please fill the place");

            }
            else
            {

                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                conn.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_name,event_kind,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,up_for_cancellation) VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@up_for_cancellation) ", conn);

                SqlCommand cmd = new SqlCommand("INSERT INTO surveys(sender_id,date,grade,class,question,answerA,answerB,answerC,answerD,resultA,resultB,resultC,resultD) VALUES(@sender_id,@date,@grade,@class,@question,@answerA,@answerB,@answerC,@answerD,@resultA,@resultB,@resultC,@resultD) ", conn);
                cmd.Parameters.Add("@sender_id", int.Parse(log_in_page.userId));
                DateTime dt = DateTime.Today;
                cmd.Parameters.Add("@date", dt);
                cmd.Parameters.Add("@grade", grade_cb.Text);
                string clas = class_num_cb.Text.ToString();
                cmd.Parameters.Add("@class", int.Parse(clas));
                cmd.Parameters.Add("@question", question_txt.Text);
                cmd.Parameters.Add("@answerA", answersOpA.Text);
                cmd.Parameters.Add("@answerB", answersOpB.Text);
                cmd.Parameters.Add("@answerC", answersOpC.Text);
                cmd.Parameters.Add("@answerD", answersOpD.Text);
                cmd.Parameters.Add("@resultA", int.Parse("0"));
                cmd.Parameters.Add("@resultB", int.Parse("0"));
                cmd.Parameters.Add("@resultC", int.Parse("0"));
                cmd.Parameters.Add("@resultD", int.Parse("0"));

                cmd.ExecuteNonQuery();
                string query= "Select Max(surveys_id) from surveys";
                SqlDataAdapter sda;
                DataTable dtbl;
                sda = new SqlDataAdapter(query, conn);
                dtbl = new DataTable();
                sda.Fill(dtbl);
                int surveys_id = int.Parse(dtbl.Rows[0][0].ToString());

                query = "Select Id from users where grade='" + grade_cb.Text + "'" + "And classNumber ='" + clas + "'";
                sda = new SqlDataAdapter(query, conn);
                dtbl = new DataTable();
                sda.Fill(dtbl);
                for(int i=0;i<dtbl.Rows.Count;i++)
                {
                    cmd = new SqlCommand("INSERT INTO surveys_to_users(surveys_id,user_id,answer) VALUES(@surveys_id,@user_id,@answer)", conn);
                    cmd.Parameters.Add("@surveys_id", surveys_id);
                    cmd.Parameters.Add("@user_id", dtbl.Rows[i][0]);
                    cmd.Parameters.Add("@answer", false);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void class_num_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grade_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void surveys_results_Click(object sender, EventArgs e)
        {
            Teacher.surveys_results n = new Teacher.surveys_results();
            n.Show();
            this.Hide();
        }

        private void Surveys_Load(object sender, EventArgs e)
        {

        }
    }
}
