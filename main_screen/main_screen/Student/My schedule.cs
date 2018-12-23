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
    public partial class My_schedule : Form
    {
        public My_schedule()
        {
            InitializeComponent();
        }
        Label[] labels = new Label[91];
        TableLayoutPanel Table = new TableLayoutPanel();
        String global_teacher_name;
        DateTime dt = DateTime.Today;
        private void My_schedule_Load(object sender, EventArgs e)
        {

            Table.Controls.Clear();
            Table.RowStyles.Clear();

            Table.Location = new Point(70, 90);
            Table.Size = new Size(536, 253);
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
                labels[i] = new Label { BackColor = Color.Black, ForeColor = Color.White, Dock = DockStyle.Fill };
                Table.Controls.Add(labels[i], i+1, 0);
            }
            labels[0].Text = "Sunday";
            labels[1].Text = "Monday";
            labels[2].Text = "Tuesday";
            labels[3].Text = "Wednesday";
            labels[4].Text = "Thursday";
            labels[5].Text = "Friday";

           
            for (int i = 6; i < 18; i++)
            {
                labels[i] = new Label { BackColor = Color.DarkBlue, ForeColor = Color.White, Dock = DockStyle.Fill };
                Table.Controls.Add(labels[i], 0, i-5);
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

            //the next code take the teacher reception time
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl;
            conn.Open();


            string query = "Select * from users where Id='" + log_in_page.userId + "'";
            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);

            query = "Select * from weekly_events where user_id_OR_class='" + dtbl.Rows[0]["grade"] +'-'+ dtbl.Rows[0]["classNumber"] +  "'";
            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);


            string hours;
            int k = 18;
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    labels[k] = new Label { BackColor = Color.White, Dock = DockStyle.Fill };
                    Table.Controls.Add(labels[k], j, i);
                    //labels[k].Text = labels[i + 5].Text;//the hours text
                    labels[k].TextAlign = ContentAlignment.MiddleCenter;
                    labels[k].ForeColor = Color.Black;

                    for (int m = 0; m < dtbl.Rows.Count; m++)
                    {
                        hours = dtbl.Rows[m]["start"].ToString().Trim() + "-" + dtbl.Rows[m]["ends"].ToString().Trim();
                        if (labels[i+5].Text.Trim() == hours && labels[k % 6].Text.Trim() == dtbl.Rows[m]["day_in_week"].ToString().Trim())
                        {
                            labels[k].Text = dtbl.Rows[m]["title"].ToString().Trim();
                            labels[k].BackColor = Color.LightGreen;
                            labels[k].ForeColor = Color.Black;
                        }
                        //else
                       // {
                        //    labels[k].Text = "";
                       // }
                    }
                    k++;
                }
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            StudentCalander frmCal = new StudentCalander();
            frmCal.Show();
            Visible = false;
        }
    }
}
