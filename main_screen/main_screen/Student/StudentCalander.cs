using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_screen
{
    public partial class StudentCalander : Form
    {
        public StudentCalander()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            log_in_page frmCal = new log_in_page();
            frmCal.Show();
            Visible = false;
        }

        private void add_event_Click(object sender, EventArgs e)
        {
            general_process.Add_event_form Mc = new general_process.Add_event_form();
            this.Hide();
            Mc.Show();
        }

        private void contact_page_Click(object sender, EventArgs e)
        {
            Student.ContactPage Mc = new Student.ContactPage();
            this.Hide();
            Mc.Show();
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            general_process.Profile profile = new general_process.Profile();
            this.Hide();
            profile.Show();
        }
    }
}
