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


namespace USER
{
    public struct User
    {
        /*
         * The next struct is for defining a user.
         * after the first login, of the user we wont need to check every detail in the data base.
         * 
         */
        string id;
        string password;
        string name;
        string permission;
        string Email;

        public void insertID(string id_input)
        {
            this.id = id_input;
        }

        public void insertPermission(string permission_input)
        {
            this.permission = permission_input;

        }

        public string getPermission()
        {
            return this.permission;
        }

        public void createtUser(string id_input, string password_input, string name_input, string permission_input, string Email_input)
        {
            this.id = id_input;
            this.password = password_input;
            this.name = name_input;
            this.permission = permission_input;
            this.Email = Email_input;
        }

    }
}

