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
    public partial class TeacherCalander : Form
    {
        public TeacherCalander()
        {
            InitializeComponent();
        }

        private void add_event_Click(object sender, EventArgs e)
        {
      
        }

        private void TeacherCalander_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            log_in_page frmCal = new log_in_page();
            frmCal.Show();
            Visible = false;
        }
    }
}
