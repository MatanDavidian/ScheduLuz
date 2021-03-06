﻿using System;
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
using database_location;
using System.IO;
namespace main_screen
{
    public partial class log_in_page : Form
    {
        public static string loginUserName;
        public static string permission;
        public static string userId;
        public log_in_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();
                string query = "Select permission from connection_details Where userName = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                SqlConnection con2 = dataBase.connect_to_scheduluz_DB();
                string query2 = "Select id from connection_details Where userName = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con2);
                DataTable dtb2 = new DataTable();
                sda2.Fill(dtb2);

                /*creating text file for later use.
                 * for permission only
                 * M for manager
                 * T for teacher
                 * S for student
                 */
                //       StreamWriter perFile = new StreamWriter("permissionFile.txt");
                //       StreamWriter userFile = new StreamWriter("userFile.txt");



                if (dtbl.Rows.Count > 0)
                {
                    /*
                     * the next code part is storing the user permission for later use 
                     */
                    User user = new User();
                    user.insertID(dtb2.Rows[0][0].ToString().Trim());
                    user.insertPermission(dtbl.Rows[0][0].ToString().Trim());
                    user.insertUsername(textBox1.Text.Trim());
                    user.insertPassword(textBox2.Text.Trim());
                    userId = user.getID();

                    permission = user.getPermission();

                    if (user.getPassword() != user.getID())
                    {

                        string per = user.getPermission();

                        if (per == "manager")
                        {
                            ManagerCalander Mc = new ManagerCalander();
                            this.Hide();
                            // perFile.Write("M");
                            loginUserName = textBox1.Text;
                            insert_logins_report();

                            //perFile.Close();
                            Mc.Show();
                        }
                        if (per == "teacher")
                        {
                            TeacherCalander Tc = new TeacherCalander();
                            this.Hide();
                            //           perFile.Write("T");
                            loginUserName = textBox1.Text;
                            insert_logins_report();
                            //perFile.Close();
                            Tc.Show();
                        }
                        if (per == "student")
                        {
                            StudentCalander Sc = new StudentCalander();
                            this.Hide();
                            //           perFile.Write("S");
                            loginUserName = textBox1.Text;
                            insert_logins_report();
                            //           perFile.Close();
                            Sc.Show();
                        }
                        /* userFile.WriteLine(user.getID());
                         userFile.WriteLine(user.getPassword());
                         userFile.WriteLine(user.getPermission());
                         userFile.WriteLine("username: " + user.getUsername());
                         userFile.Close();*/
                    }

                    else
                    {
                        /*
                         *the user need to configure his details, 
                         *becuse it is the first entering to the system 
                         * 
                         * need to open the from Profile
                         * 
                         */
                        general_process.firstProfileChange p = new general_process.firstProfileChange();
                        this.Hide();
                        string per = user.getPermission();
                        //        perFile.Write(per[0]);
                        //       perFile.Close();


                        //       userFile.WriteLine(user.getID());
                        //        userFile.WriteLine(user.getPassword());
                        //       userFile.WriteLine(user.getPermission());
                        //       userFile.WriteLine("username: " + user.getUsername());
                        //       userFile.Close();
                        p.Show();



                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    //    perFile.Close();
                    //    userFile.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Connection problem detected. please contact your ScheduLuz guide with this code:"+ ex.GetType().ToString());

            }
        
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void insert_logins_report()
        {
            dataBase loging_dataBase = new dataBase();
            SqlConnection conn = loging_dataBase.connect_to_scheduluz_DB();
            DateTime dt = DateTime.Now;
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO logins_report(date,user_id,user_name,connectORdisconnect) VALUES(@date,@user_id,@user_name,@connectORdisconnect) ", conn);
            cmd.Parameters.Add("@date", dt);
            cmd.Parameters.Add("@user_id", log_in_page.userId);
            cmd.Parameters.Add("@user_name", log_in_page.loginUserName);
            cmd.Parameters.Add("@connectORdisconnect", "connect");
            cmd.ExecuteNonQuery();
        }
    }
}
