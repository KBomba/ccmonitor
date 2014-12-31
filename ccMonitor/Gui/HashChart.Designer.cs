namespace ccMonitor.Gui
{
    partial class HashChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartHash = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHash)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHash
            // 
            chartArea1.AlignWithChartArea = "ChartAreaDifficultyHashcount";
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
            chartArea1.AxisY.Title = "Hashrate";
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.Maximum = 5D;
            chartArea1.AxisY2.Title = "Found";
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartAreaFoundHashrate";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 39.55485F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 8.945152F;
            chartArea2.AlignWithChartArea = "ChartAreaFoundHashrate";
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.Format = "g";
            chartArea2.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea2.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea2.AxisX.ScaleView.SmallScrollSize = 1D;
            chartArea2.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea2.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX2.IsMarginVisible = false;
            chartArea2.AxisX2.IsStartedFromZero = false;
            chartArea2.AxisX2.LabelStyle.Format = "g";
            chartArea2.AxisY.IsLogarithmic = true;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Format = "#,##0,,M";
            chartArea2.AxisY.Title = "Hash count";
            chartArea2.AxisY2.IsStartedFromZero = false;
            chartArea2.AxisY2.LabelStyle.Format = "0.###";
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.Title = "Difficulty";
            chartArea2.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartAreaDifficultyHashcount";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 39.55485F;
            chartArea2.Position.Width = 100F;
            chartArea2.Position.Y = 57.44515F;
            this.chartHash.ChartAreas.Add(chartArea1);
            this.chartHash.ChartAreas.Add(chartArea2);
            this.chartHash.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.DockedToChartArea = "ChartAreaFoundHashrate";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "LegendFoundHashrate";
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend2.DockedToChartArea = "ChartAreaDifficultyHashcount";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.IsDockedInsideChartArea = false;
            legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend2.Name = "LegendDifficultyHashcount";
            this.chartHash.Legends.Add(legend1);
            this.chartHash.Legends.Add(legend2);
            this.chartHash.Location = new System.Drawing.Point(0, 0);
            this.chartHash.Margin = new System.Windows.Forms.Padding(0);
            this.chartHash.Name = "chartHash";
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartAreaFoundHashrate";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsVisibleInLegend = false;
            series1.Legend = "LegendFoundHashrate";
            series1.Name = "AvailabilityFoundSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.ChartArea = "ChartAreaFoundHashrate";
            series2.Color = System.Drawing.Color.Goldenrod;
            series2.CustomProperties = "EmptyPointValue=Zero, PointWidth=1";
            series2.Legend = "LegendFoundHashrate";
            series2.LegendText = "Found";
            series2.Name = "FoundSeries";
            series2.ToolTip = "Time: #VALX{g} \\nFound: #VAL{N0}";
            series2.XValueMember = "TimeStamp";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueMembers = "Found";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartAreaFoundHashrate";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.CustomProperties = "IsXAxisQuantitative=True";
            series3.Legend = "LegendFoundHashrate";
            series3.LegendText = "Hashrate";
            series3.Name = "HashrateSeries";
            series3.ToolTip = "Time: #VALX{g} \\nHashrate: #VAL{N0} H/s";
            series3.XValueMember = "TimeStamp";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueMembers = "HashRate";
            series4.BorderWidth = 0;
            series4.ChartArea = "ChartAreaDifficultyHashcount";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.IsVisibleInLegend = false;
            series4.Legend = "LegendDifficultyHashcount";
            series4.Name = "AvailabilityDifficultySeries";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series5.ChartArea = "ChartAreaDifficultyHashcount";
            series5.Color = System.Drawing.Color.Navy;
            series5.CustomProperties = "EmptyPointValue=Zero, PointWidth=1";
            series5.Legend = "LegendDifficultyHashcount";
            series5.LegendText = "Hash count";
            series5.Name = "HashcountSeries";
            series5.ToolTip = "Time: #VALX{g} \\nHash count: #VAL{N0}\\n";
            series5.XValueMember = "TimeStamp";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.YValueMembers = "HashCount";
            series6.ChartArea = "ChartAreaDifficultyHashcount";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "LegendDifficultyHashcount";
            series6.LegendText = "Difficulty";
            series6.Name = "DifficultySeries";
            series6.ToolTip = "Time: #VALX{g} \\nDifficulty: #VAL{N3}";
            series6.XValueMember = "TimeStamp";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.YValueMembers = "Difficulty";
            this.chartHash.Series.Add(series1);
            this.chartHash.Series.Add(series2);
            this.chartHash.Series.Add(series3);
            this.chartHash.Series.Add(series4);
            this.chartHash.Series.Add(series5);
            this.chartHash.Series.Add(series6);
            this.chartHash.Size = new System.Drawing.Size(1150, 525);
            this.chartHash.TabIndex = 0;
            this.chartHash.Text = "chartHash";
            this.chartHash.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.chartHash_AxisViewChanged);
            this.chartHash.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartHash.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            // 
            // HashChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartHash);
            this.Name = "HashChart";
            this.Size = new System.Drawing.Size(1150, 525);
            ((System.ComponentModel.ISupportInitialize)(this.chartHash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHash;


    }
}
