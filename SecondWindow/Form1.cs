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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
                
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void k12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Adi");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=ratsimdb;UID=root;Password=''");

            MySqlCommand cmd = new MySqlCommand( "select * from rattable", con);

            con.Open();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            //int[] stringArr = new int[20];
            //int[] stringArr2 = new int[20];
       
            ArrayList listy = new ArrayList();
            ArrayList listy1 = new ArrayList();
            
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                listy.Add(dr.Cells[0].Value);
                listy1.Add(dr.Cells[1].Value);
            }
            chart1.Series[0].Points.DataBindXY(listy1, listy);
            con.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            kofflabel.Text = trackBar1.Value.ToString()  ;
            //trackBar1.Value=int.Parse(label19.Text);
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            kofflabel.Text = trackBar1.Value.ToString()+ "s";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            doselabel.Text = trackBar3.Value.ToString()+"nM";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            dstlabell.Text = trackBar4.Value.ToString()+"nM";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
