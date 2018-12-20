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
using System.Net;
using System.Net.Mail;
using USER;
using database_location;
using System.IO;
using check_funcs;

namespace main_screen.Student
{
    public partial class MyDearDairy : Form
    {
        public MyDearDairy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentCalander n = new StudentCalander();
            n.Show();
            this.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            day_txt.Enabled = true;
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                conn.Open();

                string query;
                int thisday = monthCalendar1.SelectionRange.Start.Day;
                int thismonth = monthCalendar1.SelectionRange.Start.Month;
                int thisyear = monthCalendar1.SelectionRange.Start.Year;
                string student = "'" + log_in_page.userId.ToString() + "'";

                query = "Select * from my_dear_dairy2 where student_id=" + student + "and day='" + thisday.ToString() + "' and month='" + thismonth.ToString() + "' and year ='" + thisyear.ToString() + "'";
                date_lbl.Text = thisday.ToString() + "/" + thismonth.ToString() + "/" + thisyear.ToString();


                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                //MessageBox.Show(monthCalendar1.SelectionRange.Start);

                if (dtb.Rows.Count > 0)
                {
                    day_txt.Text = dtb.Rows[0]["txt"].ToString();
                }
                else
                {
                    day_txt.Text = "";
                }

                day_txt.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }

        }

        private void MyDearDairy_Load(object sender, EventArgs e)
        {
            int thisday = monthCalendar1.SelectionRange.Start.Day;
            int thismonth = monthCalendar1.SelectionRange.Start.Month;
            int thisyear = monthCalendar1.SelectionRange.Start.Year;
            date_lbl.Text = thisday.ToString() + "/" + thismonth.ToString() + "/" + thisyear.ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                conn.Open();

                string query;
                int thisday = monthCalendar1.SelectionRange.Start.Day;
                int thismonth = monthCalendar1.SelectionRange.Start.Month;
                int thisyear = monthCalendar1.SelectionRange.Start.Year;
                string student = "'" + log_in_page.userId.ToString() + "'";

                query = "Select * from my_dear_dairy2 where student_id=" + student + "and day='" + thisday.ToString() + "' and month='" + thismonth.ToString() + "' and year ='" + thisyear.ToString() + "'";
                date_lbl.Text = thisday.ToString() + "/" + thismonth.ToString() + "/" + thisyear.ToString();


                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                //MessageBox.Show(monthCalendar1.SelectionRange.Start);

                if (dtb.Rows.Count > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE my_dear_dairy2 SET txt ='" + day_txt.Text + "' where student_id=" + student + "and day='" + thisday.ToString() + "' and month='" + thismonth.ToString() + "' and year ='" + thisyear.ToString() + "'", conn);
                    cmd2.ExecuteNonQuery();
                }
                else
                {


                    SqlCommand cmd;
                    cmd = new SqlCommand("INSERT INTO my_dear_dairy2 (student_id,year,month,day,txt) VALUES (@student_id,@year,@month,@day,@txt)", conn);
                    cmd.Parameters.Add("@student_id", log_in_page.userId);
                    cmd.Parameters.Add("@year", thisyear);
                    cmd.Parameters.Add("@month", thismonth);
                    cmd.Parameters.Add("@day", thisday);
                    cmd.Parameters.Add("@txt", day_txt.Text);

                    cmd.ExecuteNonQuery();

                }

                MessageBox.Show("Saved");
                day_txt.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            try
            {


                int thisday = monthCalendar1.SelectionRange.Start.Day;
                int thismonth = monthCalendar1.SelectionRange.Start.Month;
                int thisyear = monthCalendar1.SelectionRange.Start.Year;

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter SW = new System.IO.StreamWriter(saveFileDialog1.FileName, false, Encoding.ASCII);
                    SW.Write(day_txt.Text);
                    SW.Close();
                }
            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }
        }
    }
}
