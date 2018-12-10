using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database_location;
using System.Data.SqlClient;
using System.IO;

using USER;

namespace main_screen.Student
{
    public partial class Multiplayer_event : Form
    {
        public ImageList imgs = new ImageList();
        public Multiplayer_event()
        {
            InitializeComponent();
        }

        private void Multiplayer_event_Load(object sender, EventArgs e)
        {
            
        }
        int count = 0;
        private void populate()
        {

            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            con.Open();

            string query = "select picture from users where name='" + friend_name.Text.Trim() + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataRead = cmd.ExecuteReader();
            dataRead.Read();


            byte[] img = null;
            if (dataRead.HasRows)
            {
                img = (byte[])dataRead[0];
            }

            if (img == null)
            {
                listView1.SmallImageList = null;

            }

            else
            {
                MemoryStream memoryStream = new MemoryStream(img);
                imgs.Images.Add(Image.FromStream(memoryStream));
            }
            con.Close();
            listView1.SmallImageList = imgs;
            listView1.Items.Add(friend_name.Text.Trim(),count);
            count++;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            imgs.ImageSize = new Size(50, 50);
            populate();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;

            MessageBox.Show(selected);
        }
    }
}
