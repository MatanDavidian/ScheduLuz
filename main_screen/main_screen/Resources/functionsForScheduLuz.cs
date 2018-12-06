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

namespace check_funcs
{
    struct CheckDetails
    {

        public bool Check_onlyNums(string pnum)
        {
            for (int i = 0; i < pnum.Length; i++)
                if (pnum[i] < '0' || pnum[i] > '9')
                    return false;
            return true;
        }

        public bool CheckEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}