using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_screen.general_process
{
    public partial class Add_event_form : Form
    {
        public Add_event_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerCalander frmCal = new ManagerCalander();
            frmCal.Show();
            Visible = false;
        }
    }
}
