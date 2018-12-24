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


namespace Event
{
    public struct Event
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
        string eventID;
        List<string> usersID;
        bool weekly; 
        string title; 
        string details; 
        string place; 
        bool isPrivate;
        bool cancelable;
        DateTime date;
        string day_in_week;
        string hours_start; 
        string hours_end; 
        string minute_start; 
        string minute_end;
        string kind;
        Color color;


        /*
         *##########################
         * Get funcs 
         *##########################
         */
        
        public string getEventID() => eventID;
        public List<string> getUsersID() => usersID;
        public string getTitle() => title;
        public bool isCancelable() => cancelable;
        public string getDayInWeek() => day_in_week;
        public bool IsWeekly()
        {
            return weekly;
        }
        public string getDetails()
        {
            return details;
        }
        public string getPlace()
        {
            return place;
        }
        public bool IsPrivate()
        {
            return isPrivate;
        }
        public DateTime getTheDate()
        {
            if(day_in_week== null)
                return date;
            return new DateTime();

        }
        public string getHours_start()
        {
            return hours_start;

        }
        public string getHours_end()
        {
            return hours_end;

        }
        public string getMinutes_end()
        {
            return minute_end;

        }
        public string getMinutes_start()
        {
            return minute_start;

        }
        public string getKind()
        {
            return kind;

        }
        public Color getKindColor()
        {
            return color;
        }
        public Event getEvent(string eventid , bool isweekly)
        {
            Event n = new Event();
            n.usersID = new List<string>();
            n.eventID = eventid;
            n.weekly = isweekly;

            if (!n.weekly)
            {
                n.day_in_week = null;
                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();
                string query_name = "Select * from Events Where Event_id = " + n.eventID ;
                SqlDataAdapter sda = new SqlDataAdapter(query_name, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    string query_name2 = "Select User_id from Events_to_Users Where Event_ID = " + n.eventID ;
                    SqlDataAdapter sda2 = new SqlDataAdapter(query_name, con);
                    DataTable dtb2 = new DataTable();
                    sda2.Fill(dtb2);
                    if(dtb2.Rows.Count == 0)
                    {
                        return n;
                    }
                    else
                    {
                        n.usersID.Add(dtb2.Rows[0][0].ToString().Trim());
                    }

                    n.title = dtb.Rows[0]["Event_name"].ToString().Trim();
                    n.details = dtb.Rows[0]["Event_details"].ToString().Trim();
                    n.kind = dtb.Rows[0]["Event_kind"].ToString().Trim();
                    n.place = dtb.Rows[0]["Event_place"].ToString().Trim();
                    n.date = DateTime.Parse(dtb.Rows[0]["date"].ToString().Trim());
                    n.hours_start = dtb.Rows[0]["hours_start"].ToString().Trim();
                    n.hours_end = dtb.Rows[0]["hours_end"].ToString().Trim();
                    n.minute_start = dtb.Rows[0]["minutes_start"].ToString().Trim();
                    n.minute_end = dtb.Rows[0]["minutes_end"].ToString().Trim();

                    if (dtb.Rows[0]["Event_privacy"].ToString().Trim().ToLower() == ("public"))
                    {
                        n.isPrivate = false;
                    }
                    else if (dtb.Rows[0]["Event_privacy"].ToString().Trim().ToLower() == ("private"))
                    {
                        n.isPrivate = true;
                    }
                    if (dtb.Rows[0]["up_for_cancellation"].ToString().Trim().ToLower() == ("yes"))
                    {
                        n.isPrivate = true;
                    }
                    else if (dtb.Rows[0]["up_for_cancellation"].ToString().Trim().ToLower() == ("no"))
                    {
                        n.isPrivate = false;
                    }

                    switch (n.kind)
                    {
                        case "Muliplayer":
                            color = Color.DeepSkyBlue;
                            break;

                        case "School":
                            color = Color.Red;
                            break;

                        case "Regular":
                            color = Color.SteelBlue;
                            break;
                        case "system-public":
                            color = Color.Red;
                            break;
                        case "HW":
                            color = Color.YellowGreen;
                            break;

                        default:
                            break;
                    }

                }



            }
            else if (n.weekly)
            {
                
                n.cancelable = true;
                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();
                string query_name = "Select * from weekly_events Where wEvent_id = " + n.eventID;
                SqlDataAdapter sda = new SqlDataAdapter(query_name, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    string tempusers= dtb.Rows[0]["user_id_OR_class"].ToString().Trim();
                    if (tempusers.Contains("-")) // if its a class not a teacher
                    {
                        string tempClass = "";
                        string tempGrade = "";

                        int i = 0;
                        while (tempusers[i]!='-')
                        {
                            tempGrade = tempGrade + tempusers[i];
                            i++;
                        }
                        i++;
                        tempClass = tempusers[i].ToString();


                        
                        string query_name3 = "Select id from users Where grade = '" +tempGrade + "' and classNumber ='"+tempClass+"' and permission = 'student'";
                        SqlDataAdapter sda3 = new SqlDataAdapter(query_name, con);
                        DataTable dtb3 = new DataTable();
                        sda3.Fill(dtb3);

                        for(i = 0; i<dtb3.Rows.Count;i++)
                        {
                            n.usersID.Add(dtb3.Rows[i][0].ToString().Trim());
                        }


                    }
                    else
                    {
                        n.usersID.Add(tempusers);
                    }




                    n.title = dtb.Rows[0]["title"].ToString().Trim();
                    n.details = "";
                    n.kind = dtb.Rows[0]["event_kind"].ToString().Trim();
                    n.place = "School";
                    n.day_in_week = dtb.Rows[0]["day_in_week"].ToString().Trim();
                    n.hours_start = dtb.Rows[0]["start"].ToString().Trim();
                    n.hours_end = dtb.Rows[0]["ends"].ToString().Trim();
                    n.minute_start = "0";
                    n.minute_end = "0";
                    n.isPrivate = false;
          
                    color = Color.Orange;
                 
                }


            }

           return n;
        }
        public string getEventID(bool isweakly , string title , string hours_start ,string  hours_end ,string minutes_start= "0", string minutes_end="0")
        {
            string id="";
            dataBase dataBase = new dataBase();
            SqlConnection con = dataBase.connect_to_scheduluz_DB();
            string query_name = "Select id from Events Where Event_name = '" + title + "' and hours_start='"+hours_start+"' and minutes_start='" +
                minutes_start+"' and hours_end='"+hours_end+"' and minutes_end='"+minutes_end+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query_name, con);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);


            return id;
        }






    }

    
}

