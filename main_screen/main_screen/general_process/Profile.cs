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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        string per = log_in_page.permission;
        string userId = log_in_page.userId;
        User user = new User();

        private void Profile_Load(object sender, EventArgs e)
        {
            
            
            user = user.GetUser(userId);


            address_txt.Text    = user.getAddress();
            birthdate_pckr.Text = user.getBirthDate();
            freetext_txt.Text   = user.getFreeTxt();
            hobies_txt.Text     = user.getHobies();
            Email_1st.Text      = user.getEmail();
            phone_txt.Text      = user.getPhoneNumber();
            PEmail_txt.Text     = user.getParentEmail();
            permissin_txt.Text  = user.getPermission();

            profile_name.Text = user.getName() + " " + user.getLastName() + "'s profile";


            /*
             * picture
             */

            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            con.Open();

            string query = "select picture from users where id='" + userId + "'";

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

        private void return_btn_Click(object sender, EventArgs e)
        {
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

            else if (log_in_page.permission == "student")
            {
                StudentCalander frmCal = new StudentCalander();
                frmCal.Show();
                Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            CheckDetails check = new CheckDetails();

            if (new_pass_txt.Text == userId)
            {
                MessageBox.Show("Your password is the same as your id, please change it.");
            }

            else if (new_pass_txt.Text != confirm_new_pass_txt.Text)
            {
                MessageBox.Show("Passwords do not match.");
            }

            else if (!check.CheckEmail(Email_1st.Text))
            {
                MessageBox.Show("Email is not valid!");
            }
            else if (phone_txt.Text == "")
            {
                MessageBox.Show("Please update your phone number.");
            }
            else if (!check.Check_onlyNums(phone_txt.Text) || phone_txt.Text.Length != 10)
            {
                MessageBox.Show("Invalid phone number.");
            }
            else if (!check.CheckEmail(PEmail_txt.Text) && log_in_page.permission == "student")
            {
                MessageBox.Show("Parent Email is not valid!");
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
                SqlCommand cmd1 = new SqlCommand("UPDATE users SET phoneNumber ='" + phone_txt.Text + "' WHERE id ='" + userId + "'", conn);
                cmd1.ExecuteNonQuery();

                conn = dataBase.connect_to_scheduluz_DB();
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE users SET Email ='" + Email_1st.Text + "' WHERE id ='" + userId + "'", conn);
                cmd2.ExecuteNonQuery();

                if (log_in_page.permission == "student")
                {
                    conn = dataBase.connect_to_scheduluz_DB();
                    conn.Open();
                    SqlCommand cmd3 = new SqlCommand("UPDATE users SET ParentEmail ='" + PEmail_txt.Text + "' WHERE id ='" + userId + "'", conn);
                    cmd3.ExecuteNonQuery();
                }

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

                if (new_pass_txt.Text != "")
                {
                    conn = dataBase.connect_to_scheduluz_DB();
                    conn.Open();
                    SqlCommand cmd10 = new SqlCommand("UPDATE connection_details SET password ='" + new_pass_txt.Text + "' WHERE id ='" + userId + "'", conn);
                    cmd10.ExecuteNonQuery();
                }

                /* adding the image - dont ask*/
                if (imgLocation != "")
                {
                    byte[] images = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);

                    conn = dataBase.connect_to_scheduluz_DB();
                    conn.Open();
                    string sqlQuery = "UPDATE users SET picture =@images WHERE id ='" + userId + "'";
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    int N = cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Your Details has been updated." + userId);




                if (per == "manager")
                {
                    ManagerCalander managerCalander = new ManagerCalander();
                    managerCalander.Show();
                    Visible = false;

                }
                else if (per == "teacher")
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

        private void profilePic_img_Click(object sender, EventArgs e)
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
