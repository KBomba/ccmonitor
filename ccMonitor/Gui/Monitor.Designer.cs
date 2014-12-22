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
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRawLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcMonitor.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).BeginInit();
            this.scGeneral.Panel1.SuspendLayout();
            this.scGeneral.Panel2.SuspendLayout();
            this.scGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRigs)).BeginInit();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMonitor
            // 
            this.tbcMonitor.Controls.Add(this.tabGeneral);
            this.tbcMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMonitor.Location = new System.Drawing.Point(0, 24);
            this.tbcMonitor.Name = "tbcMonitor";
            this.tbcMonitor.SelectedIndex = 0;
            this.tbcMonitor.Size = new System.Drawing.Size(1241, 483);
            this.tbcMonitor.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.scGeneral);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1233, 457);
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
            this.scGeneral.Size = new System.Drawing.Size(1227, 451);
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
            this.dgvRigs.Size = new System.Drawing.Size(299, 451);
            this.dgvRigs.TabIndex = 0;
            this.dgvRigs.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvRigs_CellBeginEdit);
            this.dgvRigs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRigs_CellEndEdit);
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
            this.lstGeneralOverview.Size = new System.Drawing.Size(924, 451);
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
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuGeneral.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(1241, 24);
            this.menuGeneral.TabIndex = 2;
            this.menuGeneral.Text = "menuGeneral";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLogsToolStripMenuItem,
            this.showRawLogsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // saveLogsToolStripMenuItem
            // 
            this.saveLogsToolStripMenuItem.Name = "saveLogsToolStripMenuItem";
            this.saveLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveLogsToolStripMenuItem.Text = "Save logs";
            this.saveLogsToolStripMenuItem.Click += new System.EventHandler(this.saveLogsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readMeToolStripMenuItem.Text = "Read me";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // showRawLogsToolStripMenuItem
            // 
            this.showRawLogsToolStripMenuItem.Name = "showRawLogsToolStripMenuItem";
            this.showRawLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showRawLogsToolStripMenuItem.Text = "Show raw logs";
            this.showRawLogsToolStripMenuItem.Click += new System.EventHandler(this.showRawLogsToolStripMenuItem_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 507);
            this.Controls.Add(this.tbcMonitor);
            this.Controls.Add(this.menuGeneral);
            this.MainMenuStrip = this.menuGeneral;
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
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMonitor;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.SplitContainer scGeneral;
        private System.Windows.Forms.DataGridView dgvRigs;
        private System.Windows.Forms.ListView lstGeneralOverview;
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
        private System.Windows.Forms.MenuStrip menuGeneral;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRawLogsToolStripMenuItem;
    }
}