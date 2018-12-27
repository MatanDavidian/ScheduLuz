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

namespace main_screen.general_process
{
    public partial class ManagerAndTeacher_view_contacts : Form
    {
        public ManagerAndTeacher_view_contacts()
        {
            InitializeComponent();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            contacts_lv.Items.Clear();
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();
                if (class_num_cb.Text == "3" || class_num_cb.Text == "2" || class_num_cb.Text == "1")
                {
                    string query = "Select id from users Where grade = '" + grade_cb.Text + "' and classNumber = '" + class_num_cb.Text + "' and permission='student'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        User user = new User();
                        user = user.GetUser(dtbl.Rows[i]["id"].ToString().Trim());

                        ListViewItem student = new ListViewItem(user.getLastName());
                        student.SubItems.Add(user.getName());
                        student.SubItems.Add(user.getPhoneNumber());
                        student.SubItems.Add(user.getEmail());
                        student.SubItems.Add(user.getParentEmail());
                        student.SubItems.Add(user.getAddress());

                        contacts_lv.Items.Add(student);


                    }
                }
                else if (class_num_cb.Text == "ALL")
                {

                    string query = "Select id from users Where grade = '" + grade_cb.Text + "' and permission='student'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        User user = new User();
                        user = user.GetUser(dtbl.Rows[i]["id"].ToString().Trim());

                        ListViewItem student = new ListViewItem(user.getLastName());
                        student.SubItems.Add(user.getName());
                        student.SubItems.Add(user.getPhoneNumber());
                        student.SubItems.Add(user.getEmail());
                        student.SubItems.Add(user.getParentEmail());
                        student.SubItems.Add(user.getAddress());

                        contacts_lv.Items.Add(student);


                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, please check your input.");
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = user.GetUser(log_in_page.userId);

            if (user.getPermission().ToLower() == "manager")
            {
                ManagerCalander n = new ManagerCalander();
                n.Show();
                this.Hide();
            }
            else if(user.getPermission().ToLower() == "teacher")
            {
                TeacherCalander n = new TeacherCalander();
                n.Show();
                this.Hide();
            }

        }

        private void ManagerAndTeacher_view_contacts_Load(object sender, EventArgs e)
        {

        }
    }
}
