namespace ccMonitor.Gui
{
    partial class SensorLogView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSensorLogs = new System.Windows.Forms.DataGridView();
            this.clmTimeStampSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFanPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFanRpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoreClockFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMemoryClockFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShareAnswerPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMiningUrlPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetworkRigPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorLogs)).BeginInit();
            this.SuspendLayout();
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
            this.clmFanRpm,
            this.clmCoreClockFrequency,
            this.clmMemoryClockFrequency,
            this.clmShareAnswerPing,
            this.clmMiningUrlPing,
            this.clmNetworkRigPing});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSensorLogs.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSensorLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSensorLogs.Location = new System.Drawing.Point(0, 0);
            this.dgvSensorLogs.Name = "dgvSensorLogs";
            this.dgvSensorLogs.ReadOnly = true;
            this.dgvSensorLogs.RowHeadersVisible = false;
            this.dgvSensorLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSensorLogs.Size = new System.Drawing.Size(1130, 464);
            this.dgvSensorLogs.TabIndex = 2;
            // 
            // clmTimeStampSensor
            // 
            this.clmTimeStampSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTimeStampSensor.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "-1";
            this.clmTimeStampSensor.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmTimeStampSensor.HeaderText = "Timestamp";
            this.clmTimeStampSensor.Name = "clmTimeStampSensor";
            this.clmTimeStampSensor.ReadOnly = true;
            this.clmTimeStampSensor.Width = 83;
            // 
            // clmTemperature
            // 
            this.clmTemperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTemperature.DataPropertyName = "Temperature";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "-1";
            this.clmTemperature.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmTemperature.HeaderText = "Temperature";
            this.clmTemperature.Name = "clmTemperature";
            this.clmTemperature.ReadOnly = true;
            // 
            // clmFanPercentage
            // 
            this.clmFanPercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFanPercentage.DataPropertyName = "FanPercentage";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "-1";
            this.clmFanPercentage.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmFanPercentage.HeaderText = "Fan (%)";
            this.clmFanPercentage.Name = "clmFanPercentage";
            this.clmFanPercentage.ReadOnly = true;
            // 
            // clmFanRpm
            // 
            this.clmFanRpm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFanRpm.DataPropertyName = "FanRpm";
            this.clmFanRpm.HeaderText = "Fan (rpm)";
            this.clmFanRpm.Name = "clmFanRpm";
            this.clmFanRpm.ReadOnly = true;
            // 
            // clmCoreClockFrequency
            // 
            this.clmCoreClockFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCoreClockFrequency.DataPropertyName = "CoreClockFrequency";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "-1";
            this.clmCoreClockFrequency.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCoreClockFrequency.HeaderText = "Core frequency";
            this.clmCoreClockFrequency.Name = "clmCoreClockFrequency";
            this.clmCoreClockFrequency.ReadOnly = true;
            // 
            // clmMemoryClockFrequency
            // 
            this.clmMemoryClockFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMemoryClockFrequency.DataPropertyName = "MemoryClockFrequency";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "-1";
            this.clmMemoryClockFrequency.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmMemoryClockFrequency.HeaderText = "Memory frequency";
            this.clmMemoryClockFrequency.Name = "clmMemoryClockFrequency";
            this.clmMemoryClockFrequency.ReadOnly = true;
            // 
            // clmShareAnswerPing
            // 
            this.clmShareAnswerPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmShareAnswerPing.DataPropertyName = "ShareAnswerPing";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "-1";
            this.clmShareAnswerPing.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmShareAnswerPing.HeaderText = "Ping: Miner to URL";
            this.clmShareAnswerPing.Name = "clmShareAnswerPing";
            this.clmShareAnswerPing.ReadOnly = true;
            // 
            // clmMiningUrlPing
            // 
            this.clmMiningUrlPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMiningUrlPing.DataPropertyName = "MiningUrlPing";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "-1";
            this.clmMiningUrlPing.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmMiningUrlPing.HeaderText = "Ping: This to URL";
            this.clmMiningUrlPing.Name = "clmMiningUrlPing";
            this.clmMiningUrlPing.ReadOnly = true;
            // 
            // clmNetworkRigPing
            // 
            this.clmNetworkRigPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNetworkRigPing.DataPropertyName = "NetworkRigPing";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "-1";
            this.clmNetworkRigPing.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmNetworkRigPing.HeaderText = "Ping: This to miner";
            this.clmNetworkRigPing.Name = "clmNetworkRigPing";
            this.clmNetworkRigPing.ReadOnly = true;
            // 
            // SensorLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSensorLogs);
            this.Name = "SensorLogView";
            this.Size = new System.Drawing.Size(1130, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSensorLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeStampSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFanPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFanRpm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreClockFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemoryClockFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShareAnswerPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMiningUrlPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetworkRigPing;
    }
}
