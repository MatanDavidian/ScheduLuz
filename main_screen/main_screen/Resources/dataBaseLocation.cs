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
using System.Net;
using System.Net.Mail;
using USER;
using System.Drawing.Drawing2D;


namespace database_location
{
    struct dataBase
    {
        public SqlConnection connect_to_scheduluz_DB()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\isodot_c#\ScheduLuz2\main_screen\main_screen\ScheduLuz.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
    /*public class RoundButton : Button
    {

       /* protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }*/
}