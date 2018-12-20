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
        private void submit_Click(object sender, EventArgs e)
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            //Table.Controls.Remove(Control.ControlCollection.);
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
            labels[0].Text = "Monday";
            Table.Controls.Add(labels[0], 1, 0);
            labels[1].Text = "Sunday";
            Table.Controls.Add(labels[1], 2, 0);
            labels[2].Text = "Tuesday";
            Table.Controls.Add(labels[2], 3, 0);
            labels[3].Text = "Wednesday";
            Table.Controls.Add(labels[3], 4, 0);
            labels[4].Text = "Thursday";
            Table.Controls.Add(labels[4], 5, 0);
            labels[5].Text = "Friday";
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
            

            string fullName = teacher_name.Text.ToString();
            var names = fullName.Split(' ');
            if (names.Length != 2)
            {
                teacher_name.Clear();
                MessageBox.Show("illegal enter first name and last name separate.");
                return ;
            }
           
            string firstName = names[0];
            string lastName = names[1];
            string queryteach = "Select * from users Where name = '" + firstName + "' and LastName = '" + lastName + "'";
            dataBase dataBaseteach = new dataBase();
            SqlConnection conteach = dataBaseteach.connect_to_scheduluz_DB();
            SqlDataAdapter sdateach;
            DataTable dtblteach;
            conteach.Open();

            sdateach = new SqlDataAdapter(queryteach, conteach);
            dtblteach = new DataTable();
            sdateach.Fill(dtblteach);

          
            



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
                    labels[k].Text = labels[i + 5].Text;
                    labels[k].TextAlign = ContentAlignment.MiddleCenter;
                    labels[k].ForeColor = Color.Black;

                    for (int m = 0; m < dtbl.Rows.Count; m++)
                    {
                        hours = dtbl.Rows[m]["start"].ToString().Trim() + "-" + dtbl.Rows[m]["ends"].ToString().Trim();
                        if (labels[k].Text.Trim() == hours && labels[k % 6].Text.Trim() == dtbl.Rows[m]["day_in_week"].ToString().Trim())
                        {
                            labels[k].BackColor = Color.YellowGreen;
                            labels[k].ForeColor = Color.Black;
                        }
                    }
                    if(labels[k].BackColor == Color.YellowGreen)
                    {
                        labels[k].Click += new System.EventHandler(LabelClick);
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
    }
}
   

