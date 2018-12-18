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

namespace database_location
{
    struct dataBase
    {
        public SqlConnection connect_to_scheduluz_DB()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\isodot_calander_project\ScheduLuz2\main_screen\main_screen\ScheduLuz.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}