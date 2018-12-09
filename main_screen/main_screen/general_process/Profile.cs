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

        private void Profile_Load(object sender, EventArgs e)
        {
            
            User user = new User();
            user = user.GetUser(userId);


            address_txt.Text = user.getAddress();
            birthdate_pckr.Text = user.getBirthDate();
            freetext_txt.Text = user.getFreeTxt();
            hobies_txt.Text = user.getHobies();
            Email_1st.Text = user.getEmail();
            phone_txt.Text = user.getPhoneNumber();
            PEmail_txt.Text = user.getParentEmail();

            profile_name.Text = user.getName() + " " + user.getLastName() + "'s profile";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
