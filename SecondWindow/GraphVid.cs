using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SecondWindow
{
    public partial class GraphVid : Form
    {
        private Timer timer1;
        int i = 0;
        ArrayList mylist1 = new ArrayList();
        ArrayList mylist2 = new ArrayList();
        Dictionary<double, double> mydict = new Dictionary<double, double>();
        
        public GraphVid()
        {
            InitializeComponent();

            InitTimer();

        }
        private void myplayer_Enter(object sender, EventArgs e)
        {

        }
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double current_time = myplayer.Ctlcontrols.currentPosition;
            MessageBox.Show(current_time.ToString());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            double current_time = myplayer.Ctlcontrols.currentPosition;
            
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=ratsimdb;UID=root;Password=''");

            MySqlCommand cmd = new MySqlCommand("select * from rattable", con);

            con.Open();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            //int[] stringArr = new int[20];
            //int[] stringArr2 = new int[20];
            timer1.Enabled = true;
            
            ArrayList listy = new ArrayList();
            ArrayList listy1 = new ArrayList();

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                timer1.Start();
                listy.Add(dr.Cells[0].Value);
                listy1.Add(dr.Cells[1].Value);
                chart1.Series[0].Points.DataBindXY(listy1, listy);
                timer1.Stop();
            }

            
           
            con.Close();



        }
        private void chart1_Click(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection("Server=localhost;Database=ratsimdb;UID=root;Password=''");

            //MySqlCommand cmd = new MySqlCommand("select * from rattable", con);

            //con.Open();

            //DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader());
            //dataGridView1.DataSource = dt;
            ////int[] stringArr = new int[20];
            ////int[] stringArr2 = new int[20];

            //ArrayList listy = new ArrayList();
            //ArrayList listy1 = new ArrayList();

            //foreach (DataGridViewRow dr in dataGridView1.Rows)
            //{
            //    listy.Add(dr.Cells[0].Value);
            //    listy1.Add(dr.Cells[1].Value);
            //}
            //chart1.Series[0].Points.DataBindXY(listy1, listy);
            //con.Close();
        }

        private void GraphVid_Load(object sender, EventArgs e)
        {
            
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //myplayer.Controls
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GraphVid_Load_1(object sender, EventArgs e)
        {

        }
    }
}
