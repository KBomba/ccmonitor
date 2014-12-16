namespace ccMonitor.Gui
{
    partial class Monitor
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
            this.tbcMonitor = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.scGeneral = new System.Windows.Forms.SplitContainer();
            this.dgvRigs = new System.Windows.Forms.DataGridView();
            this.RigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstGeneralOverview = new System.Windows.Forms.ListView();
            this.clmNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAlgorithm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHashRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStandardDeviation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHashCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAccepts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRejects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabRigStats = new System.Windows.Forms.TabPage();
            this.tbcRigStats = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabRawLogs = new System.Windows.Forms.TabPage();
            this.txtRawLogs = new System.Windows.Forms.TextBox();
            this.tabReadMe = new System.Windows.Forms.TabPage();
            this.txtReadMe = new System.Windows.Forms.TextBox();
            this.tbcMonitor.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).BeginInit();
            this.scGeneral.Panel1.SuspendLayout();
            this.scGeneral.Panel2.SuspendLayout();
            this.scGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRigs)).BeginInit();
            this.tabRigStats.SuspendLayout();
            this.tabRawLogs.SuspendLayout();
            this.tabReadMe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMonitor
            // 
            this.tbcMonitor.Controls.Add(this.tabGeneral);
            this.tbcMonitor.Controls.Add(this.tabRigStats);
            this.tbcMonitor.Controls.Add(this.tabSettings);
            this.tbcMonitor.Controls.Add(this.tabRawLogs);
            this.tbcMonitor.Controls.Add(this.tabReadMe);
            this.tbcMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMonitor.Location = new System.Drawing.Point(0, 0);
            this.tbcMonitor.Name = "tbcMonitor";
            this.tbcMonitor.SelectedIndex = 0;
            this.tbcMonitor.Size = new System.Drawing.Size(1241, 507);
            this.tbcMonitor.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.scGeneral);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1233, 481);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            // 
            // scGeneral
            // 
            this.scGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scGeneral.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scGeneral.Location = new System.Drawing.Point(3, 3);
            this.scGeneral.Name = "scGeneral";
            // 
            // scGeneral.Panel1
            // 
            this.scGeneral.Panel1.Controls.Add(this.dgvRigs);
            // 
            // scGeneral.Panel2
            // 
            this.scGeneral.Panel2.Controls.Add(this.lstGeneralOverview);
            this.scGeneral.Size = new System.Drawing.Size(1227, 475);
            this.scGeneral.SplitterDistance = 299;
            this.scGeneral.TabIndex = 0;
            // 
            // dgvRigs
            // 
            this.dgvRigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RigName,
            this.IpAddress,
            this.Port});
            this.dgvRigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRigs.Location = new System.Drawing.Point(0, 0);
            this.dgvRigs.MultiSelect = false;
            this.dgvRigs.Name = "dgvRigs";
            this.dgvRigs.Size = new System.Drawing.Size(299, 475);
            this.dgvRigs.TabIndex = 0;
            // 
            // RigName
            // 
            this.RigName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RigName.DataPropertyName = "Name";
            this.RigName.HeaderText = "Name";
            this.RigName.Name = "RigName";
            // 
            // IpAddress
            // 
            this.IpAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IpAddress.DataPropertyName = "IpAddress";
            this.IpAddress.HeaderText = "IP Address";
            this.IpAddress.Name = "IpAddress";
            // 
            // Port
            // 
            this.Port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Port.DataPropertyName = "Port";
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.Width = 51;
            // 
            // lstGeneralOverview
            // 
            this.lstGeneralOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNumber,
            this.clmName,
            this.clmAlgorithm,
            this.clmHashRate,
            this.clmStandardDeviation,
            this.clmHashCount,
            this.clmAccepts,
            this.clmRejects,
            this.clmTemperature,
            this.clmPingTime});
            this.lstGeneralOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGeneralOverview.FullRowSelect = true;
            this.lstGeneralOverview.GridLines = true;
            this.lstGeneralOverview.Location = new System.Drawing.Point(0, 0);
            this.lstGeneralOverview.Name = "lstGeneralOverview";
            this.lstGeneralOverview.Size = new System.Drawing.Size(924, 475);
            this.lstGeneralOverview.TabIndex = 0;
            this.lstGeneralOverview.UseCompatibleStateImageBehavior = false;
            this.lstGeneralOverview.View = System.Windows.Forms.View.Details;
            this.lstGeneralOverview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstGeneralOverview_MouseDoubleClick);
            // 
            // clmNumber
            // 
            this.clmNumber.Text = "#";
            this.clmNumber.Width = 40;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 160;
            // 
            // clmAlgorithm
            // 
            this.clmAlgorithm.Text = "Algorithm";
            this.clmAlgorithm.Width = 80;
            // 
            // clmHashRate
            // 
            this.clmHashRate.Text = "Hashrate";
            this.clmHashRate.Width = 110;
            // 
            // clmStandardDeviation
            // 
            this.clmStandardDeviation.Text = "Standard Deviation";
            this.clmStandardDeviation.Width = 110;
            // 
            // clmHashCount
            // 
            this.clmHashCount.Text = "Hash Count";
            this.clmHashCount.Width = 100;
            // 
            // clmAccepts
            // 
            this.clmAccepts.Text = "Accepts";
            this.clmAccepts.Width = 70;
            // 
            // clmRejects
            // 
            this.clmRejects.Text = "Rejects";
            this.clmRejects.Width = 70;
            // 
            // clmTemperature
            // 
            this.clmTemperature.Text = "Temperature";
            this.clmTemperature.Width = 80;
            // 
            // clmPingTime
            // 
            this.clmPingTime.Text = "Ping Time";
            this.clmPingTime.Width = 80;
            // 
            // tabRigStats
            // 
            this.tabRigStats.Controls.Add(this.tbcRigStats);
            this.tabRigStats.Location = new System.Drawing.Point(4, 22);
            this.tabRigStats.Name = "tabRigStats";
            this.tabRigStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigStats.Size = new System.Drawing.Size(1233, 481);
            this.tabRigStats.TabIndex = 1;
            this.tabRigStats.Text = "Rig Stats";
            // 
            // tbcRigStats
            // 
            this.tbcRigStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRigStats.Location = new System.Drawing.Point(3, 3);
            this.tbcRigStats.Name = "tbcRigStats";
            this.tbcRigStats.SelectedIndex = 0;
            this.tbcRigStats.Size = new System.Drawing.Size(1227, 475);
            this.tbcRigStats.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1233, 481);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            // 
            // tabRawLogs
            // 
            this.tabRawLogs.Controls.Add(this.txtRawLogs);
            this.tabRawLogs.Location = new System.Drawing.Point(4, 22);
            this.tabRawLogs.Name = "tabRawLogs";
            this.tabRawLogs.Size = new System.Drawing.Size(1233, 481);
            this.tabRawLogs.TabIndex = 2;
            this.tabRawLogs.Text = "Raw Logs";
            // 
            // txtRawLogs
            // 
            this.txtRawLogs.BackColor = System.Drawing.SystemColors.Window;
            this.txtRawLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawLogs.Location = new System.Drawing.Point(0, 0);
            this.txtRawLogs.Multiline = true;
            this.txtRawLogs.Name = "txtRawLogs";
            this.txtRawLogs.ReadOnly = true;
            this.txtRawLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRawLogs.Size = new System.Drawing.Size(1233, 481);
            this.txtRawLogs.TabIndex = 0;
            // 
            // tabReadMe
            // 
            this.tabReadMe.Controls.Add(this.txtReadMe);
            this.tabReadMe.Location = new System.Drawing.Point(4, 22);
            this.tabReadMe.Name = "tabReadMe";
            this.tabReadMe.Size = new System.Drawing.Size(1233, 481);
            this.tabReadMe.TabIndex = 3;
            this.tabReadMe.Text = "Read Me";
            // 
            // txtReadMe
            // 
            this.txtReadMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReadMe.Location = new System.Drawing.Point(0, 0);
            this.txtReadMe.Multiline = true;
            this.txtReadMe.Name = "txtReadMe";
            this.txtReadMe.ReadOnly = true;
            this.txtReadMe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadMe.Size = new System.Drawing.Size(1233, 481);
            this.txtReadMe.TabIndex = 1;
            this.txtReadMe.Text = "Seems like README.txt is missing :) But you can still donate some BTC @ 1BombaWy4" +
    "6SPqX8NJumFBvSjSpry8hpzr4 ";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 507);
            this.Controls.Add(this.tbcMonitor);
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Monitor_FormClosing);
            this.tbcMonitor.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.scGeneral.Panel1.ResumeLayout(false);
            this.scGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).EndInit();
            this.scGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRigs)).EndInit();
            this.tabRigStats.ResumeLayout(false);
            this.tabRawLogs.ResumeLayout(false);
            this.tabRawLogs.PerformLayout();
            this.tabReadMe.ResumeLayout(false);
            this.tabReadMe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMonitor;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabRigStats;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabRawLogs;
        private System.Windows.Forms.TextBox txtRawLogs;
        private System.Windows.Forms.TabPage tabReadMe;
        private System.Windows.Forms.TextBox txtReadMe;
        private System.Windows.Forms.SplitContainer scGeneral;
        private System.Windows.Forms.DataGridView dgvRigs;
        private System.Windows.Forms.ListView lstGeneralOverview;
        private System.Windows.Forms.TabControl tbcRigStats;
        private System.Windows.Forms.ColumnHeader clmNumber;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAlgorithm;
        private System.Windows.Forms.ColumnHeader clmHashRate;
        private System.Windows.Forms.ColumnHeader clmStandardDeviation;
        private System.Windows.Forms.ColumnHeader clmHashCount;
        private System.Windows.Forms.ColumnHeader clmAccepts;
        private System.Windows.Forms.ColumnHeader clmRejects;
        private System.Windows.Forms.ColumnHeader clmTemperature;
        private System.Windows.Forms.ColumnHeader clmPingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
    }
}