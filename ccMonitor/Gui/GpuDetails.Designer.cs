namespace ccMonitor.Gui
{
    partial class GpuDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitGpuDetails = new System.Windows.Forms.SplitContainer();
            this.grpHashrateSpread = new System.Windows.Forms.GroupBox();
            this.chartSpread = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitHashesAndSensors = new System.Windows.Forms.SplitContainer();
            this.grpDetailedStatistics = new System.Windows.Forms.GroupBox();
            this.splitStatsAndSpread = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitGpuDetails)).BeginInit();
            this.splitGpuDetails.Panel1.SuspendLayout();
            this.splitGpuDetails.Panel2.SuspendLayout();
            this.splitGpuDetails.SuspendLayout();
            this.grpHashrateSpread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitHashesAndSensors)).BeginInit();
            this.splitHashesAndSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStatsAndSpread)).BeginInit();
            this.splitStatsAndSpread.Panel1.SuspendLayout();
            this.splitStatsAndSpread.Panel2.SuspendLayout();
            this.splitStatsAndSpread.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitGpuDetails
            // 
            this.splitGpuDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGpuDetails.Location = new System.Drawing.Point(0, 0);
            this.splitGpuDetails.Name = "splitGpuDetails";
            this.splitGpuDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGpuDetails.Panel1
            // 
            this.splitGpuDetails.Panel1.Controls.Add(this.splitStatsAndSpread);
            // 
            // splitGpuDetails.Panel2
            // 
            this.splitGpuDetails.Panel2.Controls.Add(this.splitHashesAndSensors);
            this.splitGpuDetails.Size = new System.Drawing.Size(1150, 525);
            this.splitGpuDetails.SplitterDistance = 209;
            this.splitGpuDetails.TabIndex = 0;
            // 
            // grpHashrateSpread
            // 
            this.grpHashrateSpread.Controls.Add(this.chartSpread);
            this.grpHashrateSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHashrateSpread.Location = new System.Drawing.Point(0, 0);
            this.grpHashrateSpread.Name = "grpHashrateSpread";
            this.grpHashrateSpread.Size = new System.Drawing.Size(555, 209);
            this.grpHashrateSpread.TabIndex = 56;
            this.grpHashrateSpread.TabStop = false;
            this.grpHashrateSpread.Text = "Hashrate spread";
            // 
            // chartSpread
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Format = "0.00000000";
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.Name = "ChartArea";
            this.chartSpread.ChartAreas.Add(chartArea1);
            this.chartSpread.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartSpread.Location = new System.Drawing.Point(252, 16);
            this.chartSpread.Name = "chartSpread";
            series1.BorderColor = System.Drawing.Color.Gold;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series1.Color = System.Drawing.Color.Gold;
            series1.Name = "BoxPlotSeries";
            series1.YValuesPerPoint = 6;
            this.chartSpread.Series.Add(series1);
            this.chartSpread.Size = new System.Drawing.Size(300, 190);
            this.chartSpread.TabIndex = 53;
            this.chartSpread.Text = "chart2";
            // 
            // splitHashesAndSensors
            // 
            this.splitHashesAndSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHashesAndSensors.Location = new System.Drawing.Point(0, 0);
            this.splitHashesAndSensors.Name = "splitHashesAndSensors";
            this.splitHashesAndSensors.Size = new System.Drawing.Size(1150, 312);
            this.splitHashesAndSensors.SplitterDistance = 454;
            this.splitHashesAndSensors.TabIndex = 0;
            // 
            // grpDetailedStatistics
            // 
            this.grpDetailedStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetailedStatistics.Location = new System.Drawing.Point(0, 0);
            this.grpDetailedStatistics.Name = "grpDetailedStatistics";
            this.grpDetailedStatistics.Size = new System.Drawing.Size(591, 209);
            this.grpDetailedStatistics.TabIndex = 0;
            this.grpDetailedStatistics.TabStop = false;
            this.grpDetailedStatistics.Text = "Detailed statistics";
            // 
            // splitStatsAndSpread
            // 
            this.splitStatsAndSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStatsAndSpread.Location = new System.Drawing.Point(0, 0);
            this.splitStatsAndSpread.Name = "splitStatsAndSpread";
            // 
            // splitStatsAndSpread.Panel1
            // 
            this.splitStatsAndSpread.Panel1.Controls.Add(this.grpDetailedStatistics);
            // 
            // splitStatsAndSpread.Panel2
            // 
            this.splitStatsAndSpread.Panel2.Controls.Add(this.grpHashrateSpread);
            this.splitStatsAndSpread.Size = new System.Drawing.Size(1150, 209);
            this.splitStatsAndSpread.SplitterDistance = 591;
            this.splitStatsAndSpread.TabIndex = 0;
            // 
            // GpuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitGpuDetails);
            this.Name = "GpuDetails";
            this.Size = new System.Drawing.Size(1150, 525);
            this.splitGpuDetails.Panel1.ResumeLayout(false);
            this.splitGpuDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGpuDetails)).EndInit();
            this.splitGpuDetails.ResumeLayout(false);
            this.grpHashrateSpread.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitHashesAndSensors)).EndInit();
            this.splitHashesAndSensors.ResumeLayout(false);
            this.splitStatsAndSpread.Panel1.ResumeLayout(false);
            this.splitStatsAndSpread.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStatsAndSpread)).EndInit();
            this.splitStatsAndSpread.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitGpuDetails;
        private System.Windows.Forms.GroupBox grpDetailedStatistics;
        private System.Windows.Forms.SplitContainer splitHashesAndSensors;
        private System.Windows.Forms.GroupBox grpHashrateSpread;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpread;
        private System.Windows.Forms.SplitContainer splitStatsAndSpread;
    }
}
