namespace ccMonitor.Gui
{
    partial class GpuTab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcGpu = new System.Windows.Forms.TabControl();
            this.tabGpuOverview = new System.Windows.Forms.TabPage();
            this.tabGpuBenchmarks = new System.Windows.Forms.TabPage();
            this.dgvBenchmarks = new System.Windows.Forms.DataGridView();
            this.tabGpuCharts = new System.Windows.Forms.TabPage();
            this.chartSpread = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitCharts = new System.Windows.Forms.SplitContainer();
            this.chartHistoric = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpHashrateSpread = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbcGpu.SuspendLayout();
            this.tabGpuOverview.SuspendLayout();
            this.tabGpuBenchmarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenchmarks)).BeginInit();
            this.tabGpuCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).BeginInit();
            this.splitCharts.Panel2.SuspendLayout();
            this.splitCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistoric)).BeginInit();
            this.grpHashrateSpread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcGpu
            // 
            this.tbcGpu.Controls.Add(this.tabGpuOverview);
            this.tbcGpu.Controls.Add(this.tabGpuBenchmarks);
            this.tbcGpu.Controls.Add(this.tabGpuCharts);
            this.tbcGpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcGpu.Location = new System.Drawing.Point(0, 0);
            this.tbcGpu.Name = "tbcGpu";
            this.tbcGpu.SelectedIndex = 0;
            this.tbcGpu.Size = new System.Drawing.Size(1162, 554);
            this.tbcGpu.TabIndex = 0;
            // 
            // tabGpuOverview
            // 
            this.tabGpuOverview.Controls.Add(this.grpHashrateSpread);
            this.tabGpuOverview.Location = new System.Drawing.Point(4, 22);
            this.tabGpuOverview.Name = "tabGpuOverview";
            this.tabGpuOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabGpuOverview.Size = new System.Drawing.Size(1154, 528);
            this.tabGpuOverview.TabIndex = 0;
            this.tabGpuOverview.Text = "GPU overview";
            // 
            // tabGpuBenchmarks
            // 
            this.tabGpuBenchmarks.Controls.Add(this.dgvBenchmarks);
            this.tabGpuBenchmarks.Location = new System.Drawing.Point(4, 22);
            this.tabGpuBenchmarks.Name = "tabGpuBenchmarks";
            this.tabGpuBenchmarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabGpuBenchmarks.Size = new System.Drawing.Size(1154, 528);
            this.tabGpuBenchmarks.TabIndex = 1;
            this.tabGpuBenchmarks.Text = "Benchmarks";
            // 
            // dgvBenchmarks
            // 
            this.dgvBenchmarks.AllowUserToAddRows = false;
            this.dgvBenchmarks.AllowUserToDeleteRows = false;
            this.dgvBenchmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenchmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenchmarks.Location = new System.Drawing.Point(3, 3);
            this.dgvBenchmarks.Name = "dgvBenchmarks";
            this.dgvBenchmarks.ReadOnly = true;
            this.dgvBenchmarks.Size = new System.Drawing.Size(1148, 522);
            this.dgvBenchmarks.TabIndex = 0;
            // 
            // tabGpuCharts
            // 
            this.tabGpuCharts.Controls.Add(this.splitCharts);
            this.tabGpuCharts.Location = new System.Drawing.Point(4, 22);
            this.tabGpuCharts.Name = "tabGpuCharts";
            this.tabGpuCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabGpuCharts.Size = new System.Drawing.Size(1154, 528);
            this.tabGpuCharts.TabIndex = 2;
            this.tabGpuCharts.Text = "Historic charts";
            // 
            // chartSpread
            // 
            this.chartSpread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.chartSpread.Location = new System.Drawing.Point(245, 19);
            this.chartSpread.Name = "chartSpread";
            series1.BorderColor = System.Drawing.Color.Gold;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series1.Color = System.Drawing.Color.Gold;
            series1.Name = "BoxPlotSeries";
            series1.YValuesPerPoint = 6;
            this.chartSpread.Series.Add(series1);
            this.chartSpread.Size = new System.Drawing.Size(300, 234);
            this.chartSpread.TabIndex = 53;
            this.chartSpread.Text = "chart2";
            // 
            // splitCharts
            // 
            this.splitCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCharts.Location = new System.Drawing.Point(3, 3);
            this.splitCharts.Name = "splitCharts";
            this.splitCharts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCharts.Panel2
            // 
            this.splitCharts.Panel2.Controls.Add(this.chartHistoric);
            this.splitCharts.Size = new System.Drawing.Size(1148, 522);
            this.splitCharts.SplitterDistance = 93;
            this.splitCharts.TabIndex = 0;
            // 
            // chartHistoric
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHistoric.ChartAreas.Add(chartArea2);
            this.chartHistoric.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartHistoric.Legends.Add(legend1);
            this.chartHistoric.Location = new System.Drawing.Point(0, 0);
            this.chartHistoric.Name = "chartHistoric";
            this.chartHistoric.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHistoric.Series.Add(series2);
            this.chartHistoric.Size = new System.Drawing.Size(1148, 425);
            this.chartHistoric.TabIndex = 0;
            this.chartHistoric.Text = "Historic charts";
            // 
            // grpHashrateSpread
            // 
            this.grpHashrateSpread.Controls.Add(this.numericUpDown1);
            this.grpHashrateSpread.Controls.Add(this.chartSpread);
            this.grpHashrateSpread.Location = new System.Drawing.Point(442, 97);
            this.grpHashrateSpread.Name = "grpHashrateSpread";
            this.grpHashrateSpread.Size = new System.Drawing.Size(551, 262);
            this.grpHashrateSpread.TabIndex = 54;
            this.grpHashrateSpread.TabStop = false;
            this.grpHashrateSpread.Text = "Hashrate spread";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(88, 183);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 54;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // GpuTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcGpu);
            this.Name = "GpuTab";
            this.Size = new System.Drawing.Size(1162, 554);
            this.tbcGpu.ResumeLayout(false);
            this.tabGpuOverview.ResumeLayout(false);
            this.tabGpuBenchmarks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenchmarks)).EndInit();
            this.tabGpuCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).EndInit();
            this.splitCharts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).EndInit();
            this.splitCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistoric)).EndInit();
            this.grpHashrateSpread.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGpu;
        private System.Windows.Forms.TabPage tabGpuOverview;
        private System.Windows.Forms.TabPage tabGpuBenchmarks;
        private System.Windows.Forms.DataGridView dgvBenchmarks;
        private System.Windows.Forms.TabPage tabGpuCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpread;
        private System.Windows.Forms.SplitContainer splitCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistoric;
        private System.Windows.Forms.GroupBox grpHashrateSpread;
        private System.Windows.Forms.NumericUpDown numericUpDown1;

    }
}
