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
    public partial class surveys_results : Form
    {
        public surveys_results()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Teacher.Surveys n = new Teacher.Surveys();
            n.Show();
            this.Hide();
        }

        private void survey_Click(object sender, EventArgs e)
        {

        }

        private void surveys_results_Load(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl;
            conn.Open();
            string query = "Select * from surveys where sender_id='" + int.Parse(log_in_page.userId) + "'";

            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);

            for (int i = 0; i < dtbl.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dtbl.Rows[i]["date"].ToString().Trim());
                item.SubItems.Add(dtbl.Rows[i]["question"].ToString().Trim());
                listView.Items.Add(item);
            }
            
            //if()

            
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView.SelectedIndices[0];
                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();
                SqlDataAdapter sda;
                DataTable dtbl;
                conn.Open();
                string query = "Select * from surveys where sender_id='" + int.Parse(log_in_page.userId) + "'";

                sda = new SqlDataAdapter(query, conn);
                dtbl = new DataTable();
                sda.Fill(dtbl);
                
                string quest = dtbl.Rows[selectedIndex]["question"].ToString();
                string ans1 = dtbl.Rows[selectedIndex]["answerA"].ToString();
                string ans2 = dtbl.Rows[selectedIndex]["answerB"].ToString();
                string ans3 = dtbl.Rows[selectedIndex]["answerC"].ToString();
                string ans4 = dtbl.Rows[selectedIndex]["answerD"].ToString();
                int res1= int.Parse(dtbl.Rows[selectedIndex]["resultA"].ToString());
                int res2 = int.Parse(dtbl.Rows[selectedIndex]["resultB"].ToString());
                int res3 = int.Parse(dtbl.Rows[selectedIndex]["resultC"].ToString());
                int res4 = int.Parse(dtbl.Rows[selectedIndex]["resultD"].ToString());

                survey.Series["Salary"].Points.Clear();
                survey.Titles.Clear();
                survey.Titles.Add(quest);
                survey.Series["Salary"].Points.AddXY(ans1, res1);
                survey.Series["Salary"].Points.AddXY(ans2, res2);
                survey.Series["Salary"].Points.AddXY(ans3, res3);
                survey.Series["Salary"].Points.AddXY(ans4, res4);
            }
            
        }
    }
}
