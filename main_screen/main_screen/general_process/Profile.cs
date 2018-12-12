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

            
            byte[] img = null;
            if (dataRead.HasRows)
            {
                img = (byte[])dataRead[0];
            }

            if(img == null)
            {
                profilePic_img.Image = null;
                
            }

            else
            {
                MemoryStream memoryStream = new MemoryStream(img);
                profilePic_img.Image = Image.FromStream(memoryStream);
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

        }

        private void profilePic_img_Click(object sender, EventArgs e)
        {

        }

        private void browse_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
