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
    public partial class delete_user : Form
    {
        public delete_user()
        {
            InitializeComponent();
        }

        private void student_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = student_lst.SelectedIndex;
                to_txt.Text = student_lst.Items[index].ToString();
            }
            catch
            {

            }
        }

        private void to_txt_TextChanged(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query = "Select id,name,lastName from users Where Id !='"+log_in_page.userId+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            student_lst.Items.Clear();

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string temp = dtb.Rows[i]["name"].ToString().Trim().ToUpper() + " " + dtb.Rows[i]["lastName"].ToString().Trim().ToUpper();

                if (temp.Contains(to_txt.Text.ToUpper()) && !detele_lst.Items.Contains(temp))
                {
                    student_lst.Items.Add(dtb.Rows[i]["name"].ToString().Trim() + " " + dtb.Rows[i]["lastName"].ToString().Trim());
                }
            }
        }

        private void send_to_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();

            string query;

            if (class_num_cb.Text == "ALL")
            {
                query = "Select name,lastName from users where grade ='" + grade_cb.Text + "'";
            }
            else
            {
                query = "Select name,lastName from users where grade ='" + grade_cb.Text + "' and classNumber='" + class_num_cb.Text + "'";
            }

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string student = dtb.Rows[i]["name"].ToString().Trim().ToUpper() + " " + dtb.Rows[i]["lastName"].ToString().Trim().ToUpper();
                if (!detele_lst.Items.Contains(student))
                    detele_lst.Items.Add(student);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (student_lst.Items.Contains(to_txt.Text) && !detele_lst.Items.Contains(to_txt.Text.ToUpper()))
            {
                detele_lst.Items.Add(to_txt.Text.ToUpper());
                to_txt.Clear();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
             detele_lst.Items.Clear();
        }

        private void grade_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_user_Load(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();

            for (int i = 0; i < detele_lst.Items.Count; i++)
            {

                string username = detele_lst.Items[i].ToString().Replace(" ", "");

                string queryTogetStudentID = "Select id from connection_details Where userName = '" + username + "'";
                SqlDataAdapter sda = new SqlDataAdapter(queryTogetStudentID, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                string sendToId = dtb.Rows[0][0].ToString().Trim();

                User n = new User();
                n.DeleteUser(sendToId);
            }
            MessageBox.Show("The user deleted.");
            delete_user frm = new delete_user();
            this.Hide();
            frm.Show();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            ManagerCalander n = new ManagerCalander();
            this.Hide();
            n.Show();
        }
    }
}
