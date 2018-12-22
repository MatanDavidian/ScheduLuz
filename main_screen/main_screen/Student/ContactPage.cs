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
    public partial class ContactPage : Form
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentCalander Mc = new StudentCalander();
            this.Hide();
            Mc.Show();
        }

        private void ContactPage_Load(object sender, EventArgs e)
        {
            contacts_lv.Items.Clear();
            

            try
            {
                User user = new User();
                user = user.GetUser(log_in_page.userId);

                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();

                string query = "Select id from users Where grade = '" + user.getGrade() + "' and classNumber = '" + user.getClassNumber() + "' and permission='student'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        User user2 = new User();
                        user2 = user2.GetUser(dtbl.Rows[i]["id"].ToString().Trim());

                        ListViewItem student = new ListViewItem(user2.getLastName());
                        student.SubItems.Add(user2.getName());
                        student.SubItems.Add(user2.getPhoneNumber());
                        student.SubItems.Add(user2.getEmail());
                        student.SubItems.Add(user2.getParentEmail());
                        student.SubItems.Add(user2.getAddress());

                        contacts_lv.Items.Add(student);


                    }
                
                
            }
            catch
            {
                MessageBox.Show("Something went wrong, please check your input.");
            }
        }

        private void contacts_lv_SelectedIndexChanged(object sender, EventArgs e)
        {

            profilePic_img.Image = null;
            profilePic_img.Refresh();
            if (contacts_lv.SelectedItems.Count == 0)
                return;
            string name = contacts_lv.SelectedItems[0].SubItems[1].Text;
            string last_name = contacts_lv.SelectedItems[0].SubItems[0].Text;
            string username = name + last_name;
            //MessageBox.Show(username);



            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();

            string query = "Select id from connection_details Where userName = '" + username+  "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                con.Open();
                string selectedID = dtbl.Rows[0][0].ToString().Trim();
                 query = "select picture from users where id='" + selectedID + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dataRead = cmd.ExecuteReader();
                dataRead.Read();

                try
                {
                    byte[] img = null;
                    if (dataRead.HasRows)
                    {
                        img = (byte[])dataRead[0];
                    }

                    if (img == null)
                    {
                        profilePic_img.Image = null;

                    }

                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(img);
                        profilePic_img.Image = Image.FromStream(memoryStream);
                    }
                }
                catch
                {

                }
                con.Close();
                
            }

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            StudentCalander n = new StudentCalander();
            n.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            User user = new User();
            user = user.GetUser(log_in_page.userId);
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query = "Select * from users Where permission = 'student' and grade='"+user.getGrade()+"' and classNumber='"+user.getClassNumber()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            contacts_lv.Items.Clear();

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string temp = dtb.Rows[i]["name"].ToString().Trim().ToUpper() + " " + dtb.Rows[i]["lastName"].ToString().Trim().ToUpper();
                string tempphone = dtb.Rows[i]["phoneNumber"].ToString().Trim();
                string tempEmail = dtb.Rows[i]["Email"].ToString().Trim().ToUpper();

            if (temp.Contains(search_txt.Text.ToUpper()) || tempphone.Contains(search_txt.Text) || tempEmail.Contains(search_txt.Text.ToUpper()))
                {
                    ListViewItem item = new ListViewItem(dtb.Rows[i]["lastName"].ToString().Trim());
                    item.SubItems.Add(dtb.Rows[i]["name"].ToString().Trim());
                    item.SubItems.Add(dtb.Rows[i]["phoneNumber"].ToString().Trim());
                    item.SubItems.Add(dtb.Rows[i]["Email"].ToString().Trim());
                    item.SubItems.Add(dtb.Rows[i]["address"].ToString().Trim());

                    contacts_lv.Items.Add(item);

                }
            }
        }
    }
}
