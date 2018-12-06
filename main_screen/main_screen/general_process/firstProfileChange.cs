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
    public partial class firstProfileChange : Form
    {
        

        public firstProfileChange()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            StreamReader userFile = new StreamReader("userFile.txt");
            string userId=userFile.ReadLine();
            userFile.Close();

            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query_name = "Select name from users Where id = '" + userId +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query_name, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            string userName = dtbl.Rows[0][0].ToString().Trim();
            query_name = "Select lastName from users Where id = '" + userId + "'";
            sda = new SqlDataAdapter(query_name, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            string userLastName = dtbl.Rows[0][0].ToString().Trim();


            profile_name.Text =userName + " " +userLastName+"'s Profile"  ;
        }

        private void profile_name_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader userFile = new StreamReader("userFile.txt");
            string userId = userFile.ReadLine();
            userFile.Close();
            CheckDetails check = new CheckDetails();

            if (pass_txt.Text == userId)
            {
                MessageBox.Show("Your password is the same as before, please update it.");
            }
            else if (pass_txt.Text == "")
            {
                MessageBox.Show("Please update your password.");
            }
            else if (pass_txt.Text != confirm_pass_txt.Text)
            {
                MessageBox.Show("Passwords do not match.");
            }
            
            else if (!check.CheckEmail(Email_1st.Text))
            {
                MessageBox.Show("Email is not valid!");
            }
            else if (Email_1st.Text != Email_2nd.Text)
            {
                MessageBox.Show("Emails do not match.");
            }
            else if (phone_txt.Text == "")
            {
                MessageBox.Show("Please update your phone number.");
            }
            else if (!check.Check_onlyNums(phone_txt.Text) || phone_txt.Text.Length != 10)
            {
                MessageBox.Show("Invalid phone number.");
            }
            else if (!check.CheckEmail(PEmail_txt.Text))
            {
                MessageBox.Show("Parent Email is not valid!");
            }
            else if (PEmail_txt.Text != confirm_PEmail_txt.Text)
            {
                MessageBox.Show("Parent Emails do not match.");
            }
            else if (PEmail_txt.Text == Email_1st.Text)
            {
                MessageBox.Show("Parent Email is the same as yours.");
            }
            



            else
            {
                dataBase dataBase = new dataBase();
                SqlConnection conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE users SET phoneNumber ='"+phone_txt.Text+"' WHERE id ='"+userId+"'", conn);
                cmd1.ExecuteNonQuery();

                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE users SET Email ='" + Email_1st.Text + "' WHERE id ='" + userId + "'", conn);
                cmd2.ExecuteNonQuery();

                
                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("UPDATE users SET ParentEmail ='" + PEmail_txt.Text + "' WHERE id ='" + userId + "'", conn);
                cmd3.ExecuteNonQuery();
                
            }

        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            if(pass_txt.UseSystemPasswordChar == true)
            {
                pass_txt.UseSystemPasswordChar = false;
                confirm_pass_txt.UseSystemPasswordChar = false;
            }

            else
            {
                pass_txt.UseSystemPasswordChar = true;
                confirm_pass_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
