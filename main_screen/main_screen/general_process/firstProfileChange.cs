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
        string per = log_in_page.permission;
        string userId = log_in_page.userId;

        private void Profile_Load(object sender, EventArgs e)
        {/*
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


            profile_name.Text =userName + " " +userLastName+"'s Profile"  ;*/
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
            else if (yearCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill year.");
            }
            else if (classCB.SelectedIndex == -1 )
            {
                MessageBox.Show("Please fill class.");
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
                
                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd4 = new SqlCommand("UPDATE users SET grade ='" + yearCB.Items[yearCB.SelectedIndex].ToString() + "' WHERE id ='" + userId + "'", conn);
                cmd4.ExecuteNonQuery();

                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd5 = new SqlCommand("UPDATE users SET classNumber ='" + classCB.Items[classCB.SelectedIndex].ToString() + "' WHERE id ='" + userId + "'", conn);
                cmd5.ExecuteNonQuery();

                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd6 = new SqlCommand("UPDATE users SET address ='" + address_txt.Text + "' WHERE id ='" + userId + "'", conn);
                cmd6.ExecuteNonQuery();

                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd7 = new SqlCommand("UPDATE users SET birthDate ='" + birthdate_pckr.Text + "' WHERE id ='" + userId + "'", conn);
                cmd7.ExecuteNonQuery();

                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd8 = new SqlCommand("UPDATE users SET freeTxt ='" + freetext_txt.Text.Trim() + "' WHERE id ='" + userId + "'", conn);
                cmd8.ExecuteNonQuery();


                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd9 = new SqlCommand("UPDATE users SET hobies ='" + hobies_txt.Text.Trim() + "' WHERE id ='" + userId + "'", conn);
                cmd9.ExecuteNonQuery();


                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd10 = new SqlCommand("UPDATE connection_details SET password ='" + pass_txt.Text + "' WHERE id ='" + userId + "'", conn);
                cmd10.ExecuteNonQuery();

                /* adding the image - dont ask*/
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation , FileMode.Open , FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                string sqlQuery = "UPDATE users SET picture =@images WHERE id ='"+ userId + "'" ;
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.Add(new SqlParameter("@images",images));
                int N = cmd.ExecuteNonQuery();


                MessageBox.Show("Your Details has been updated.");




                if (log_in_page.permission == "manager")
                { 
                    ManagerCalander managerCalander = new ManagerCalander();
                    managerCalander.Show();
                    Visible = false;

                }
                else if (log_in_page.permission == "teacher")
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void birthdate_pckr_ValueChanged(object sender, EventArgs e)
        {

        }

        string imgLocation = "";
        SqlCommand cmd;

        private void browse_btn_Click(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            
            

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                profilePic_img.ImageLocation = imgLocation;

            }
            
        }
    }
}
