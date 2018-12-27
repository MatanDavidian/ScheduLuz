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
    public partial class AnswerSurveys : Form
    {
        public AnswerSurveys()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            StudentCalander n = new StudentCalander();
            n.Show();
            this.Hide();
        }

      

        private void AnswerSurveys_Load(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl,dtbl2;
            conn.Open();
            string query="Select surveys_id from surveys_to_users where user_id='" + int.Parse(log_in_page.userId) + "'" + "And answer ='" + false + "'";
            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);

            for (int i = 0; i < dtbl.Rows.Count; i++)
            {
                query = "Select * from surveys where surveys_id='" + int.Parse(dtbl.Rows[i][0].ToString()) + "'";
                sda = new SqlDataAdapter(query, conn);
                dtbl2 = new DataTable();
                sda.Fill(dtbl2);

                ListViewItem item = new ListViewItem(dtbl2.Rows[0]["date"].ToString().Trim());
                item.SubItems.Add(dtbl2.Rows[0]["question"].ToString().Trim());
                listView.Items.Add(item);
            }
        }
        Label[] labels = new Label[5];
        TableLayoutPanel Table = new TableLayoutPanel();
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView.SelectedIndices.Count > 0)
            {
                Table.Controls.Clear();
                Table.RowStyles.Clear();

                Table.Location = new Point(406, 60);
                Table.Size = new Size(400, 115);
                Table.AutoSize = false;
                Table.Name = "Desk";
                Table.ColumnCount = 1;
                Table.RowCount = 5;
                Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
                this.Controls.Add(Table);
                labels[0] = new Label { BackColor = Color.Black, ForeColor = Color.White, Dock = DockStyle.Fill };
                for (int i = 1; i < 5; i++)
                {
                    labels[i] = new Label { BackColor = Color.White, ForeColor = Color.Black, Dock = DockStyle.Fill };
                    labels[i].Click += new System.EventHandler(LabelClick);
                }
                
                int selectedIndex = listView.SelectedIndices[0];

                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();
                SqlDataAdapter sda;
                DataTable dtbl, dtbl2;
                conn.Open();
                string query = "Select surveys_id from surveys_to_users where user_id='" + int.Parse(log_in_page.userId) + "'" + "And answer ='" + false + "'";
                sda = new SqlDataAdapter(query, conn);
                dtbl = new DataTable();
                sda.Fill(dtbl);


                query = "Select * from surveys where surveys_id='" + int.Parse(dtbl.Rows[selectedIndex][0].ToString()) + "'";
                sda = new SqlDataAdapter(query, conn);
                dtbl2 = new DataTable();
                sda.Fill(dtbl2);

                string quest = dtbl2.Rows[0]["question"].ToString();
                string ans1 = dtbl2.Rows[0]["answerA"].ToString();
                string ans2 = dtbl2.Rows[0]["answerB"].ToString();
                string ans3 = dtbl2.Rows[0]["answerC"].ToString();
                string ans4 = dtbl2.Rows[0]["answerD"].ToString();

                labels[0].Text = quest;
                Table.Controls.Add(labels[0], 0, 0);
                labels[1].Text = ans1;
                Table.Controls.Add(labels[1], 1, 0);
                labels[2].Text = ans2;
                Table.Controls.Add(labels[2], 2, 0);
                labels[3].Text = ans3;
                Table.Controls.Add(labels[3], 3, 0);
                labels[4].Text = ans4;
                Table.Controls.Add(labels[4], 4, 0);
            }
        }

        private void LabelClick(object sender, EventArgs e)
        {
            var label = sender as Label;
            for(int i=1;i<5;i++)
            {
                labels[i].BackColor = Color.White;
                labels[i].ForeColor = Color.Black;
            }
            
            label.ForeColor = Color.Black;
            label.BackColor = Color.LightGreen;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                if (labels[i].BackColor == Color.LightGreen)
                {
                    string my_ans = "resultA";
                    if (i == 1)
                        my_ans = "resultA";
                    else if (i == 2)
                        my_ans = "resultB";
                    else if (i == 3)
                        my_ans = "resultC";
                    else if (i == 4)
                        my_ans = "resultD";
                    int selectedIndex = listView.SelectedIndices[0];
                    dataBase dataBase = new dataBase();
                    SqlConnection conn = dataBase.connect_to_scheduluz_DB();
                    SqlDataAdapter sda;
                    DataTable dtbl, dtbl2;
                    conn.Open();
                    string query = "Select surveys_id from surveys_to_users Where user_id='" + int.Parse(log_in_page.userId) + "'" + "And answer ='" + false + "'";
                    sda = new SqlDataAdapter(query, conn);
                    dtbl = new DataTable();
                    sda.Fill(dtbl);


                    query = "Select * from surveys Where surveys_id='" + int.Parse(dtbl.Rows[selectedIndex][0].ToString()) + "'";
                    sda = new SqlDataAdapter(query, conn);
                    dtbl2 = new DataTable();
                    sda.Fill(dtbl2);
                    int old_res = int.Parse(dtbl2.Rows[0][my_ans].ToString());
                    int new_res = old_res + 1;
                    SqlCommand cmd1 = new SqlCommand("UPDATE surveys SET "+ my_ans+"='" + new_res + "' WHERE surveys_id='" + int.Parse(dtbl.Rows[selectedIndex][0].ToString()) + "'", conn);
                    cmd1.ExecuteNonQuery();
                    cmd1 = new SqlCommand("UPDATE surveys_to_users SET answer ='" + true + "' WHERE surveys_id='" + int.Parse(dtbl.Rows[selectedIndex][0].ToString()) + "'" + "And user_id ='"+log_in_page.userId +"'", conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    Student.AnswerSurveys n = new Student.AnswerSurveys();
                    this.Hide();
                    n.Show();
                }
            }
        }
    }
}
