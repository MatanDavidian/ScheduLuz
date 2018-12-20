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

namespace main_screen.Manager
{
    public partial class BBoard : Form
    {
        public BBoard()
        {
            InitializeComponent();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void return_btn_Click_1(object sender, EventArgs e)
        {
            ManagerCalander n = new ManagerCalander();
            n.Show();
            this.Hide();
        }

        private void edit_last_btn_Click(object sender, EventArgs e)
        {
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();
                string rownumOfMax = "0";
                con.Open();

                string query = "Select MAX(msg_id) from bulletin_board";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    rownumOfMax = dtb.Rows[0][0].ToString();
                    query = "Select msg from bulletin_board where msg_id ='" + rownumOfMax + "'";

                    sda = new SqlDataAdapter(query, con);
                    dtb = new DataTable();
                    sda.Fill(dtb);
                    if (dtb.Rows.Count > 0)
                    {
                        msg_txt.Text = dtb.Rows[0][0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("There is no early messages.");
                }
            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }
            

        }

        private void BBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO bulletin_board (msg) VALUES (@msg)", con);
                cmd.Parameters.Add("@msg", msg_txt.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Message has been published.");

                ManagerCalander n = new ManagerCalander();
                n.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }

        }
    }
}
