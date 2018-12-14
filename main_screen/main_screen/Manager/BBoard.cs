using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_screen.Manager
{
    public partial class BBoard : Form
    {
        public BBoard()
        {
            InitializeComponent();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void return_btn_Click_1(object sender, EventArgs e)
        {
            ManagerCalander n = new ManagerCalander();
            n.Show();
            this.Hide();
        }

        private void edit_last_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
