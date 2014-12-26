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
            this.tbcGpu = new System.Windows.Forms.TabControl();
            this.tabGpuDetails = new System.Windows.Forms.TabPage();
            this.tabGpuBenchmarks = new System.Windows.Forms.TabPage();
            this.dgvBenchmarks = new System.Windows.Forms.DataGridView();
            this.clmTimeStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeLastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAlgorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverageHashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStandardDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHashCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverageTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinerNameVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStratum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabGpuCharts = new System.Windows.Forms.TabPage();
            this.tbcGpu.SuspendLayout();
            this.tabGpuBenchmarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenchmarks)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcGpu
            // 
            this.tbcGpu.Controls.Add(this.tabGpuDetails);
            this.tbcGpu.Controls.Add(this.tabGpuBenchmarks);
            this.tbcGpu.Controls.Add(this.tabGpuCharts);
            this.tbcGpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcGpu.Location = new System.Drawing.Point(0, 0);
            this.tbcGpu.Name = "tbcGpu";
            this.tbcGpu.SelectedIndex = 0;
            this.tbcGpu.Size = new System.Drawing.Size(1162, 554);
            this.tbcGpu.TabIndex = 0;
            // 
            // tabGpuDetails
            // 
            this.tabGpuDetails.Location = new System.Drawing.Point(4, 22);
            this.tabGpuDetails.Name = "tabGpuDetails";
            this.tabGpuDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabGpuDetails.Size = new System.Drawing.Size(1154, 528);
            this.tabGpuDetails.TabIndex = 0;
            this.tabGpuDetails.Text = "GPU details";
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
            this.clmHashCount,
            this.clmAverageTemperature,
            this.clmMinerNameVersion,
            this.clmStratum});
            this.dgvBenchmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenchmarks.Location = new System.Drawing.Point(3, 3);
            this.dgvBenchmarks.MultiSelect = false;
            this.dgvBenchmarks.Name = "dgvBenchmarks";
            this.dgvBenchmarks.ReadOnly = true;
            this.dgvBenchmarks.RowHeadersVisible = false;
            this.dgvBenchmarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenchmarks.Size = new System.Drawing.Size(1148, 522);
            this.dgvBenchmarks.TabIndex = 0;
            this.dgvBenchmarks.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBenchmarks_CellMouseDoubleClick);
            // 
            // clmTimeStarted
            // 
            this.clmTimeStarted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTimeStarted.DataPropertyName = "TimeStarted";
            this.clmTimeStarted.FillWeight = 80F;
            this.clmTimeStarted.HeaderText = "Started";
            this.clmTimeStarted.Name = "clmTimeStarted";
            this.clmTimeStarted.ReadOnly = true;
            // 
            // clmTimeLastUpdate
            // 
            this.clmTimeLastUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTimeLastUpdate.DataPropertyName = "TimeLastUpdate";
            this.clmTimeLastUpdate.FillWeight = 80F;
            this.clmTimeLastUpdate.HeaderText = "Last Updated";
            this.clmTimeLastUpdate.Name = "clmTimeLastUpdate";
            this.clmTimeLastUpdate.ReadOnly = true;
            // 
            // clmAlgorithm
            // 
            this.clmAlgorithm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAlgorithm.DataPropertyName = "Algorithm";
            this.clmAlgorithm.FillWeight = 70F;
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
            this.clmMinerNameVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMinerNameVersion.DataPropertyName = "MinerNameVersion";
            this.clmMinerNameVersion.HeaderText = "Miner";
            this.clmMinerNameVersion.Name = "clmMinerNameVersion";
            this.clmMinerNameVersion.ReadOnly = true;
            // 
            // clmStratum
            // 
            this.clmStratum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmStratum.DataPropertyName = "Stratum";
            this.clmStratum.FillWeight = 120F;
            this.clmStratum.HeaderText = "Stratum";
            this.clmStratum.Name = "clmStratum";
            this.clmStratum.ReadOnly = true;
            // 
            // tabGpuCharts
            // 
            this.tabGpuCharts.Location = new System.Drawing.Point(4, 22);
            this.tabGpuCharts.Name = "tabGpuCharts";
            this.tabGpuCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabGpuCharts.Size = new System.Drawing.Size(1154, 528);
            this.tabGpuCharts.TabIndex = 2;
            this.tabGpuCharts.Text = "Hash charts";
            // 
            // GpuTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcGpu);
            this.Name = "GpuTab";
            this.Size = new System.Drawing.Size(1162, 554);
            this.tbcGpu.ResumeLayout(false);
            this.tabGpuBenchmarks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenchmarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGpu;
        private System.Windows.Forms.TabPage tabGpuDetails;
        private System.Windows.Forms.TabPage tabGpuBenchmarks;
        private System.Windows.Forms.DataGridView dgvBenchmarks;
        private System.Windows.Forms.TabPage tabGpuCharts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeLastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAlgorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverageHashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStandardDeviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHashCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverageTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMinerNameVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStratum;

    }
}
