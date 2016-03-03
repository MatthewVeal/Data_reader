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
        List<Data_entry> data_list = new List<Data_entry>();

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
              


        public class Session_data
        { }

        public class Data_entry
        { }



    }
}

