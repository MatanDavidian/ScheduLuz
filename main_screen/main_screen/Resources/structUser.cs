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


namespace USER
{
    public struct User
    {
        /*
         * The next struct is for defining a user.
         * after the first login, of the user we wont need to check every detail in the data base.
         * 
         */


        /*
        *##########################
        * Attributes
        *##########################
        */

        string id; 
        string password; 
        string username; 
        string name; 
        string lastName; 
        string permission; 
        string phoneNumber; 
        string address; 
        string Email; 
        string birthDate; 
        string grade;
        string classNumber;
        string hobies;
        string freeTxt;
        string ParentEmail;

        /*
         *##########################
         * Get funcs 
         *##########################
         */

        public string getParentEmail()
        {
            return ParentEmail;
        }

        public string getFreeTxt()
        {
            return freeTxt;
        }

        public string getHobies()
        {
            return hobies;
        }

        public string getClassNumber()
        {
            return classNumber;
        }

        public string getGrade()
        {
            return grade;
        }

        public string getBirthDate()
        {
            return birthDate;

        }

        public string getEmail()
        {
            return Email;

        }

        public string getAddress()
        {
            return address;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public string getUsername()
        {
            return username;

        }

        public string getPassword()
        {
            return password;
        }

        public string getPermission()
        {
            return this.permission;
        }

        public string getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getLastName()
        {
            return lastName;
        }

        public User GetUser(string userId)
        {
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query_name = "Select name from users Where id = '" + userId + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query_name, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            name = dtbl.Rows[0][0].ToString().Trim();


            query_name = "Select lastName from users Where id = '" + userId + "'";
            sda = new SqlDataAdapter(query_name, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            lastName = dtbl.Rows[0][0].ToString().Trim();

            string query2 = "Select address from users Where id = '" + userId + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dtb2 = new DataTable();
            sda2.Fill(dtb2);
            address = dtb2.Rows[0][0].ToString().Trim();


            string query3 = "Select permission from users Where id = '" + userId + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
            DataTable dtb3 = new DataTable();
            sda3.Fill(dtb3);
            permission = dtb3.Rows[0][0].ToString().Trim();

            string query4 = "Select phoneNumber from users Where id = '" + userId + "'";
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
            DataTable dtb4 = new DataTable();
            sda4.Fill(dtb4);
            phoneNumber = dtb4.Rows[0][0].ToString().Trim();

            string query5 = "Select Email from users Where id = '" + userId + "'";
            SqlDataAdapter sda5 = new SqlDataAdapter(query5, con);
            DataTable dtb5 = new DataTable();
            sda5.Fill(dtb5);
            Email = dtb5.Rows[0][0].ToString().Trim();


            if (permission != "manager")
            {
                string query6 = "Select ParentEmail from users Where id = '" + userId + "'";
                SqlDataAdapter sda6 = new SqlDataAdapter(query6, con);
                DataTable dtb6 = new DataTable();
                sda6.Fill(dtb6);
                ParentEmail = dtb6.Rows[0][0].ToString().Trim();

                string query8 = "Select grade from users Where id = '" + userId + "'";
                SqlDataAdapter sda8 = new SqlDataAdapter(query8, con);
                DataTable dtb8 = new DataTable();
                sda8.Fill(dtb8);
                grade = dtb8.Rows[0][0].ToString().Trim();

                string query9 = "Select classNumber from users Where id = '" + userId + "'";
                SqlDataAdapter sda9 = new SqlDataAdapter(query9, con);
                DataTable dtb9 = new DataTable();
                sda9.Fill(dtb9);
                classNumber = dtb9.Rows[0][0].ToString().Trim();
            }

            string query7 = "Select birthDate from users Where id = '" + userId + "'";
            SqlDataAdapter sda7 = new SqlDataAdapter(query7, con);
            DataTable dtb7 = new DataTable();
            sda7.Fill(dtb7);
            birthDate = dtb7.Rows[0][0].ToString().Trim();

            

            string query10 = "Select hobies from users Where id = '" + userId + "'";
            SqlDataAdapter sda10 = new SqlDataAdapter(query10, con);
            DataTable dtb10 = new DataTable();
            sda10.Fill(dtb10);
            hobies = dtb10.Rows[0][0].ToString().Trim();

            string query11 = "Select freeTxt from users Where id = '" + userId + "'";
            SqlDataAdapter sda11 = new SqlDataAdapter(query11, con);
            DataTable dtb11 = new DataTable();
            sda11.Fill(dtb11);
            freeTxt = dtb11.Rows[0][0].ToString().Trim();


            string query12 = "Select userName from connection_details Where id = '" + userId + "'";
            SqlDataAdapter sda12 = new SqlDataAdapter(query12, con);
            DataTable dtb12 = new DataTable();
            sda12.Fill(dtb12);
            username = dtb12.Rows[0][0].ToString().Trim();


            string query13 = "Select password from connection_details Where id = '" + userId + "'";
            SqlDataAdapter sda13 = new SqlDataAdapter(query13, con);
            DataTable dtb13 = new DataTable();
            sda13.Fill(dtb13);
            password = dtb13.Rows[0][0].ToString().Trim();







            return this;

        }


        /*
         *##########################
         * Set funcs 
         *##########################
         */
        public void insertName(string name_input)
        {
            this.name = name_input;
        }

        public void insertLastName(string lastName_input)
        {
            this.lastName = lastName_input;
        }

        public void insertID(string id_input)
        {
            this.id = id_input;
        }

        public void insertPermission(string permission_input)
        {
            this.permission = permission_input;

        }

        public void insertUsername(string username_input)
        {
            this.username = username_input;
        }

        public void insertPassword(string password_input)
        {
            this.password = password_input;
        }

        public void SetPhoneNumber(string userId , string phoneNumber)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE users SET phoneNumber ='" + phoneNumber + "' WHERE id ='" + userId + "'", conn);
            cmd1.ExecuteNonQuery();
        }

        public void SetEmail(string userId, string Email)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE users SET Email ='" + Email + "' WHERE id ='" + userId + "'", conn);
            cmd1.ExecuteNonQuery();
        }

