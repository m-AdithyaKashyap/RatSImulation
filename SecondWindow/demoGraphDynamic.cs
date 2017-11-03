using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SecondWindow
{
    public partial class demoGraphDynamic : Form
    {
        private Timer timer1;
        List<decimal> xvals = new List<decimal>();
        List<decimal> yvals = new List<decimal>();
        int count = 1;
        public demoGraphDynamic()
        {
            InitializeComponent();
            InitTimer();
        }
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal current_time = (decimal)myplayer.Ctlcontrols.currentPosition;

            xvals.Add(count);
          
            yvals.Add(current_time);
            
            
            count = count + 1;

            Chart1.Series[0].XValueType = ChartValueType.Auto;
            Chart1.Series[0].YValueType = ChartValueType.Auto;
            Chart1.Series[0].Points.DataBindXY(xvals.ToArray(), yvals.ToArray());
            Chart1.DataBind();
            Chart1.Visible = true;
        }
        private void demoGraphDynamic_Load(object sender, EventArgs e)
        {

        }
    }
}
