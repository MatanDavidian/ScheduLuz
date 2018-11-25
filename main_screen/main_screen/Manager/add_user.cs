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

namespace main_screen.Manager
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerCalander frmAEF = new ManagerCalander();
            frmAEF.Show();
            Visible = false;
        }

        private void Choose_Type_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string per;
            if (Student.Checked)
                per = "student";
            else if (Teacher.Checked)
                per = "teacher";
            else if (Manager.Checked)
                per = "manager";
            else
                per = "none";
            
            
            if (userIDtextBox.Text.Length ==0 || userFirstNameTextBox.Text.Length == 0 || userLastNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("please fill all the fileds");
            }
            else
            {
                
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PROJECTC#\SCHEDULUZ2\MAIN_SCREEN\MAIN_SCREEN\DATABASES\SCHEDULUZ.MDF;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO connection_details (id,userName,password,permission) VALUES (@id,@userName,@password,@permission)", con);
                cmd.Parameters.Add("@id", userIDtextBox.Text);
                cmd.Parameters.Add("@userName", userFirstNameTextBox.Text+userLastNameTextBox.Text);
                cmd.Parameters.Add("@password", userIDtextBox.Text);
                cmd.Parameters.Add("@permission", per);
                cmd.ExecuteNonQuery();
                MessageBox.Show("has added");

                userFirstNameTextBox.Clear();
                userLastNameTextBox.Clear();
                userIDtextBox.Clear();


                /*
                SqlCommand sda1 = new SqlCommand(" INSERT INTO connection_details (id,userName,password) VALUES (' " + userIDtextBox.Text + "','" + userIDtextBox.Text + "','" + userIDtextBox.Text +"')",con);
                SqlDataAdapter da = new SqlDataAdapter(sda1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //da.Update(ds);
                MessageBox.Show("has added");*/


            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            StudentCalander frmCal = new StudentCalander();
            frmCal.Show();
            Visible = false;
        }
    }
}
