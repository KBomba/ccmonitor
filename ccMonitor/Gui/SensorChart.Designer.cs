namespace ccMonitor.Gui
{
    partial class SensorChart
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
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSensor
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
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.Title = "Temperature (°C)";
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.Title = "Fan (%)";
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartAreaTemperatureFan";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 39.55485F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 8.945152F;
            chartArea2.AlignWithChartArea = "ChartAreaTemperatureFan";
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
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Format = "N0";
            chartArea2.AxisY.Title = "Pings (ms)";
            chartArea2.AxisY2.IsStartedFromZero = false;
            chartArea2.AxisY2.LabelStyle.Format = "0.###";
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.Title = "Frequencies (Hz)";
            chartArea2.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartAreaCoreclockMemoryclock";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 39.55485F;
            chartArea2.Position.Width = 100F;
            chartArea2.Position.Y = 57.44515F;
            this.chartSensor.ChartAreas.Add(chartArea1);
            this.chartSensor.ChartAreas.Add(chartArea2);
            this.chartSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.DockedToChartArea = "ChartAreaTemperatureFan";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "LegendTemperatureFan";
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend2.DockedToChartArea = "ChartAreaCoreclockMemoryclock";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.IsDockedInsideChartArea = false;
            legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend2.Name = "LegendCoreclockMemoryclock";
            this.chartSensor.Legends.Add(legend1);
            this.chartSensor.Legends.Add(legend2);
            this.chartSensor.Location = new System.Drawing.Point(0, 0);
            this.chartSensor.Margin = new System.Windows.Forms.Padding(0);
            this.chartSensor.Name = "chartSensor";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartAreaTemperatureFan";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.SystemColors.MenuHighlight;
            series1.CustomProperties = "EmptyPointValue=Zero, PointWidth=0.5";
            series1.Legend = "LegendTemperatureFan";
            series1.LegendText = "Fan";
            series1.Name = "FanSeries";
            series1.XValueMember = "TimeStamp";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueMembers = "Fan";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartAreaTemperatureFan";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Red;
            series2.CustomProperties = "IsXAxisQuantitative=False, LineTension=0.1";
            series2.Legend = "LegendTemperatureFan";
            series2.LegendText = "Temperature";
            series2.Name = "TemperatureSeries";
            series2.XValueMember = "TimeStamp";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "Temperature";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartAreaCoreclockMemoryclock";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.CustomProperties = "DrawSideBySide=True";
            series3.Legend = "LegendCoreclockMemoryclock";
            series3.LegendText = "Core frequency";
            series3.Name = "CoreclockSeries";
            series3.XValueMember = "TimeStamp";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValueMembers = "CoreClockFrequency";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartAreaCoreclockMemoryclock";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.SaddleBrown;
            series4.CustomProperties = "DrawSideBySide=True";
            series4.Legend = "LegendCoreclockMemoryclock";
            series4.LegendText = "Memory frequency";
            series4.Name = "MemoryclockSeries";
            series4.XValueMember = "TimeStamp";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.YValueMembers = "MemoryClockFrequency";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartAreaCoreclockMemoryclock";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.Fuchsia;
            series5.Legend = "LegendCoreclockMemoryclock";
            series5.LegendText = "Ping: This to miner";
            series5.Name = "NetworkpingSeries";
            series5.XValueMember = "TimeStamp";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.YValueMembers = "NetworkRigPing";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartAreaCoreclockMemoryclock";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series6.Legend = "LegendCoreclockMemoryclock";
            series6.LegendText = "Ping: This to URL";
            series6.Name = "MiningpingSeries";
            series6.XValueMember = "TimeStamp";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.YValueMembers = "MiningUrlPing";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartAreaCoreclockMemoryclock";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.Indigo;
            series7.Legend = "LegendCoreclockMemoryclock";
            series7.LegendText = "Ping: Miner to URL";
            series7.Name = "SharepingSeries";
            series7.XValueMember = "TimeStamp";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series7.YValueMembers = "ShareAnswerPing";
            this.chartSensor.Series.Add(series1);
            this.chartSensor.Series.Add(series2);
            this.chartSensor.Series.Add(series3);
            this.chartSensor.Series.Add(series4);
            this.chartSensor.Series.Add(series5);
            this.chartSensor.Series.Add(series6);
            this.chartSensor.Series.Add(series7);
            this.chartSensor.Size = new System.Drawing.Size(1150, 525);
            this.chartSensor.TabIndex = 0;
            this.chartSensor.Text = "chartSensor";
            this.chartSensor.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartSensor.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            // 
            // SensorChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartSensor);
            this.Name = "SensorChart";
            this.Size = new System.Drawing.Size(1150, 525);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensor;

    }
}
