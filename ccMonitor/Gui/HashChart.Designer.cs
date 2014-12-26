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
            this.chartHashrateFound = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHashrateFound)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHashrateFound
            // 
            chartArea1.AlignWithChartArea = "ChartAreaDifficultyHashcount";
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Format = "g";
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.Maximum = 5D;
            chartArea1.Name = "ChartAreaFoundHashrate";
            chartArea2.AlignWithChartArea = "ChartAreaFoundHashrate";
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelStyle.Format = "g";
            chartArea2.AxisY.IsLogarithmic = true;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Format = "N0";
            chartArea2.AxisY2.IsStartedFromZero = false;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartAreaDifficultyHashcount";
            this.chartHashrateFound.ChartAreas.Add(chartArea1);
            this.chartHashrateFound.ChartAreas.Add(chartArea2);
            this.chartHashrateFound.Dock = System.Windows.Forms.DockStyle.Fill;
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
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "LegendDifficultyHashrate";
            this.chartHashrateFound.Legends.Add(legend1);
            this.chartHashrateFound.Legends.Add(legend2);
            this.chartHashrateFound.Location = new System.Drawing.Point(0, 0);
            this.chartHashrateFound.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.chartHashrateFound.Name = "chartHashrateFound";
            series1.BorderColor = System.Drawing.Color.DarkOrange;
            series1.ChartArea = "ChartAreaFoundHashrate";
            series1.Color = System.Drawing.Color.Goldenrod;
            series1.CustomProperties = "EmptyPointValue=Zero, PointWidth=0.5";
            series1.Legend = "LegendFoundHashrate";
            series1.LegendText = "Found";
            series1.Name = "FoundSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartAreaFoundHashrate";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.CustomProperties = "IsXAxisQuantitative=False, LineTension=0.1";
            series2.Legend = "LegendFoundHashrate";
            series2.LegendText = "Hashrate";
            series2.Name = "HashrateSeries";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.ChartArea = "ChartAreaDifficultyHashcount";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "LegendDifficultyHashrate";
            series3.LegendText = "Difficulty";
            series3.Name = "DifficultySeries";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.ChartArea = "ChartAreaDifficultyHashcount";
            series4.Color = System.Drawing.Color.Navy;
            series4.Legend = "LegendDifficultyHashrate";
            series4.LegendText = "Hash count";
            series4.Name = "HashcountSeries";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartHashrateFound.Series.Add(series1);
            this.chartHashrateFound.Series.Add(series2);
            this.chartHashrateFound.Series.Add(series3);
            this.chartHashrateFound.Series.Add(series4);
            this.chartHashrateFound.Size = new System.Drawing.Size(1150, 525);
            this.chartHashrateFound.TabIndex = 0;
            this.chartHashrateFound.Text = "chartHashrateFound";
            this.chartHashrateFound.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            this.chartHashrateFound.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            // 
            // HashChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartHashrateFound);
            this.Name = "HashChart";
            this.Size = new System.Drawing.Size(1150, 525);
            ((System.ComponentModel.ISupportInitialize)(this.chartHashrateFound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHashrateFound;

    }
}
