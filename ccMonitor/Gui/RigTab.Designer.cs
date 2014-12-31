namespace ccMonitor.Gui
{
    partial class RigTab
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcRig = new System.Windows.Forms.TabControl();
            this.tabRigOverview = new System.Windows.Forms.TabPage();
            this.tabRigApiConsole = new System.Windows.Forms.TabPage();
            this.txtApiConsole = new System.Windows.Forms.TextBox();
            this.splitRigOverview = new System.Windows.Forms.SplitContainer();
            this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbcRig.SuspendLayout();
            this.tabRigOverview.SuspendLayout();
            this.tabRigApiConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRigOverview)).BeginInit();
            this.splitRigOverview.Panel2.SuspendLayout();
            this.splitRigOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcRig
            // 
            this.tbcRig.Controls.Add(this.tabRigOverview);
            this.tbcRig.Controls.Add(this.tabRigApiConsole);
            this.tbcRig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRig.Location = new System.Drawing.Point(0, 0);
            this.tbcRig.Name = "tbcRig";
            this.tbcRig.SelectedIndex = 0;
            this.tbcRig.Size = new System.Drawing.Size(1176, 586);
            this.tbcRig.TabIndex = 0;
            // 
            // tabRigOverview
            // 
            this.tabRigOverview.Controls.Add(this.splitRigOverview);
            this.tabRigOverview.Location = new System.Drawing.Point(4, 22);
            this.tabRigOverview.Name = "tabRigOverview";
            this.tabRigOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigOverview.Size = new System.Drawing.Size(1168, 560);
            this.tabRigOverview.TabIndex = 0;
            this.tabRigOverview.Text = "Rig overview";
            // 
            // tabRigApiConsole
            // 
            this.tabRigApiConsole.Controls.Add(this.txtApiConsole);
            this.tabRigApiConsole.Location = new System.Drawing.Point(4, 22);
            this.tabRigApiConsole.Name = "tabRigApiConsole";
            this.tabRigApiConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigApiConsole.Size = new System.Drawing.Size(1168, 560);
            this.tabRigApiConsole.TabIndex = 1;
            this.tabRigApiConsole.Text = "API console";
            // 
            // txtApiConsole
            // 
            this.txtApiConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtApiConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApiConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtApiConsole.Location = new System.Drawing.Point(3, 3);
            this.txtApiConsole.Multiline = true;
            this.txtApiConsole.Name = "txtApiConsole";
            this.txtApiConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtApiConsole.Size = new System.Drawing.Size(1162, 554);
            this.txtApiConsole.TabIndex = 0;
            this.txtApiConsole.Text = " >  ";
            this.txtApiConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApiConsole_KeyDown);
            // 
            // splitRigOverview
            // 
            this.splitRigOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRigOverview.Location = new System.Drawing.Point(3, 3);
            this.splitRigOverview.Name = "splitRigOverview";
            this.splitRigOverview.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRigOverview.Panel2
            // 
            this.splitRigOverview.Panel2.Controls.Add(this.chartStats);
            this.splitRigOverview.Size = new System.Drawing.Size(1162, 554);
            this.splitRigOverview.SplitterDistance = 283;
            this.splitRigOverview.TabIndex = 0;
            // 
            // chartStats
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Format = "g";
            chartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.AxisX.ScaleView.SmallScrollSize = 1D;
            chartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX2.IsMarginVisible = false;
            chartArea1.AxisX2.IsStartedFromZero = false;
            chartArea1.AxisX2.LabelStyle.Format = "g";
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Format = "#,##0,K";
            chartArea1.AxisY.Title = "Total hashrate (KH/s)";
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.AxisY2.LabelStyle.Format = "#,##0,K";
            chartArea1.AxisY2.Title = "Total hashrate (KH/s)";
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 10F;
            this.chartStats.ChartAreas.Add(chartArea1);
            this.chartStats.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.DockedToChartArea = "ChartArea";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend";
            this.chartStats.Legends.Add(legend1);
            this.chartStats.Location = new System.Drawing.Point(0, 0);
            this.chartStats.Margin = new System.Windows.Forms.Padding(0);
            this.chartStats.Name = "chartStats";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Legend = "Legend";
            series1.Name = "TotalSpreadSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend";
            series2.LegendText = "Hashrate";
            series2.Name = "TotalHashrateSeries";
            series2.ToolTip = "Time: #VALX{g} \\nHashrate: #VAL{N0} KH/s";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartStats.Series.Add(series1);
            this.chartStats.Series.Add(series2);
            this.chartStats.Size = new System.Drawing.Size(1162, 267);
            this.chartStats.TabIndex = 1;
            this.chartStats.Text = "chartStats";
            // 
            // RigTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcRig);
            this.Name = "RigTab";
            this.Size = new System.Drawing.Size(1176, 586);
            this.tbcRig.ResumeLayout(false);
            this.tabRigOverview.ResumeLayout(false);
            this.tabRigApiConsole.ResumeLayout(false);
            this.tabRigApiConsole.PerformLayout();
            this.splitRigOverview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRigOverview)).EndInit();
            this.splitRigOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabRigOverview;
        private System.Windows.Forms.TabPage tabRigApiConsole;
        private System.Windows.Forms.TextBox txtApiConsole;
        internal System.Windows.Forms.TabControl tbcRig;
        private System.Windows.Forms.SplitContainer splitRigOverview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
    }
}
