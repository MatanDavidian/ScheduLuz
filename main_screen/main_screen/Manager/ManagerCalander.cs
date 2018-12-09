using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USER;


namespace main_screen
{
    public partial class ManagerCalander : Form
    {
        public ManagerCalander()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.add_user frmAEF = new Manager.add_user();
            frmAEF.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            general_process.Add_event_form Mc = new general_process.Add_event_form();
            this.Hide();
            Mc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            log_in_page frmCal = new log_in_page();
            frmCal.Show();
            Visible = false;
        }

        private void ManagerCalander_Load(object sender, EventArgs e)
        {
            User user = new User();
            user = user.GetUser(log_in_page.userId);

            UserName_lbl.Text = user.getUsername();
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            general_process.Profile profile = new general_process.Profile();
            profile.Show();
            Visible = false;
        }
    }
}
