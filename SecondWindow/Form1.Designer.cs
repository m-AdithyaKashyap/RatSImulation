namespace SecondWindow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kofflabel = new System.Windows.Forms.Label();
            this.k10label = new System.Windows.Forms.Label();
            this.k12label = new System.Windows.Forms.Label();
            this.doselabel = new System.Windows.Forms.Label();
            this.dstlabell = new System.Windows.Forms.Label();
            this.k21label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series1.MarkerSize = 25;
            series1.Name = "Graph 1";
            series1.XValueMember = "Cocaine level (nmol/kg)";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueMembers = "Session Time(s)";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.LabelForeColor = System.Drawing.Color.DarkBlue;
            series2.Legend = "Legend1";
            series2.Name = "Graph 2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(744, 365);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(842, 503);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(842, 552);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(842, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Graph 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(842, 394);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Graph 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(842, 453);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 17);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "Graph 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(89, 409);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(143, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // trackBar6
            // 
            this.trackBar6.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar6.Enabled = false;
            this.trackBar6.Location = new System.Drawing.Point(89, 552);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(132, 45);
            this.trackBar6.TabIndex = 24;
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(490, 409);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(132, 45);
            this.trackBar2.TabIndex = 26;
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 4000;
            this.trackBar3.Location = new System.Drawing.Point(490, 552);
            this.trackBar3.Maximum = 12000;
            this.trackBar3.Minimum = 300;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(132, 45);
            this.trackBar3.SmallChange = 1000;
            this.trackBar3.TabIndex = 27;
            this.trackBar3.TickFrequency = 4;
            this.trackBar3.Value = 300;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 100;
            this.trackBar4.Location = new System.Drawing.Point(490, 481);
            this.trackBar4.Maximum = 500;
            this.trackBar4.Minimum = 300;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(132, 45);
            this.trackBar4.SmallChange = 100;
            this.trackBar4.TabIndex = 28;
            this.trackBar4.TickFrequency = 4;
            this.trackBar4.Value = 300;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "koff";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar5.Enabled = false;
            this.trackBar5.Location = new System.Drawing.Point(89, 481);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(132, 45);
            this.trackBar5.TabIndex = 32;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(791, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(421, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Dose";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(424, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "DST";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(424, 418);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "k21";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 562);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "k12";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 489);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "k10";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(762, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 173);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // kofflabel
            // 
            this.kofflabel.AutoSize = true;
            this.kofflabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kofflabel.Location = new System.Drawing.Point(248, 406);
            this.kofflabel.Name = "kofflabel";
            this.kofflabel.Size = new System.Drawing.Size(44, 29);
            this.kofflabel.TabIndex = 50;
            this.kofflabel.Tag = "s";
            this.kofflabel.Text = "0 s";
            this.kofflabel.Click += new System.EventHandler(this.label19_Click);
            // 
            // k10label
            // 
            this.k10label.AutoSize = true;
            this.k10label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k10label.Location = new System.Drawing.Point(248, 477);
            this.k10label.Name = "k10label";
            this.k10label.Size = new System.Drawing.Size(26, 29);
            this.k10label.TabIndex = 51;
            this.k10label.Text = "0";
            // 
            // k12label
            // 
            this.k12label.AutoSize = true;
            this.k12label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k12label.Location = new System.Drawing.Point(248, 545);
            this.k12label.Name = "k12label";
            this.k12label.Size = new System.Drawing.Size(26, 29);
            this.k12label.TabIndex = 52;
            this.k12label.Text = "0";
            // 
            // doselabel
            // 
            this.doselabel.AutoSize = true;
            this.doselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doselabel.Location = new System.Drawing.Point(640, 545);
            this.doselabel.Name = "doselabel";
            this.doselabel.Size = new System.Drawing.Size(26, 29);
            this.doselabel.TabIndex = 53;
            this.doselabel.Text = "0";
            this.doselabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // dstlabell
            // 
            this.dstlabell.AutoSize = true;
            this.dstlabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstlabell.Location = new System.Drawing.Point(640, 481);
            this.dstlabell.Name = "dstlabell";
            this.dstlabell.Size = new System.Drawing.Size(26, 29);
            this.dstlabell.TabIndex = 54;
            this.dstlabell.Text = "0";
            this.dstlabell.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // k21label
            // 
            this.k21label.AutoSize = true;
            this.k21label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k21label.Location = new System.Drawing.Point(640, 406);
            this.k21label.Name = "k21label";
            this.k21label.Size = new System.Drawing.Size(26, 29);
            this.k21label.TabIndex = 55;
            this.k21label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 648);
            this.Controls.Add(this.k21label);
            this.Controls.Add(this.dstlabell);
            this.Controls.Add(this.doselabel);
            this.Controls.Add(this.k12label);
            this.Controls.Add(this.k10label);
            this.Controls.Add(this.kofflabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label kofflabel;
        private System.Windows.Forms.Label k10label;
        private System.Windows.Forms.Label k12label;
        private System.Windows.Forms.Label doselabel;
        private System.Windows.Forms.Label dstlabell;
        private System.Windows.Forms.Label k21label;
    }
}

