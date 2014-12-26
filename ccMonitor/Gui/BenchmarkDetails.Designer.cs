namespace ccMonitor.Gui
{
    partial class BenchmarkDetails
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitGpuDetails = new System.Windows.Forms.SplitContainer();
            this.splitStatsAndSpread = new System.Windows.Forms.SplitContainer();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblAveragePing = new System.Windows.Forms.Label();
            this.txtAveragePing = new System.Windows.Forms.TextBox();
            this.txtAccepts = new System.Windows.Forms.TextBox();
            this.lblAverageTemperature = new System.Windows.Forms.Label();
            this.txtAverageTemperature = new System.Windows.Forms.TextBox();
            this.lblHashCount = new System.Windows.Forms.Label();
            this.txtHashCount = new System.Windows.Forms.TextBox();
            this.lblAccepts = new System.Windows.Forms.Label();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.txtIntensity = new System.Windows.Forms.TextBox();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.txtAlgorithm = new System.Windows.Forms.TextBox();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.txtOperatingSystem = new System.Windows.Forms.TextBox();
            this.lblDriverVersion = new System.Windows.Forms.Label();
            this.txtDriverVersion = new System.Windows.Forms.TextBox();
            this.lblBiosVersion = new System.Windows.Forms.Label();
            this.lblPerformanceState = new System.Windows.Forms.Label();
            this.txtBiosVersion = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtPerformanceState = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblMinerName = new System.Windows.Forms.Label();
            this.txtMinerName = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblBusId = new System.Windows.Forms.Label();
            this.txtBusId = new System.Windows.Forms.TextBox();
            this.lblMinerId = new System.Windows.Forms.Label();
            this.txtMinerId = new System.Windows.Forms.TextBox();
            this.lblGpuName = new System.Windows.Forms.Label();
            this.txtGpuName = new System.Windows.Forms.TextBox();
            this.grpHashrateSpread = new System.Windows.Forms.GroupBox();
            this.splitSpread = new System.Windows.Forms.SplitContainer();
            this.dgvSpread = new System.Windows.Forms.DataGridView();
            this.chartSpread = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitHashesAndSensors = new System.Windows.Forms.SplitContainer();
            this.lblNvmlId = new System.Windows.Forms.Label();
            this.txtNvmlId = new System.Windows.Forms.TextBox();
            this.lblNvapiId = new System.Windows.Forms.Label();
            this.txtNvapiId = new System.Windows.Forms.TextBox();
            this.lblComputeCapability = new System.Windows.Forms.Label();
            this.txtComputeCapability = new System.Windows.Forms.TextBox();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitGpuDetails)).BeginInit();
            this.splitGpuDetails.Panel1.SuspendLayout();
            this.splitGpuDetails.Panel2.SuspendLayout();
            this.splitGpuDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStatsAndSpread)).BeginInit();
            this.splitStatsAndSpread.Panel1.SuspendLayout();
            this.splitStatsAndSpread.Panel2.SuspendLayout();
            this.splitStatsAndSpread.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpSetup.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpHashrateSpread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSpread)).BeginInit();
            this.splitSpread.Panel1.SuspendLayout();
            this.splitSpread.Panel2.SuspendLayout();
            this.splitSpread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitHashesAndSensors)).BeginInit();
            this.splitHashesAndSensors.SuspendLayout();
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
            this.splitGpuDetails.Size = new System.Drawing.Size(1168, 560);
            this.splitGpuDetails.SplitterDistance = 331;
            this.splitGpuDetails.TabIndex = 0;
            // 
            // splitStatsAndSpread
            // 
            this.splitStatsAndSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStatsAndSpread.Location = new System.Drawing.Point(0, 0);
            this.splitStatsAndSpread.Name = "splitStatsAndSpread";
            // 
            // splitStatsAndSpread.Panel1
            // 
            this.splitStatsAndSpread.Panel1.Controls.Add(this.grpStats);
            this.splitStatsAndSpread.Panel1.Controls.Add(this.grpSetup);
            this.splitStatsAndSpread.Panel1.Controls.Add(this.grpInfo);
            // 
            // splitStatsAndSpread.Panel2
            // 
            this.splitStatsAndSpread.Panel2.Controls.Add(this.grpHashrateSpread);
            this.splitStatsAndSpread.Size = new System.Drawing.Size(1168, 331);
            this.splitStatsAndSpread.SplitterDistance = 702;
            this.splitStatsAndSpread.TabIndex = 0;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblAveragePing);
            this.grpStats.Controls.Add(this.txtAveragePing);
            this.grpStats.Controls.Add(this.txtAccepts);
            this.grpStats.Controls.Add(this.lblAverageTemperature);
            this.grpStats.Controls.Add(this.txtAverageTemperature);
            this.grpStats.Controls.Add(this.lblHashCount);
            this.grpStats.Controls.Add(this.txtHashCount);
            this.grpStats.Controls.Add(this.lblAccepts);
            this.grpStats.Location = new System.Drawing.Point(3, 157);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(331, 76);
            this.grpStats.TabIndex = 13;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats";
            // 
            // lblAveragePing
            // 
            this.lblAveragePing.AutoSize = true;
            this.lblAveragePing.Location = new System.Drawing.Point(162, 48);
            this.lblAveragePing.Name = "lblAveragePing";
            this.lblAveragePing.Size = new System.Drawing.Size(70, 13);
            this.lblAveragePing.TabIndex = 11;
            this.lblAveragePing.Text = "Average ping";
            // 
            // txtAveragePing
            // 
            this.txtAveragePing.BackColor = System.Drawing.SystemColors.Window;
            this.txtAveragePing.Location = new System.Drawing.Point(241, 45);
            this.txtAveragePing.Name = "txtAveragePing";
            this.txtAveragePing.ReadOnly = true;
            this.txtAveragePing.Size = new System.Drawing.Size(56, 20);
            this.txtAveragePing.TabIndex = 10;
            // 
            // txtAccepts
            // 
            this.txtAccepts.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccepts.Location = new System.Drawing.Point(85, 19);
            this.txtAccepts.Name = "txtAccepts";
            this.txtAccepts.ReadOnly = true;
            this.txtAccepts.Size = new System.Drawing.Size(56, 20);
            this.txtAccepts.TabIndex = 8;
            // 
            // lblAverageTemperature
            // 
            this.lblAverageTemperature.AutoSize = true;
            this.lblAverageTemperature.Location = new System.Drawing.Point(162, 22);
            this.lblAverageTemperature.Name = "lblAverageTemperature";
            this.lblAverageTemperature.Size = new System.Drawing.Size(73, 13);
            this.lblAverageTemperature.TabIndex = 9;
            this.lblAverageTemperature.Text = "Average temp";
            // 
            // txtAverageTemperature
            // 
            this.txtAverageTemperature.BackColor = System.Drawing.SystemColors.Window;
            this.txtAverageTemperature.Location = new System.Drawing.Point(241, 19);
            this.txtAverageTemperature.Name = "txtAverageTemperature";
            this.txtAverageTemperature.ReadOnly = true;
            this.txtAverageTemperature.Size = new System.Drawing.Size(56, 20);
            this.txtAverageTemperature.TabIndex = 8;
            // 
            // lblHashCount
            // 
            this.lblHashCount.AutoSize = true;
            this.lblHashCount.Location = new System.Drawing.Point(6, 48);
            this.lblHashCount.Name = "lblHashCount";
            this.lblHashCount.Size = new System.Drawing.Size(59, 13);
            this.lblHashCount.TabIndex = 7;
            this.lblHashCount.Text = "Hashcount";
            // 
            // txtHashCount
            // 
            this.txtHashCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtHashCount.Location = new System.Drawing.Point(85, 45);
            this.txtHashCount.Name = "txtHashCount";
            this.txtHashCount.ReadOnly = true;
            this.txtHashCount.Size = new System.Drawing.Size(56, 20);
            this.txtHashCount.TabIndex = 6;
            // 
            // lblAccepts
            // 
            this.lblAccepts.AutoSize = true;
            this.lblAccepts.Location = new System.Drawing.Point(6, 22);
            this.lblAccepts.Name = "lblAccepts";
            this.lblAccepts.Size = new System.Drawing.Size(46, 13);
            this.lblAccepts.TabIndex = 5;
            this.lblAccepts.Text = "Accepts";
            // 
            // grpSetup
            // 
            this.grpSetup.Controls.Add(this.lblIntensity);
            this.grpSetup.Controls.Add(this.txtIntensity);
            this.grpSetup.Controls.Add(this.lblAlgorithm);
            this.grpSetup.Controls.Add(this.txtAlgorithm);
            this.grpSetup.Controls.Add(this.lblOperatingSystem);
            this.grpSetup.Controls.Add(this.txtOperatingSystem);
            this.grpSetup.Controls.Add(this.lblDriverVersion);
            this.grpSetup.Controls.Add(this.txtDriverVersion);
            this.grpSetup.Controls.Add(this.lblBiosVersion);
            this.grpSetup.Controls.Add(this.lblPerformanceState);
            this.grpSetup.Controls.Add(this.txtBiosVersion);
            this.grpSetup.Controls.Add(this.lblUrl);
            this.grpSetup.Controls.Add(this.txtPerformanceState);
            this.grpSetup.Controls.Add(this.txtUrl);
            this.grpSetup.Controls.Add(this.lblMinerName);
            this.grpSetup.Controls.Add(this.txtMinerName);
            this.grpSetup.Location = new System.Drawing.Point(358, 3);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Size = new System.Drawing.Size(331, 230);
            this.grpSetup.TabIndex = 12;
            this.grpSetup.TabStop = false;
            this.grpSetup.Text = "Setup";
            // 
            // lblIntensity
            // 
            this.lblIntensity.AutoSize = true;
            this.lblIntensity.Location = new System.Drawing.Point(6, 102);
            this.lblIntensity.Name = "lblIntensity";
            this.lblIntensity.Size = new System.Drawing.Size(82, 13);
            this.lblIntensity.TabIndex = 21;
            this.lblIntensity.Text = "Thread intensity";
            // 
            // txtIntensity
            // 
            this.txtIntensity.BackColor = System.Drawing.SystemColors.Window;
            this.txtIntensity.Location = new System.Drawing.Point(105, 99);
            this.txtIntensity.Name = "txtIntensity";
            this.txtIntensity.ReadOnly = true;
            this.txtIntensity.Size = new System.Drawing.Size(71, 20);
            this.txtIntensity.TabIndex = 20;
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Location = new System.Drawing.Point(6, 22);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(61, 13);
            this.lblAlgorithm.TabIndex = 19;
            this.lblAlgorithm.Text = "Mining algo";
            // 
            // txtAlgorithm
            // 
            this.txtAlgorithm.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlgorithm.Location = new System.Drawing.Point(76, 19);
            this.txtAlgorithm.Name = "txtAlgorithm";
            this.txtAlgorithm.ReadOnly = true;
            this.txtAlgorithm.Size = new System.Drawing.Size(100, 20);
            this.txtAlgorithm.TabIndex = 18;
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Location = new System.Drawing.Point(6, 206);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(22, 13);
            this.lblOperatingSystem.TabIndex = 17;
            this.lblOperatingSystem.Text = "OS";
            // 
            // txtOperatingSystem
            // 
            this.txtOperatingSystem.BackColor = System.Drawing.SystemColors.Window;
            this.txtOperatingSystem.Location = new System.Drawing.Point(76, 203);
            this.txtOperatingSystem.Name = "txtOperatingSystem";
            this.txtOperatingSystem.ReadOnly = true;
            this.txtOperatingSystem.Size = new System.Drawing.Size(100, 20);
            this.txtOperatingSystem.TabIndex = 16;
            // 
            // lblDriverVersion
            // 
            this.lblDriverVersion.AutoSize = true;
            this.lblDriverVersion.Location = new System.Drawing.Point(6, 180);
            this.lblDriverVersion.Name = "lblDriverVersion";
            this.lblDriverVersion.Size = new System.Drawing.Size(72, 13);
            this.lblDriverVersion.TabIndex = 15;
            this.lblDriverVersion.Text = "Driver version";
            // 
            // txtDriverVersion
            // 
            this.txtDriverVersion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDriverVersion.Location = new System.Drawing.Point(76, 177);
            this.txtDriverVersion.Name = "txtDriverVersion";
            this.txtDriverVersion.ReadOnly = true;
            this.txtDriverVersion.Size = new System.Drawing.Size(100, 20);
            this.txtDriverVersion.TabIndex = 14;
            // 
            // lblBiosVersion
            // 
            this.lblBiosVersion.AutoSize = true;
            this.lblBiosVersion.Location = new System.Drawing.Point(6, 154);
            this.lblBiosVersion.Name = "lblBiosVersion";
            this.lblBiosVersion.Size = new System.Drawing.Size(64, 13);
            this.lblBiosVersion.TabIndex = 11;
            this.lblBiosVersion.Text = "Bios version";
            // 
            // lblPerformanceState
            // 
            this.lblPerformanceState.AutoSize = true;
            this.lblPerformanceState.Location = new System.Drawing.Point(6, 128);
            this.lblPerformanceState.Name = "lblPerformanceState";
            this.lblPerformanceState.Size = new System.Drawing.Size(93, 13);
            this.lblPerformanceState.TabIndex = 13;
            this.lblPerformanceState.Text = "Performance state";
            // 
            // txtBiosVersion
            // 
            this.txtBiosVersion.BackColor = System.Drawing.SystemColors.Window;
            this.txtBiosVersion.Location = new System.Drawing.Point(76, 151);
            this.txtBiosVersion.Name = "txtBiosVersion";
            this.txtBiosVersion.ReadOnly = true;
            this.txtBiosVersion.Size = new System.Drawing.Size(100, 20);
            this.txtBiosVersion.TabIndex = 10;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(6, 76);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 11;
            this.lblUrl.Text = "URL";
            // 
            // txtPerformanceState
            // 
            this.txtPerformanceState.BackColor = System.Drawing.SystemColors.Window;
            this.txtPerformanceState.Location = new System.Drawing.Point(105, 125);
            this.txtPerformanceState.Name = "txtPerformanceState";
            this.txtPerformanceState.ReadOnly = true;
            this.txtPerformanceState.Size = new System.Drawing.Size(71, 20);
            this.txtPerformanceState.TabIndex = 12;
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.Location = new System.Drawing.Point(76, 73);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(249, 20);
            this.txtUrl.TabIndex = 10;
            // 
            // lblMinerName
            // 
            this.lblMinerName.AutoSize = true;
            this.lblMinerName.Location = new System.Drawing.Point(6, 48);
            this.lblMinerName.Name = "lblMinerName";
            this.lblMinerName.Size = new System.Drawing.Size(62, 13);
            this.lblMinerName.TabIndex = 1;
            this.lblMinerName.Text = "Miner name";
            // 
            // txtMinerName
            // 
            this.txtMinerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinerName.Location = new System.Drawing.Point(76, 45);
            this.txtMinerName.Name = "txtMinerName";
            this.txtMinerName.ReadOnly = true;
            this.txtMinerName.Size = new System.Drawing.Size(249, 20);
            this.txtMinerName.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblComputeCapability);
            this.grpInfo.Controls.Add(this.txtComputeCapability);
            this.grpInfo.Controls.Add(this.lblNvmlId);
            this.grpInfo.Controls.Add(this.txtNvmlId);
            this.grpInfo.Controls.Add(this.lblNvapiId);
            this.grpInfo.Controls.Add(this.txtNvapiId);
            this.grpInfo.Controls.Add(this.lblBusId);
            this.grpInfo.Controls.Add(this.txtBusId);
            this.grpInfo.Controls.Add(this.lblMinerId);
            this.grpInfo.Controls.Add(this.txtMinerId);
            this.grpInfo.Controls.Add(this.lblGpuName);
            this.grpInfo.Controls.Add(this.txtGpuName);
            this.grpInfo.Location = new System.Drawing.Point(3, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(331, 127);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // lblBusId
            // 
            this.lblBusId.AutoSize = true;
            this.lblBusId.Location = new System.Drawing.Point(6, 72);
            this.lblBusId.Name = "lblBusId";
            this.lblBusId.Size = new System.Drawing.Size(35, 13);
            this.lblBusId.TabIndex = 7;
            this.lblBusId.Text = "Bus #";
            // 
            // txtBusId
            // 
            this.txtBusId.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusId.Location = new System.Drawing.Point(76, 69);
            this.txtBusId.Name = "txtBusId";
            this.txtBusId.ReadOnly = true;
            this.txtBusId.Size = new System.Drawing.Size(36, 20);
            this.txtBusId.TabIndex = 6;
            // 
            // lblMinerId
            // 
            this.lblMinerId.AutoSize = true;
            this.lblMinerId.Location = new System.Drawing.Point(6, 48);
            this.lblMinerId.Name = "lblMinerId";
            this.lblMinerId.Size = new System.Drawing.Size(43, 13);
            this.lblMinerId.TabIndex = 5;
            this.lblMinerId.Text = "Miner #";
            // 
            // txtMinerId
            // 
            this.txtMinerId.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinerId.Location = new System.Drawing.Point(76, 45);
            this.txtMinerId.Name = "txtMinerId";
            this.txtMinerId.ReadOnly = true;
            this.txtMinerId.Size = new System.Drawing.Size(36, 20);
            this.txtMinerId.TabIndex = 4;
            // 
            // lblGpuName
            // 
            this.lblGpuName.AutoSize = true;
            this.lblGpuName.Location = new System.Drawing.Point(6, 22);
            this.lblGpuName.Name = "lblGpuName";
            this.lblGpuName.Size = new System.Drawing.Size(56, 13);
            this.lblGpuName.TabIndex = 1;
            this.lblGpuName.Text = "Gpu name";
            // 
            // txtGpuName
            // 
            this.txtGpuName.BackColor = System.Drawing.SystemColors.Window;
            this.txtGpuName.Location = new System.Drawing.Point(76, 19);
            this.txtGpuName.Name = "txtGpuName";
            this.txtGpuName.ReadOnly = true;
            this.txtGpuName.Size = new System.Drawing.Size(157, 20);
            this.txtGpuName.TabIndex = 0;
            // 
            // grpHashrateSpread
            // 
            this.grpHashrateSpread.Controls.Add(this.splitSpread);
            this.grpHashrateSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHashrateSpread.Location = new System.Drawing.Point(0, 0);
            this.grpHashrateSpread.Name = "grpHashrateSpread";
            this.grpHashrateSpread.Size = new System.Drawing.Size(462, 331);
            this.grpHashrateSpread.TabIndex = 56;
            this.grpHashrateSpread.TabStop = false;
            this.grpHashrateSpread.Text = "Hashrate spread";
            // 
            // splitSpread
            // 
            this.splitSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSpread.Location = new System.Drawing.Point(3, 16);
            this.splitSpread.Name = "splitSpread";
            // 
            // splitSpread.Panel1
            // 
            this.splitSpread.Panel1.Controls.Add(this.dgvSpread);
            // 
            // splitSpread.Panel2
            // 
            this.splitSpread.Panel2.Controls.Add(this.chartSpread);
            this.splitSpread.Size = new System.Drawing.Size(456, 312);
            this.splitSpread.SplitterDistance = 177;
            this.splitSpread.TabIndex = 0;
            // 
            // dgvSpread
            // 
            this.dgvSpread.AllowUserToAddRows = false;
            this.dgvSpread.AllowUserToDeleteRows = false;
            this.dgvSpread.AllowUserToResizeColumns = false;
            this.dgvSpread.AllowUserToResizeRows = false;
            this.dgvSpread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpread.ColumnHeadersVisible = false;
            this.dgvSpread.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmValue});
            this.dgvSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpread.Location = new System.Drawing.Point(0, 0);
            this.dgvSpread.Name = "dgvSpread";
            this.dgvSpread.ReadOnly = true;
            this.dgvSpread.RowHeadersVisible = false;
            this.dgvSpread.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSpread.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpread.Size = new System.Drawing.Size(177, 312);
            this.dgvSpread.TabIndex = 54;
            // 
            // chartSpread
            // 
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.LabelStyle.Format = "0.######";
            chartArea3.AxisY.MajorGrid.LineWidth = 0;
            chartArea3.Name = "ChartArea";
            this.chartSpread.ChartAreas.Add(chartArea3);
            this.chartSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSpread.Location = new System.Drawing.Point(0, 0);
            this.chartSpread.Name = "chartSpread";
            series3.BorderColor = System.Drawing.Color.DarkGreen;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series3.Color = System.Drawing.Color.YellowGreen;
            series3.Name = "BoxPlotSeries";
            series3.YValuesPerPoint = 6;
            this.chartSpread.Series.Add(series3);
            this.chartSpread.Size = new System.Drawing.Size(275, 312);
            this.chartSpread.TabIndex = 53;
            this.chartSpread.Text = "chart2";
            // 
            // splitHashesAndSensors
            // 
            this.splitHashesAndSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHashesAndSensors.Location = new System.Drawing.Point(0, 0);
            this.splitHashesAndSensors.Name = "splitHashesAndSensors";
            this.splitHashesAndSensors.Size = new System.Drawing.Size(1168, 225);
            this.splitHashesAndSensors.SplitterDistance = 461;
            this.splitHashesAndSensors.TabIndex = 0;
            // 
            // lblNvmlId
            // 
            this.lblNvmlId.AutoSize = true;
            this.lblNvmlId.Location = new System.Drawing.Point(134, 72);
            this.lblNvmlId.Name = "lblNvmlId";
            this.lblNvmlId.Size = new System.Drawing.Size(47, 13);
            this.lblNvmlId.TabIndex = 11;
            this.lblNvmlId.Text = "NVML #";
            // 
            // txtNvmlId
            // 
            this.txtNvmlId.BackColor = System.Drawing.SystemColors.Window;
            this.txtNvmlId.Location = new System.Drawing.Point(197, 69);
            this.txtNvmlId.Name = "txtNvmlId";
            this.txtNvmlId.ReadOnly = true;
            this.txtNvmlId.Size = new System.Drawing.Size(36, 20);
            this.txtNvmlId.TabIndex = 10;
            // 
            // lblNvapiId
            // 
            this.lblNvapiId.AutoSize = true;
            this.lblNvapiId.Location = new System.Drawing.Point(134, 48);
            this.lblNvapiId.Name = "lblNvapiId";
            this.lblNvapiId.Size = new System.Drawing.Size(49, 13);
            this.lblNvapiId.TabIndex = 9;
            this.lblNvapiId.Text = "NVAPI #";
            // 
            // txtNvapiId
            // 
            this.txtNvapiId.BackColor = System.Drawing.SystemColors.Window;
            this.txtNvapiId.Location = new System.Drawing.Point(196, 45);
            this.txtNvapiId.Name = "txtNvapiId";
            this.txtNvapiId.ReadOnly = true;
            this.txtNvapiId.Size = new System.Drawing.Size(36, 20);
            this.txtNvapiId.TabIndex = 8;
            // 
            // lblComputeCapability
            // 
            this.lblComputeCapability.AutoSize = true;
            this.lblComputeCapability.Location = new System.Drawing.Point(6, 98);
            this.lblComputeCapability.Name = "lblComputeCapability";
            this.lblComputeCapability.Size = new System.Drawing.Size(49, 13);
            this.lblComputeCapability.TabIndex = 13;
            this.lblComputeCapability.Text = "Compute";
            // 
            // txtComputeCapability
            // 
            this.txtComputeCapability.BackColor = System.Drawing.SystemColors.Window;
            this.txtComputeCapability.Location = new System.Drawing.Point(76, 95);
            this.txtComputeCapability.Name = "txtComputeCapability";
            this.txtComputeCapability.ReadOnly = true;
            this.txtComputeCapability.Size = new System.Drawing.Size(36, 20);
            this.txtComputeCapability.TabIndex = 12;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.FillWeight = 120F;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmValue
            // 
            this.clmValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmValue.FillWeight = 80F;
            this.clmValue.HeaderText = "Value";
            this.clmValue.Name = "clmValue";
            this.clmValue.ReadOnly = true;
            // 
            // BenchmarkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitGpuDetails);
            this.Name = "BenchmarkDetails";
            this.Size = new System.Drawing.Size(1168, 560);
            this.splitGpuDetails.Panel1.ResumeLayout(false);
            this.splitGpuDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGpuDetails)).EndInit();
            this.splitGpuDetails.ResumeLayout(false);
            this.splitStatsAndSpread.Panel1.ResumeLayout(false);
            this.splitStatsAndSpread.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStatsAndSpread)).EndInit();
            this.splitStatsAndSpread.ResumeLayout(false);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpHashrateSpread.ResumeLayout(false);
            this.splitSpread.Panel1.ResumeLayout(false);
            this.splitSpread.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSpread)).EndInit();
            this.splitSpread.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitHashesAndSensors)).EndInit();
            this.splitHashesAndSensors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitGpuDetails;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.SplitContainer splitHashesAndSensors;
        private System.Windows.Forms.GroupBox grpHashrateSpread;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpread;
        private System.Windows.Forms.SplitContainer splitStatsAndSpread;
        private System.Windows.Forms.DataGridView dgvSpread;
        private System.Windows.Forms.SplitContainer splitSpread;
        private System.Windows.Forms.Label lblGpuName;
        private System.Windows.Forms.TextBox txtGpuName;
        private System.Windows.Forms.Label lblBusId;
        private System.Windows.Forms.TextBox txtBusId;
        private System.Windows.Forms.Label lblMinerId;
        private System.Windows.Forms.TextBox txtMinerId;
        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblMinerName;
        private System.Windows.Forms.TextBox txtMinerName;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblBiosVersion;
        private System.Windows.Forms.TextBox txtBiosVersion;
        private System.Windows.Forms.Label lblPerformanceState;
        private System.Windows.Forms.TextBox txtPerformanceState;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.TextBox txtOperatingSystem;
        private System.Windows.Forms.Label lblDriverVersion;
        private System.Windows.Forms.TextBox txtDriverVersion;
        private System.Windows.Forms.Label lblAverageTemperature;
        private System.Windows.Forms.TextBox txtAverageTemperature;
        private System.Windows.Forms.Label lblHashCount;
        private System.Windows.Forms.TextBox txtHashCount;
        private System.Windows.Forms.Label lblAccepts;
        private System.Windows.Forms.TextBox txtAccepts;
        private System.Windows.Forms.Label lblAveragePing;
        private System.Windows.Forms.TextBox txtAveragePing;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.TextBox txtAlgorithm;
        private System.Windows.Forms.Label lblIntensity;
        private System.Windows.Forms.TextBox txtIntensity;
        private System.Windows.Forms.Label lblComputeCapability;
        private System.Windows.Forms.TextBox txtComputeCapability;
        private System.Windows.Forms.Label lblNvmlId;
        private System.Windows.Forms.TextBox txtNvmlId;
        private System.Windows.Forms.Label lblNvapiId;
        private System.Windows.Forms.TextBox txtNvapiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
    }
}
