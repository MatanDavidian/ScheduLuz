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
    public partial class log_in_page : Form
    {
        public log_in_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Matan"&& textBox2.Text=="123456")
            {
                ManagerCalander frmCal = new ManagerCalander();
                frmCal.Show();
                Visible = false;
            }
            else if (textBox1.Text == "Tom" && textBox2.Text == "123456")
            {
                TeacherCalander frmCal = new TeacherCalander();
                frmCal.Show();
                Visible = false;
            }
            else if (textBox1.Text == "Aviran" && textBox2.Text == "123456")
            {
                StudentCalander frmCal = new StudentCalander();
                frmCal.Show();
                Visible = false;
            }
            else if (textBox1.Text == "Amir" && textBox2.Text == "123456")
            {
                StudentCalander frmCal = new StudentCalander();
                frmCal.Show();
                Visible = false;
            }
            else
                MessageBox.Show("Worng password");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
