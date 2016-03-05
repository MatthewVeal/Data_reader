using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_one
{
    public partial class data_reader : Form
    {

        //Load text File
        Session_data session = new Session_data();
        string filepath = @"F:\SE-B\Assignment_one\data.txt";   //Text file location path
        string[] data;
        List<Data_List> data_list = new List<Data_List>();

        struct DataMark
        {
            public const string heart_rate = "[HRData]";
            public const string parameters = "[Params]";
            public const string IntTimes = "[IntTimes]";
        }

        struct SessionVar
        {
            public const string version = "Version";
            public const string smode = "SMode";
            public const string date = "Date";
            public const string start_time = "start_time";
            public const string length = "Length";
            public const string interval = "Interval";   
        }

        public data_reader()
        {
            InitializeComponent();
        }

        private void data_reader_Load(object sender, EventArgs e)
        {
            //Load data from text file
            data = load_data();

            if (data.Length > 0)
            {
                read_data(data);

                display_results();

                display_avergage();
            }
            else
            {
                Console.WriteLine("Data Failed To Load");
            }
        }
        
        private string[] load_data()
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);
            return lines;
        }
        
        private void read_data(string[] data)
        {
            Data_List data_entry;

            string parse_space = "";

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == DataMark.heart_rate)
                {
                    parse_space = DataMark.heart_rate;
                    i++;
                }

                if (data[i] == DataMark.parameters)
                {
                    parse_space = DataMark.parameters;
                    i++;
                }

                if (data[i] == DataMark.IntTimes)
                {
                    parse_space = DataMark.IntTimes;
                    i++;
                }

                if (parse_space == DataMark.parameters)
                {
                    string[] columns = data[i].Split('=');

                    if (columns[0] == SessionVar.version)
                    {
                        session.setVersion(columns[1]);
                    }
                    if (columns[0] == SessionVar.date)
                    {
                        session.set_Date(columns[1]);
                    }
                    if (columns[0] == SessionVar.length)
                    {
                        session.setLenth(columns[1]);
                    }
                    if (columns[0] == SessionVar.smode)
                    {
                        session.set_SMode(columns[1]);
                    }
                    if (columns[0] == SessionVar.start_time)
                    {
                        session.set_Start(columns[1]);
                    }
                    if (columns[0] == SessionVar.interval)
                    {
                        session.setInterval(columns[1]);                        
                    }
                }

                if (parse_space == DataMark.heart_rate)
                {
                          
                    string[] columns = data[i].Split(null);

                    data_entry = new Data_List();

                    data_entry.set_entry(int.Parse(columns[0]), int.Parse(columns[1]), int.Parse(columns[2]), int.Parse(columns[3]), int.Parse(columns[4]), int.Parse(columns[5]));
                    data_list.Add(data_entry);
                }
            }   
        }

        private void display_results()
        {
            this.length.Text = "Length : " + session.getLength();
            this.date.Text = "Date : " + session.getDate();
            this.start_time.Text = "Start Time : " + session.getset_Start();
            this.version.Text = "Version : " + session.getVersion();


            dataGridView2.ColumnCount = 7;
            dataGridView2.Columns[0].Name = "HR";
            dataGridView2.Columns[1].Name = "Speed";
            dataGridView2.Columns[2].Name = "Cadence";
            dataGridView2.Columns[3].Name = "Ascent";
            dataGridView2.Columns[4].Name = "Power";
            dataGridView2.Columns[5].Name = "PowerBal";
            dataGridView2.Columns[6].Name = "Time";

            Data_List dataEntry;
            DateTime time = session.getDateTime();
            int interval = int.Parse(session.getInterval()); //Times by interval to get accurate time data 

            // Loop through entries and do the ting accordingly 
            for (int i = 0; i < data_list.Count; i++)
            {
                dataEntry = data_list[i];

                dataGridView2.Rows.Add(dataEntry.getHeartRate(), dataEntry.getSpeed(), dataEntry.getCadence(), dataEntry.getAscent(), dataEntry.getPower(), dataEntry.getPowerBal(), time.AddSeconds(i * interval).TimeOfDay);
            }            
        }

        private void display_avergage()
        {
            throw new NotImplementedException();
        }

        public class Session_data
        {
            string version;
            string sMode;
            string date;
            string start_time;
            string length;
            string interval;

            public void setVersion(string version)
            {
                this.version = version;
            }
            public void set_SMode(string sMode)
            {
                this.sMode = sMode;
            }
            public void set_Date(string date)
            {
                this.date = date;
            }
            public void set_Start(string start_time)
            {
                this.start_time = start_time;
            }
            public void setLenth(string length)
            {
                this.length = length;
            }
            public void setInterval(string interval)
            {
                this.interval = interval;
            }

            public string getVersion() { return version; }
            public string getSMode() { return sMode; }
            public string getDate() { return date; }
            public string getset_Start() { return start_time; }
            public string getLength() { return length; }
            public string getInterval() { return interval; }

            public DateTime getDateTime()
            {          
                string  date    =   getDate();
                string  time    =   getset_Start();

                int year = int.Parse(date.Substring(0, 4));           
                int month = int.Parse(date.Substring(4, 2));
                int day = int.Parse(date.Substring(6, 2));
          

                int hour = int.Parse(time.Substring(0, 2));
                int minute = int.Parse(time.Substring(3, 2));
                int second = int.Parse(time.Substring(6, 2));

                DateTime dt =   new DateTime(year, month, day, hour, minute, second );
                return dt;
            }
        }
        public class Data_List
        {
                int heart_rate;  //bpm
                int speed;      //mmentary speed in Xtrainer units (km/h or mph = X/128)
                int cadence;    //rpm
                int ascent;     //Lap ascent value from XTr+ 10m / 10ft
                int power;      //Momentary power value in Watts
                int power_balance;   //Power Balance and pedalling index


                // Set an entry 
                public void set_entry(int heartRate, int speed, int cadence, int ascent, int power, int powerBal)
                {
                    this.heart_rate = heartRate;
                    this.speed = speed;
                    this.cadence = cadence;
                    this.ascent = ascent;
                    this.power = power;
                    this.power_balance = powerBal;
                }

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


