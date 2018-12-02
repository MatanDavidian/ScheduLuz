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
using System.IO;


namespace main_screen.general_process
{
    public partial class Add_event_form : Form
    {
        public Add_event_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader per = new StreamReader("permissionFile.txt");
            string permission = per.ReadLine();
            if (permission[0] == 'M')
            {
                ManagerCalander managerCalander = new ManagerCalander();
                managerCalander.Show();
                Visible = false;

            }
            else if (permission[0] == 'T')
            {
                TeacherCalander teacherCalander = new TeacherCalander();
                teacherCalander.Show();
                Visible = false;

            }

            else
            {
                StudentCalander frmCal = new StudentCalander();
                frmCal.Show();
                Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            
            int cellnum = 1;
            int rownum = 1;
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Events(Event_id,Event_name,date,hours_start,minutes_start,hours_end,minutes_end,Event_details,event_place,event_privacy) VALUES(@Event_id,@Event_name,@date,@hours_start,@minutes_start,@hours_end,@minutes_end,@Event_details,@Place,@private_B) ", conn);
            cmd.Parameters.Add("@Event_id", dataGridView1.Rows.Count.ToString());
            cmd.Parameters.Add("@Event_name", text_title.Text);
            cmd.Parameters.Add("@date", date.Text);
            cmd.Parameters.Add("@hours_start", hours_start.Value);
            cmd.Parameters.Add("@minutes_start", minutes_start.Text);
            cmd.Parameters.Add("@hours_end", hours_end.Text);
            cmd.Parameters.Add("@minutes_end", minutes_end.Text);
            //cmd.Parameters.Add("@time_before", time_before.SelectedItem.ToString());
            cmd.Parameters.Add("@Event_details", richTextBox1.Text);
            cmd.Parameters.Add("@private_B", text_title.Text);
            cmd.Parameters.Add("@public_B", public_B.Text);
            cmd.Parameters.Add("@Place", Place.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Your event added successfully");
            text_title.Clear();
            richTextBox1.Clear();
            Place.Clear();
            

            // SqlCommand sda1 = new SqlCommand("INSERT INTO Events(Event_name,Event_details)"+ text_title.Text+"','"+ richTextBox1.Text+"')'"), sqlcon;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Yes_CheckedChanged(object sender, EventArgs e)
        {
            time_before.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {
            time_before.Visible = false;
            label2.Visible = false;
            label4.Visible = false;

        }

        private void Add_event_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduLuzDataSet2.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.scheduLuzDataSet2.Events);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
