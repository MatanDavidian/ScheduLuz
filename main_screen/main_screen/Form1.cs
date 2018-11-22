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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi my name is tom");
            MessageBox.Show("hi my name is amir");
            MessageBox.Show("hi my name is matan");
            if(textBox1.Text=="Matan"&& textBox2.Text=="123456")
            {
                Calander frmCal = new Calander();
                frmCal.Show();
                Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
