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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcGpu = new System.Windows.Forms.TabControl();
            this.tabGpuOverview = new System.Windows.Forms.TabPage();
            this.grpHashrateSpread = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chartSpread = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabGpuBenchmarks = new System.Windows.Forms.TabPage();
            this.dgvBenchmarks = new System.Windows.Forms.DataGridView();
            this.tabGpuCharts = new System.Windows.Forms.TabPage();
            this.splitCharts = new System.Windows.Forms.SplitContainer();
            this.chartHistoric = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clmTimeStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeLastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAlgorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverageHashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStandardDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLowestHashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHighestHashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHashCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverageTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinerNameVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbcGpu.SuspendLayout();
            this.tabGpuOverview.SuspendLayout();
            this.grpHashrateSpread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).BeginInit();
            this.tabGpuBenchmarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenchmarks)).BeginInit();
            this.tabGpuCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).BeginInit();
            this.splitCharts.Panel2.SuspendLayout();
            this.splitCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistoric)).BeginInit();
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
            // chartSpread
            // 
            this.chartSpread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea15.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea15.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea15.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea15.AxisX.LabelStyle.Enabled = false;
            chartArea15.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea15.AxisX.MajorGrid.LineWidth = 0;
            chartArea15.AxisY.IsStartedFromZero = false;
            chartArea15.AxisY.LabelStyle.Format = "0.00000000";
            chartArea15.AxisY.MajorGrid.LineWidth = 0;
            chartArea15.Name = "ChartArea";
            this.chartSpread.ChartAreas.Add(chartArea15);
            this.chartSpread.Location = new System.Drawing.Point(245, 19);
            this.chartSpread.Name = "chartSpread";
            series15.BorderColor = System.Drawing.Color.Gold;
            series15.ChartArea = "ChartArea";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series15.Color = System.Drawing.Color.Gold;
            series15.Name = "BoxPlotSeries";
            series15.YValuesPerPoint = 6;
            this.chartSpread.Series.Add(series15);
            this.chartSpread.Size = new System.Drawing.Size(300, 234);
            this.chartSpread.TabIndex = 53;
            this.chartSpread.Text = "chart2";
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
            this.dgvBenchmarks.AllowUserToOrderColumns = true;
            this.dgvBenchmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenchmarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTimeStarted,
            this.clmTimeLastUpdate,
            this.clmAlgorithm,
            this.clmAverageHashRate,
            this.clmStandardDeviation,
            this.clmLowestHashRate,
            this.clmHighestHashRate,
            this.clmHashCount,
            this.clmAverageTemperature,
            this.clmMinerNameVersion,
            this.clmDetails});
            this.dgvBenchmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenchmarks.Location = new System.Drawing.Point(3, 3);
            this.dgvBenchmarks.MultiSelect = false;
            this.dgvBenchmarks.Name = "dgvBenchmarks";
            this.dgvBenchmarks.ReadOnly = true;
            this.dgvBenchmarks.RowHeadersVisible = false;
            this.dgvBenchmarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            chartArea16.Name = "ChartArea1";
            this.chartHistoric.ChartAreas.Add(chartArea16);
            this.chartHistoric.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.chartHistoric.Legends.Add(legend8);
            this.chartHistoric.Location = new System.Drawing.Point(0, 0);
            this.chartHistoric.Name = "chartHistoric";
            this.chartHistoric.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chartHistoric.Series.Add(series16);
            this.chartHistoric.Size = new System.Drawing.Size(1148, 425);
            this.chartHistoric.TabIndex = 0;
            this.chartHistoric.Text = "Historic charts";
            // 
            // clmTimeStarted
            // 
            this.clmTimeStarted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTimeStarted.DataPropertyName = "TimeStarted";
            this.clmTimeStarted.HeaderText = "Started";
            this.clmTimeStarted.Name = "clmTimeStarted";
            this.clmTimeStarted.ReadOnly = true;
            // 
            // clmTimeLastUpdate
            // 
            this.clmTimeLastUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTimeLastUpdate.DataPropertyName = "TimeLastUpdate";
            this.clmTimeLastUpdate.HeaderText = "Last Updated";
            this.clmTimeLastUpdate.Name = "clmTimeLastUpdate";
            this.clmTimeLastUpdate.ReadOnly = true;
            // 
            // clmAlgorithm
            // 
            this.clmAlgorithm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAlgorithm.DataPropertyName = "Algorithm";
            this.clmAlgorithm.HeaderText = "Algorithm";
            this.clmAlgorithm.Name = "clmAlgorithm";
            this.clmAlgorithm.ReadOnly = true;
            // 
            // clmAverageHashRate
            // 
            this.clmAverageHashRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmAverageHashRate.DataPropertyName = "AverageHashRate";
            this.clmAverageHashRate.HeaderText = "Average Hashrate";
            this.clmAverageHashRate.Name = "clmAverageHashRate";
            this.clmAverageHashRate.ReadOnly = true;
            this.clmAverageHashRate.Width = 108;
            // 
            // clmStandardDeviation
            // 
            this.clmStandardDeviation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmStandardDeviation.DataPropertyName = "StandardDeviation";
            this.clmStandardDeviation.HeaderText = "Standard Deviation";
            this.clmStandardDeviation.Name = "clmStandardDeviation";
            this.clmStandardDeviation.ReadOnly = true;
            this.clmStandardDeviation.Width = 113;
            // 
            // clmLowestHashRate
            // 
            this.clmLowestHashRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmLowestHashRate.DataPropertyName = "LowestHashRate";
            this.clmLowestHashRate.HeaderText = "Lowest Hashrate";
            this.clmLowestHashRate.Name = "clmLowestHashRate";
            this.clmLowestHashRate.ReadOnly = true;
            this.clmLowestHashRate.Width = 103;
            // 
            // clmHighestHashRate
            // 
            this.clmHighestHashRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmHighestHashRate.DataPropertyName = "HighestHashRate";
            this.clmHighestHashRate.HeaderText = "Highest Hashrate";
            this.clmHighestHashRate.Name = "clmHighestHashRate";
            this.clmHighestHashRate.ReadOnly = true;
            this.clmHighestHashRate.Width = 105;
            // 
            // clmHashCount
            // 
            this.clmHashCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmHashCount.DataPropertyName = "HashCount";
            this.clmHashCount.HeaderText = "Hash Count";
            this.clmHashCount.Name = "clmHashCount";
            this.clmHashCount.ReadOnly = true;
            this.clmHashCount.Width = 81;
            // 
            // clmAverageTemperature
            // 
            this.clmAverageTemperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmAverageTemperature.DataPropertyName = "AverageTemperature";
            this.clmAverageTemperature.HeaderText = "Average Temperature";
            this.clmAverageTemperature.Name = "clmAverageTemperature";
            this.clmAverageTemperature.ReadOnly = true;
            this.clmAverageTemperature.Width = 123;
            // 
            // clmMinerNameVersion
            // 
            this.clmMinerNameVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmMinerNameVersion.DataPropertyName = "MinerNameVersion";
            this.clmMinerNameVersion.HeaderText = "Miner";
            this.clmMinerNameVersion.Name = "clmMinerNameVersion";
            this.clmMinerNameVersion.ReadOnly = true;
            this.clmMinerNameVersion.Width = 58;
            // 
            // clmDetails
            // 
            this.clmDetails.HeaderText = "Details";
            this.clmDetails.Name = "clmDetails";
            this.clmDetails.ReadOnly = true;
            this.clmDetails.Text = "Details";
            this.clmDetails.UseColumnTextForButtonValue = true;
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
            this.grpHashrateSpread.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).EndInit();
            this.tabGpuBenchmarks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenchmarks)).EndInit();
            this.tabGpuCharts.ResumeLayout(false);
            this.splitCharts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).EndInit();
            this.splitCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistoric)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeLastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAlgorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverageHashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStandardDeviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLowestHashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHighestHashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHashCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverageTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMinerNameVersion;
        private System.Windows.Forms.DataGridViewButtonColumn clmDetails;

    }
}
