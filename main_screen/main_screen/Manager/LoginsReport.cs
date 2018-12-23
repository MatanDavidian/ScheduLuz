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
using database_location;

namespace main_screen.Manager
{
    public partial class LoginsReport : Form
    {
        public LoginsReport()
        {
            InitializeComponent();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            ManagerCalander n = new ManagerCalander();
            this.Hide();
            n.Show();
        }

        private void schedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginsReport_Load(object sender, EventArgs e)
        {
            List<ListViewItem> itemlist = new List<ListViewItem>();

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            SqlDataAdapter sda;
            DataTable dtbl;
            conn.Open();
            string query = "Select * from logins_report";
            sda = new SqlDataAdapter(query, conn);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            for(int i=0;i<dtbl.Rows.Count;i++)
            {
                ListViewItem item = new ListViewItem(dtbl.Rows[i]["date"].ToString().Trim());
                item.SubItems.Add(dtbl.Rows[i]["user_name"].ToString().Trim());
                item.SubItems.Add(dtbl.Rows[i]["connectORdisconnect"].ToString().Trim());
                //itemlist.Add(item);
                listView1.Items.Add(item);
                //item.BackColor = Color.IndianRed;
            }
            conn.Close();
        }
    }
}
