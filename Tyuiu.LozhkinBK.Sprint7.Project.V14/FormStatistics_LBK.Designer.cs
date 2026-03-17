namespace Tyuiu.LozhkinBK.Sprint7.Project.V14.Forms
{
    partial class FormStatistics_LBK
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
            this.labelTotalRoutes_LBK = new System.Windows.Forms.Label();
            this.labelAverageTravelTime_LBK = new System.Windows.Forms.Label();
            this.labelMinTravelTime_LBK = new System.Windows.Forms.Label();
            this.labelMaxTravelTime_LBK = new System.Windows.Forms.Label();
            this.chartStatistics_LBK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics_LBK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalRoutes_LBK
            // 
            this.labelTotalRoutes_LBK.AutoSize = true;
            this.labelTotalRoutes_LBK.Location = new System.Drawing.Point(26, 35);
            this.labelTotalRoutes_LBK.Name = "labelTotalRoutes_LBK";
            this.labelTotalRoutes_LBK.Size = new System.Drawing.Size(64, 25);
            this.labelTotalRoutes_LBK.TabIndex = 0;
            this.labelTotalRoutes_LBK.Text = "label1";
        
            // 
            // labelAverageTravelTime_LBK
            // 
            this.labelAverageTravelTime_LBK.AutoSize = true;
            this.labelAverageTravelTime_LBK.Location = new System.Drawing.Point(26, 83);
            this.labelAverageTravelTime_LBK.Name = "labelAverageTravelTime_LBK";
            this.labelAverageTravelTime_LBK.Size = new System.Drawing.Size(64, 25);
            this.labelAverageTravelTime_LBK.TabIndex = 1;
            this.labelAverageTravelTime_LBK.Text = "label1";
            // 
            // labelMinTravelTime_LBK
            // 
            this.labelMinTravelTime_LBK.AutoSize = true;
            this.labelMinTravelTime_LBK.Location = new System.Drawing.Point(26, 135);
            this.labelMinTravelTime_LBK.Name = "labelMinTravelTime_LBK";
            this.labelMinTravelTime_LBK.Size = new System.Drawing.Size(64, 25);
            this.labelMinTravelTime_LBK.TabIndex = 2;
            this.labelMinTravelTime_LBK.Text = "label1";
            // 
            // labelMaxTravelTime_LBK
            // 
            this.labelMaxTravelTime_LBK.AutoSize = true;
            this.labelMaxTravelTime_LBK.Location = new System.Drawing.Point(26, 190);
            this.labelMaxTravelTime_LBK.Name = "labelMaxTravelTime_LBK";
            this.labelMaxTravelTime_LBK.Size = new System.Drawing.Size(64, 25);
            this.labelMaxTravelTime_LBK.TabIndex = 3;
            this.labelMaxTravelTime_LBK.Text = "label1";
            // 
            // chartStatistics_LBK
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistics_LBK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics_LBK.Legends.Add(legend1);
            this.chartStatistics_LBK.Location = new System.Drawing.Point(43, 324);
            this.chartStatistics_LBK.Name = "chartStatistics_LBK";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatistics_LBK.Series.Add(series1);
            this.chartStatistics_LBK.Size = new System.Drawing.Size(681, 445);
            this.chartStatistics_LBK.TabIndex = 4;
            this.chartStatistics_LBK.Text = "chart1";
            // 
            // FormStatistics_LBK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 984);
            this.Controls.Add(this.chartStatistics_LBK);
            this.Controls.Add(this.labelMaxTravelTime_LBK);
            this.Controls.Add(this.labelMinTravelTime_LBK);
            this.Controls.Add(this.labelAverageTravelTime_LBK);
            this.Controls.Add(this.labelTotalRoutes_LBK);
            this.Name = "FormStatistics_LBK";
            this.Text = "FormStatistics_LBK";
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics_LBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalRoutes_LBK;
        private System.Windows.Forms.Label labelAverageTravelTime_LBK;
        private System.Windows.Forms.Label labelMinTravelTime_LBK;
        private System.Windows.Forms.Label labelMaxTravelTime_LBK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics_LBK;
    }
}