        public void DeleteUser(string userId)
        {
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();

            SqlDataAdapter sda;
            DataTable dtbl, dtbl1;
            con.Open();
            string query = "Select * from Events_to_Users where User_ID='" + userId  + "'";
            sda = new SqlDataAdapter(query, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            for(int i=0;i<dtbl.Rows.Count;i++)//Delete regular events
            {
                int eve_id = int.Parse(dtbl.Rows[i]["Event_ID"].ToString().Trim());
                SqlCommand cmd = new SqlCommand("DELETE FROM Events_to_Users WHERE Event_ID =" + eve_id, con);
                cmd.ExecuteNonQuery();

                query = "Select * from Events_to_Users where Event_ID='" + eve_id + "'";
                sda = new SqlDataAdapter(query, con);
                dtbl1 = new DataTable();
                sda.Fill(dtbl1);
                if(dtbl1.Rows.Count==0)
                {
                    cmd = new SqlCommand("DELETE FROM Events WHERE Event_ID =" + eve_id, con);
                    cmd.ExecuteNonQuery();
                }
            }

            query = "Select * from weekly_events_to_users where User_ID='" + userId + "'";
            sda = new SqlDataAdapter(query, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            for (int i = 0; i < dtbl.Rows.Count; i++)//Delete reception hour weekly events
            {
                int eve_id = int.Parse(dtbl.Rows[i]["wEvent_id"].ToString().Trim());
                SqlCommand cmd = new SqlCommand("DELETE FROM weekly_events_to_Users WHERE Event_ID =" + eve_id, con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM Events WHERE Event_ID =" + eve_id, con);
                cmd.ExecuteNonQuery();
            }

            query = "Select * from weekly_events where user_id_OR_class='" + userId + "'";
            sda = new SqlDataAdapter(query, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            for (int i = 0; i < dtbl.Rows.Count; i++)//Delete all weekly events
            {
                int eve_id = int.Parse(dtbl.Rows[i]["wEvent_id"].ToString().Trim());
                SqlCommand cmd = new SqlCommand("DELETE FROM Events WHERE Event_ID =" + eve_id, con);
                cmd.ExecuteNonQuery();
            }



            SqlCommand cmd1 = new SqlCommand("DELETE FROM users WHERE Id ='" + userId + "'", con);
            cmd1.ExecuteNonQuery();
            cmd1 = new SqlCommand("DELETE FROM connection_details WHERE Id ='" + userId + "'", con);
            cmd1.ExecuteNonQuery();
        }



    }

    
}

