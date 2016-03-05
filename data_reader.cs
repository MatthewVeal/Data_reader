using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_reader
{
    public partial class data_reader : Form
    {

        Session_Data     session = new Session_Data();
        string filepath = @"F:\SE-B\Assignment_one\Data.txt";     //Points the program to
        string[]        data;
        List <data_list> session_data_list = new List<data_list>();

        struct SessionVar
        {
            public static string version = "Version";
            public static string smode = "SMode";
            public static string date = "Date";
            public static string startTime = "StartTime";
            public static string length = "Length";
            public static string interval = "Interval";
        }

        struct DataMark
        {
            public static string heart_rate = "[HRData]";
            public static string docInfo = "[Params]";
            public static string intTimes = "[IntTimes]";
        }

        public data_reader()
        {
            InitializeComponent();
        }

        private void data_reader_Load(object sender, EventArgs e)
        {
            data = load();

            if (data.Length > 0)
            {
                read_date(data);            

                display_results();
            }
            else
            {
                Console.WriteLine("Error Message 910: No Lines were read");
            }
        }


        private string[] load()
        {
            string[] lines = System.IO.File.ReadAllLines(filepath); //Load the text file
            return lines;
        }

        public void read_date(string[] data)
        { 
            data_list   enter_data;            
            string  pars   =   "";

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == DataMark.heart_rate) 
                {
                    pars   =   DataMark.heart_rate;
                    i++; 
                }
                if (data[i] == DataMark.docInfo)
                {
                    pars   =   DataMark.docInfo;
                    i++;
                }
                if (data[i] == DataMark.intTimes)
                {
                    pars   =   DataMark.intTimes;
                    i++;
                }

                if (pars == DataMark.docInfo)
                {
                    string[] column_split = data[i].Split('=');                   

                    if (column_split[0] == SessionVar.version)
                    {
                        session.setVersion(column_split[1]);
                    }
                    if (column_split[0] == SessionVar.date)
                    {
                        session.setDate(column_split[1]);
                    }
                    if (column_split[0] == SessionVar.length)
                    {
                        session.setLenth(column_split[1]);
                    }
                    if (column_split[0] == SessionVar.smode)
                    {
                        session.setSMode(column_split[1]);
                    }
                    if (column_split[0] == SessionVar.startTime)
                    {
                        session.setStartTime(column_split[1]);
                    }
                    if (column_split[0] == SessionVar.interval)
                    {
                        session.setInterval(column_split[1]);                        
                    }
                }

                    if (pars == DataMark.heart_rate)
                    {    
                        string[] columns = data[i].Split(null);

                        enter_data = new data_list();                    
                        enter_data.setEntry(int.Parse(columns[0]), int.Parse(columns[1]), int.Parse(columns[2]), int.Parse(columns[3]), int.Parse(columns[4]), int.Parse(columns[5]));
                        session_data_list.Add(enter_data);
                    }
            }
        }

        public void display_results()
            {
                this.length.Text    =   "Length : " + session.getLength();
                this.date.Text      =   "Date : " + session.getDate();
                this.start_time.Text =   "Start Time : " + session.getStartTime();
                this.version.Text   =   "Version : " + session.getVersion();

                dataView.ColumnCount = 7;
                dataView.Columns[0].Name = "Heart Rate";
                dataView.Columns[1].Name = "Speed";
                dataView.Columns[2].Name = "Cadence";
                dataView.Columns[3].Name = "Ascent";
                dataView.Columns[4].Name = "Power";
                dataView.Columns[5].Name = "Power to Balance";
                dataView.Columns[6].Name = "Time";

                data_list   data_entry;
                DateTime    time        =   session.getDateTime();            
                int         interval    =   int.Parse(session.getInterval()); 
            
                for (int i = 0; i < session_data_list.Count; i++)
                {                
                    data_entry = session_data_list[i];                   
                    dataView.Rows.Add(data_entry.getHeartRate(), data_entry.getSpeed(), data_entry.getCadence(), data_entry.getAscent(), data_entry.getPower(), data_entry.getPowerBal(), time.AddSeconds(i * interval).TimeOfDay );
                }            
            }

    }

        public class data_list
        {
            int heart_rate;  
            int speed;      
            int cadence;   
            int ascent;    
            int power;      
            int power_balance;  


        // Set an entry 
        public void setEntry(int heart_rate, int speed, int cadence, int ascent, int power, int powerBal)
        {
            this.heart_rate  =   heart_rate;
            this.speed      =   speed;
            this.cadence    =   cadence;
            this.ascent     =   ascent;
            this.power      =   power;
            this.power_balance   =   powerBal;
        }

        // Returns all data at once using individual calls 
        public string getEntry()
        {
            string  gap =   ", ";
            string data = getHeartRate() + gap + getSpeed() + gap + cadence + gap + ascent + gap + power + gap + power_balance + " ||";
            return data;            
        }

        public int getHeartRate()
        {
            return heart_rate;
        }
        public int getSpeed()
        {
            return speed;
        }
        public int getCadence()
        {
            return cadence;
        }
        public int getAscent()
        {
            return ascent;
        }
        public int getPower()
        {
            return power;
        }
        public int getPowerBal()
        {
            return power_balance;
        }
    }

        public class Session_Data
        {
            string  version;
            string  sMode;
            string  date;
            string  start_time;
            string  length;
            string  interval;
        

        public void setVersion(string version)
        {
            this.version    =   version;
        }
        public void setSMode(string sMode)
        {
            this.sMode  =   sMode;
        }
        public void setDate(string date)
        {
            this.date   =   date;
        }
        public void setStartTime(string startTime)
        {
            this.start_time  =   startTime;
        }
        public void setLenth(string length)
        {
            this.length =   length;
        }
        public void setInterval(string interval)
        {
            this.interval = interval;
        }

        public string getVersion()  { return version; }
        public string getSMode()    { return sMode; }
        public string getDate()     { return date; }
        public string getStartTime(){ return start_time; }
        public string getLength()   { return length; }
        public string getInterval() { return interval; }

        //Get date and time
        public DateTime getDateTime()
        {          
            string  date    =   getDate();
            string  time    =   getStartTime();

            int year = int.Parse(date.Substring(0, 4));           
            int month = int.Parse(date.Substring(4, 2));
            int day = int.Parse(date.Substring(6, 2));
          

            int hour = int.Parse(time.Substring(0, 2));
            int minute = int.Parse(time.Substring(3, 2));
            int second = int.Parse(time.Substring(6, 2));

            DateTime dt =   new DateTime(year, month, day, hour, minute, second );
            return dt;
        }

        public class data_list
        {
            int heart_rate;
            int speed;
            int cadence;
            int ascent;
            int power;
            int power_balance;


            // Set an entry 
            public void setEntry(int heartRate, int speed, int cadence, int ascent, int power, int powerBal)
            {
                this.heart_rate = heartRate;
                this.speed = speed;
                this.cadence = cadence;
                this.ascent = ascent;
                this.power = power;
                this.power_balance = powerBal;
            }

            // Returns all data at once using individual calls 
            public string getEntry()
            {
                string gap = ", ";
                string data = getHeartRate() + gap + getSpeed() + gap + cadence + gap + ascent + gap + power + gap + power_balance + " ||";
                return data;
            }

            public int getHeartRate()
            {
                return heart_rate;
            }
            public int getSpeed()
            {
                return speed;
            }
            public int getCadence()
            {
                return cadence;
            }
            public int getAscent()
            {
                return ascent;
            }
            public int getPower()
            {
                return power;
            }
            public int getPowerBal()
            {
                return power_balance;
            }
        }

    }
}
