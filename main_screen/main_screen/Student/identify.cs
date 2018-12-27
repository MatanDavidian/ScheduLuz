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
    public partial class identify : Form
    {
        public identify()
        {
            InitializeComponent();
        }

        public int num_of_tries = 0;
        private User user = new User();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_pass_Click(object sender, EventArgs e)
        {
            if (pass_txt.Text == user.getPassword())
            {
                MyDearDairy n = new MyDearDairy();
                this.Hide();
                n.Show();
            }

            else if (num_of_tries == 2)
            {
                num_of_tries = 0;
                log_in_page n = new log_in_page();
                this.Hide();
                MessageBox.Show("There are no tries left.\nTransfering to the main page");
                n.Show();

            }

            else
            {
                num_of_tries++;
                pass_txt.Text = "";
                MessageBox.Show("Wrong password, try again. \n number of tries left: " + (3 - num_of_tries).ToString());
            }
        }

        private void identify_Load(object sender, EventArgs e)
        {
            
            user = user.GetUser(log_in_page.userId);
         
        }
    }
}
