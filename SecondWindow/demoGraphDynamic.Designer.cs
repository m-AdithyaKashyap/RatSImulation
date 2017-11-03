namespace SecondWindow
{
    partial class demoGraphDynamic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demoGraphDynamic));
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.myplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(387, 12);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(450, 572);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "chart1";
            // 
            // myplayer
            // 
            this.myplayer.Enabled = true;
            this.myplayer.Location = new System.Drawing.Point(12, 12);
            this.myplayer.Name = "myplayer";
            this.myplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("myplayer.OcxState")));
            this.myplayer.Size = new System.Drawing.Size(359, 314);
            this.myplayer.TabIndex = 1;
            // 
            // demoGraphDynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 596);
            this.Controls.Add(this.myplayer);
            this.Controls.Add(this.Chart1);
            this.Name = "demoGraphDynamic";
            this.Text = "demoGraphDynamic";
            this.Load += new System.EventHandler(this.demoGraphDynamic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private AxWMPLib.AxWindowsMediaPlayer myplayer;
    }
}