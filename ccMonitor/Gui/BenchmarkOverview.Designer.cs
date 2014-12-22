namespace ccMonitor.Gui
{
    partial class BenchmarkOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcDetailedBenchmark = new System.Windows.Forms.TabControl();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.tabHashLogs = new System.Windows.Forms.TabPage();
            this.dgvHashLogs = new System.Windows.Forms.DataGridView();
            this.tabSensorLogs = new System.Windows.Forms.TabPage();
            this.dgvSensorLogs = new System.Windows.Forms.DataGridView();
            this.clmTimeStampSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFanPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoreClockFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMemoryClockFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShareAnswerPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMiningUrlPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetworkRigPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHashCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcDetailedBenchmark.SuspendLayout();
            this.tabHashLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashLogs)).BeginInit();
            this.tabSensorLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcDetailedBenchmark
            // 
            this.tbcDetailedBenchmark.Controls.Add(this.tabDetails);
            this.tbcDetailedBenchmark.Controls.Add(this.tabHashLogs);
            this.tbcDetailedBenchmark.Controls.Add(this.tabSensorLogs);
            this.tbcDetailedBenchmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDetailedBenchmark.Location = new System.Drawing.Point(0, 0);
            this.tbcDetailedBenchmark.Name = "tbcDetailedBenchmark";
            this.tbcDetailedBenchmark.SelectedIndex = 0;
            this.tbcDetailedBenchmark.Size = new System.Drawing.Size(1138, 490);
            this.tbcDetailedBenchmark.TabIndex = 1;
            // 
            // tabDetails
            // 
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(1130, 464);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            // 
            // tabHashLogs
            // 
            this.tabHashLogs.Controls.Add(this.dgvHashLogs);
            this.tabHashLogs.Location = new System.Drawing.Point(4, 22);
            this.tabHashLogs.Name = "tabHashLogs";
            this.tabHashLogs.Size = new System.Drawing.Size(1130, 464);
            this.tabHashLogs.TabIndex = 1;
            this.tabHashLogs.Text = "Hash Logs";
            // 
            // dgvHashLogs
            // 
            this.dgvHashLogs.AllowUserToAddRows = false;
            this.dgvHashLogs.AllowUserToDeleteRows = false;
            this.dgvHashLogs.AllowUserToOrderColumns = true;
            this.dgvHashLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHashLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTimeStamp,
            this.clmHashRate,
            this.clmHashCount,
            this.clmFound,
            this.clmHeight,
            this.clmDifficulty});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Format = "N3";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHashLogs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHashLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHashLogs.Location = new System.Drawing.Point(0, 0);
            this.dgvHashLogs.Name = "dgvHashLogs";
            this.dgvHashLogs.ReadOnly = true;
            this.dgvHashLogs.RowHeadersVisible = false;
            this.dgvHashLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHashLogs.Size = new System.Drawing.Size(1130, 464);
            this.dgvHashLogs.TabIndex = 0;
            // 
            // tabSensorLogs
            // 
            this.tabSensorLogs.Controls.Add(this.dgvSensorLogs);
            this.tabSensorLogs.Location = new System.Drawing.Point(4, 22);
            this.tabSensorLogs.Name = "tabSensorLogs";
            this.tabSensorLogs.Size = new System.Drawing.Size(1130, 464);
            this.tabSensorLogs.TabIndex = 2;
            this.tabSensorLogs.Text = "Sensor Logs";
            // 
            // dgvSensorLogs
            // 
            this.dgvSensorLogs.AllowUserToAddRows = false;
            this.dgvSensorLogs.AllowUserToDeleteRows = false;
            this.dgvSensorLogs.AllowUserToOrderColumns = true;
            this.dgvSensorLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensorLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTimeStampSensor,
            this.clmTemperature,
            this.clmFanPercentage,
            this.clmCoreClockFrequency,
            this.clmMemoryClockFrequency,
            this.clmShareAnswerPing,
            this.clmMiningUrlPing,
            this.clmNetworkRigPing});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.Format = "N3";
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSensorLogs.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSensorLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSensorLogs.Location = new System.Drawing.Point(0, 0);
            this.dgvSensorLogs.Name = "dgvSensorLogs";
            this.dgvSensorLogs.ReadOnly = true;
            this.dgvSensorLogs.RowHeadersVisible = false;
            this.dgvSensorLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSensorLogs.Size = new System.Drawing.Size(1130, 464);
            this.dgvSensorLogs.TabIndex = 1;
            // 
            // clmTimeStampSensor
            // 
            this.clmTimeStampSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTimeStampSensor.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "-1";
            this.clmTimeStampSensor.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmTimeStampSensor.HeaderText = "Timestamp";
            this.clmTimeStampSensor.Name = "clmTimeStampSensor";
            this.clmTimeStampSensor.ReadOnly = true;
            // 
            // clmTemperature
            // 
            this.clmTemperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTemperature.DataPropertyName = "Temperature";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "-1";
            this.clmTemperature.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmTemperature.HeaderText = "Temperature";
            this.clmTemperature.Name = "clmTemperature";
            this.clmTemperature.ReadOnly = true;
            // 
            // clmFanPercentage
            // 
            this.clmFanPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFanPercentage.DataPropertyName = "FanPercentage";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "-1";
            this.clmFanPercentage.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmFanPercentage.HeaderText = "Fan %";
            this.clmFanPercentage.Name = "clmFanPercentage";
            this.clmFanPercentage.ReadOnly = true;
            // 
            // clmCoreClockFrequency
            // 
            this.clmCoreClockFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCoreClockFrequency.DataPropertyName = "CoreClockFrequency";
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "-1";
            this.clmCoreClockFrequency.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmCoreClockFrequency.HeaderText = "Core frequency";
            this.clmCoreClockFrequency.Name = "clmCoreClockFrequency";
            this.clmCoreClockFrequency.ReadOnly = true;
            this.clmCoreClockFrequency.Width = 96;
            // 
            // clmMemoryClockFrequency
            // 
            this.clmMemoryClockFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmMemoryClockFrequency.DataPropertyName = "MemoryClockFrequency";
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "-1";
            this.clmMemoryClockFrequency.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmMemoryClockFrequency.HeaderText = "Memory frequency";
            this.clmMemoryClockFrequency.Name = "clmMemoryClockFrequency";
            this.clmMemoryClockFrequency.ReadOnly = true;
            this.clmMemoryClockFrequency.Width = 109;
            // 
            // clmShareAnswerPing
            // 
            this.clmShareAnswerPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmShareAnswerPing.DataPropertyName = "ShareAnswerPing";
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = "-1";
            this.clmShareAnswerPing.DefaultCellStyle = dataGridViewCellStyle13;
            this.clmShareAnswerPing.HeaderText = "Ping: Miner to URL";
            this.clmShareAnswerPing.Name = "clmShareAnswerPing";
            this.clmShareAnswerPing.ReadOnly = true;
            // 
            // clmMiningUrlPing
            // 
            this.clmMiningUrlPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMiningUrlPing.DataPropertyName = "MiningUrlPing";
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = "-1";
            this.clmMiningUrlPing.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmMiningUrlPing.HeaderText = "Ping: This to URL";
            this.clmMiningUrlPing.Name = "clmMiningUrlPing";
            this.clmMiningUrlPing.ReadOnly = true;
            // 
            // clmNetworkRigPing
            // 
            this.clmNetworkRigPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNetworkRigPing.DataPropertyName = "NetworkRigPing";
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "-1";
            this.clmNetworkRigPing.DefaultCellStyle = dataGridViewCellStyle15;
            this.clmNetworkRigPing.HeaderText = "Ping: This to miner";
            this.clmNetworkRigPing.Name = "clmNetworkRigPing";
            this.clmNetworkRigPing.ReadOnly = true;
            // 
            // clmTimeStamp
            // 
            this.clmTimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTimeStamp.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "-1";
            this.clmTimeStamp.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmTimeStamp.HeaderText = "Timestamp";
            this.clmTimeStamp.Name = "clmTimeStamp";
            this.clmTimeStamp.ReadOnly = true;
            // 
            // clmHashRate
            // 
            this.clmHashRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHashRate.DataPropertyName = "HashRate";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "-1";
            this.clmHashRate.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmHashRate.HeaderText = "Hashrate";
            this.clmHashRate.Name = "clmHashRate";
            this.clmHashRate.ReadOnly = true;
            // 
            // clmHashCount
            // 
            this.clmHashCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHashCount.DataPropertyName = "HashCount";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "-1";
            this.clmHashCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmHashCount.HeaderText = "Hashcount";
            this.clmHashCount.Name = "clmHashCount";
            this.clmHashCount.ReadOnly = true;
            // 
            // clmFound
            // 
            this.clmFound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFound.DataPropertyName = "Found";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.clmFound.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmFound.HeaderText = "Found";
            this.clmFound.Name = "clmFound";
            this.clmFound.ReadOnly = true;
            // 
            // clmHeight
            // 
            this.clmHeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHeight.DataPropertyName = "Height";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "-1";
            this.clmHeight.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmHeight.HeaderText = "Height";
            this.clmHeight.Name = "clmHeight";
            this.clmHeight.ReadOnly = true;
            // 
            // clmDifficulty
            // 
            this.clmDifficulty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDifficulty.DataPropertyName = "Difficulty";
            dataGridViewCellStyle6.Format = "N6";
            dataGridViewCellStyle6.NullValue = "-1";
            this.clmDifficulty.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmDifficulty.HeaderText = "Difficulty";
            this.clmDifficulty.Name = "clmDifficulty";
            this.clmDifficulty.ReadOnly = true;
            // 
            // BenchmarkOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 490);
            this.Controls.Add(this.tbcDetailedBenchmark);
            this.Name = "BenchmarkOverview";
            this.Text = "BenchmarkOverview";
            this.tbcDetailedBenchmark.ResumeLayout(false);
            this.tabHashLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashLogs)).EndInit();
            this.tabSensorLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDetailedBenchmark;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.TabPage tabHashLogs;
        private System.Windows.Forms.DataGridView dgvHashLogs;
        private System.Windows.Forms.TabPage tabSensorLogs;
        private System.Windows.Forms.DataGridView dgvSensorLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeStampSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFanPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreClockFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemoryClockFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShareAnswerPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMiningUrlPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetworkRigPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHashCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDifficulty;

    }
}