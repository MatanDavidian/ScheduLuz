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
    public partial class identify : Form
    {
        public identify()
        {
            InitializeComponent();
        }
        public static bool identified = false;

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = user.GetUser(log_in_page.userId);

            if (user.getPassword() == pass_txt.Text)
            {
                identified = true;
                this.Close();
            }
            else
            {
                identified = false;
                MessageBox.Show("Wrong password. Please try again.");
            }

        }

        private void identify_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
