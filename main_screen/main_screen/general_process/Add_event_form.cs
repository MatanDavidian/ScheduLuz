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
            ManagerCalander frmCal = new ManagerCalander();
            frmCal.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\calander_project\TomSce\ScheduLuz2\main_screen\main_screen\ScheduLuz.mdf;Integrated Security=True;Connect Timeout=30");
            int cellnum = 1;
            int rownum = 1;
            /*
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[1].Value=cellnum;
                rownum = rownum + 1;
            }
            */
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
    }
}
