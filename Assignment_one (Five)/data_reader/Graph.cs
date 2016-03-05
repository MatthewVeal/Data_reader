using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace data_reader
{
    public partial class Graph : Form
    {

        Session_Data session = new Session_Data();
        List<data_list> session_data_list = new List<data_list>();
        GraphPane graph_pane;

        LineItem line_one;
        LineItem line_two;
        LineItem line_three;
        LineItem line_four;
        LineItem line_five;

        PointPairList list_heart = new PointPairList();
        PointPairList list_speed = new PointPairList();
        PointPairList list_cadence = new PointPairList();
        PointPairList list_ascent = new PointPairList();
        PointPairList list_power = new PointPairList();
        PointPairList listPointsSix = new PointPairList();


        public Graph()
        {
            InitializeComponent();
        }

        public void show_data()
        {
            graph_pane = zedGraphControl1.GraphPane;

            graph_pane.Title.Text = "Session Data";
            graph_pane.XAxis.Title.Text = "Time (seconds)";
            graph_pane.YAxis.Title.Text = "Intensity";

            graph_pane.YAxis.Scale.Min = 10.0;
            graph_pane.YAxis.Scale.Max = 800.0;

            int length = session_data_list.Count;
            int interval = int.Parse(session.getInterval());

            graph_pane.XAxis.Scale.Min = 0;
            graph_pane.XAxis.Scale.Max = length * interval;
       
            for (int i = 0; i < length; i++)
            {
                data_list da = session_data_list[i];
                int it = i * interval;

                list_heart.Add(it, da.getHeartRate());
                list_speed.Add(it, da.getSpeed());
                list_cadence.Add(it, da.getCadence());
                list_ascent.Add(it, da.getAscent());
                list_power.Add(it, da.getPower());
            }

            line_one = graph_pane.AddCurve(null, list_heart, Color.Black, SymbolType.None);
            line_two = graph_pane.AddCurve(null, list_speed, Color.Purple, SymbolType.None);
            line_three = graph_pane.AddCurve(null, list_cadence, Color.Yellow, SymbolType.None);
            line_four = graph_pane.AddCurve(null, list_ascent, Color.Blue, SymbolType.None);
            line_five = graph_pane.AddCurve(null, list_power, Color.Orange, SymbolType.None);

            zedGraphControl1.AxisChange();
        }

        // Set data
        public void setData(Session_Data Session, List<data_list> data)
        {
            session = Session;
            session_data_list = data;
        }

        private void CB_heart_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_pane.CurveList.Contains(line_one))
            {
                graph_pane.CurveList.Remove(line_one);
            }
            else
            {
                line_one = graph_pane.AddCurve(null, list_heart, Color.Black, SymbolType.None);
            }
            graph_pane.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void CB_speed_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_pane.CurveList.Contains(line_two))
            {
                graph_pane.CurveList.Remove(line_two);
            }
            else
            {
                line_one = graph_pane.AddCurve(null, list_speed, Color.Purple, SymbolType.None);
            }
            graph_pane.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void CB_candence_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_pane.CurveList.Contains(line_three))
            {
                graph_pane.CurveList.Remove(line_three);
            }
            else
            {
                line_one = graph_pane.AddCurve(null, list_cadence, Color.Yellow, SymbolType.None);
            }
            graph_pane.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void CB_Ascent_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_pane.CurveList.Contains(line_four))
            {
                graph_pane.CurveList.Remove(line_four);
            }
            else
            {
                line_one = graph_pane.AddCurve(null, list_ascent, Color.Blue, SymbolType.None);
            }
            graph_pane.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void CB_power_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_pane.CurveList.Contains(line_five))
            {
                graph_pane.CurveList.Remove(line_five);
            }
            else
            {
                line_one = graph_pane.AddCurve(null, list_power, Color.Orange, SymbolType.None);
            }
            graph_pane.AxisChange();
            zedGraphControl1.Refresh();
        }
    }
}
