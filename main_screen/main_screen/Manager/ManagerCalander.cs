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
    }
}
