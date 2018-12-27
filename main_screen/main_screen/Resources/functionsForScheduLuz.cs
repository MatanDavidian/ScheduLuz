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
using database_location;
using System.IO;

namespace check_funcs
{

    public struct CheckDetails
    {

        public bool Check_onlyNums(string pnum)
        {
            int n;
            bool isNumeric = int.TryParse(pnum, out n);
            return isNumeric;
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

        public struct DBfuncs
        {
            public bool insertToEvents(string userID, string title, string details, string place, string privacy, string up_for_cancellation
                , DateTime date, string hours_start, string hours_end, string minutes_start, string minutes_end, string kind = "Regular")
            {
                try
                {
                    /*
                     * Values Test:                 
                     */
                    { /// checks.
                        CheckDetails checker = new CheckDetails();

                        if (!checker.Check_onlyNums(userID))
                        {
                            MessageBox.Show("id!");
                            return false;
                        }
                        else if (title.GetType() != "hi".GetType())
                        {
                            MessageBox.Show("title!");
                            return false;
                        }
                        else if (details.GetType() != "hi".GetType())
                        {
                            MessageBox.Show("details!");
                            return false;
                        }
                        else if (place.GetType() != "hi".GetType())
                        {
                            MessageBox.Show("place!");
                            return false;
                        }
                        else if (!(privacy.ToLower() == "private" || privacy.ToLower() == "public"))
                        {
                            MessageBox.Show("privacy!");
                            return false;
                        }
                        else if (!(up_for_cancellation.ToLower() == "yes" || up_for_cancellation.ToLower() == "no"))
                        {
                            MessageBox.Show("cancellation!");
                            return false;
                        }

                        else if (checker.Check_onlyNums(hours_start))
                        {

                            int hours_start_int = Int32.Parse(hours_start);
                            if (hours_start_int < 0 || hours_start_int > 23)
                            {
                                MessageBox.Show("h_start!");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("h_start!2");
                            return false;
                        }
                        if (checker.Check_onlyNums(hours_end))
                        {
                            int hours_end_int = Int32.Parse(hours_end);
                            if (hours_end_int < 0 || hours_end_int > 23)
                            {
                                MessageBox.Show("h_end!");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("h_end2!");
                            return false;
                        }
                        if (checker.Check_onlyNums(minutes_start))
                        {
                            int minutes_start_int = Int32.Parse(minutes_start);
                            if (minutes_start_int < 0 || minutes_start_int > 59)
                            {
                                MessageBox.Show("m_start!");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("m_start2!");
                            return false;
                        }
                        if (checker.Check_onlyNums(minutes_end))
                        {
                            int minutes_end_int = Int32.Parse(minutes_end);
                            if (minutes_end_int < 0 || minutes_end_int > 59)
                            {
                                MessageBox.Show("m_end!");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("m_end2!");
                            return false;
                        }
                        if (kind.GetType() != "hi".GetType())
                        {
                            MessageBox.Show("type!");
                            return false;
                        }



                    }// end of checks





                    /*
                     * if tests of input passed it will be insert to the data base.
                     * 
                     */
                    dataBase dataBase = new dataBase();
                    SqlConnection conn = dataBase.connect_to_scheduluz_DB();

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Events" +
                        "(Event_name,event_kind,date,hours_start,minutes_start,hours_end" +
                        ",minutes_end,Event_details,event_place,event_privacy,up_for_cancellation)" +
                        " VALUES(@Event_name,@event_kind,@date,@hours_start,@minutes_start,@hours_end" +
                        ",@minutes_end,@Event_details,@Place,@private_B,@up_for_cancellation) ", conn);

                    cmd.Parameters.Add("@up_for_cancellation", up_for_cancellation);
                    cmd.Parameters.Add("@event_kind", kind);
                    cmd.Parameters.Add("@Event_name", title);
                    cmd.Parameters.Add("@date", date);
                    cmd.Parameters.Add("@hours_start", hours_start);
                    cmd.Parameters.Add("@minutes_start", minutes_start);
                    cmd.Parameters.Add("@hours_end", hours_end);
                    cmd.Parameters.Add("@minutes_end", minutes_end);
                    cmd.Parameters.Add("@Event_details", details);
                    if (privacy.ToUpper() == "Private".ToUpper())
                    {
                        cmd.Parameters.Add("@private_B", "Private");
                    }
                    else
                    {
                        cmd.Parameters.Add("@private_B", "Public");
                    }
                    cmd.Parameters.Add("@Place", place);
                    cmd.ExecuteNonQuery();



                    //take the max id event from Event table
                    string query = "Select MAX(Event_id) from Events";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    int eve_id = int.Parse(dtbl.Rows[0][0].ToString().Trim());
                    //insert the max id event and the event id to Events_to_Users table
                    cmd = new SqlCommand("INSERT INTO Events_to_Users (User_ID,Event_ID) VALUES(@User_ID,@Event_ID) ", conn);
                    cmd.Parameters.Add("@User_ID", userID);
                    cmd.Parameters.Add("@Event_ID", eve_id);
                    cmd.ExecuteNonQuery();



                    return true;
                }

                catch
                {

                    return false;
                }

            }
        }

}


