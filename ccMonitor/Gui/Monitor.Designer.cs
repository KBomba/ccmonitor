namespace ccMonitor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabRigStats = new System.Windows.Forms.TabPage();
            this.tbcRigStats = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabRawLogs = new System.Windows.Forms.TabPage();
            this.txtRawLogs = new System.Windows.Forms.TextBox();
            this.tabReadMe = new System.Windows.Forms.TabPage();
            this.txtReadMe = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbcMonitor.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).BeginInit();
            this.scGeneral.Panel1.SuspendLayout();
            this.scGeneral.Panel2.SuspendLayout();
            this.scGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.scGeneral.Location = new System.Drawing.Point(3, 3);
            this.scGeneral.Name = "scGeneral";
            // 
            // scGeneral.Panel1
            // 
            this.scGeneral.Panel1.Controls.Add(this.dataGridView1);
            // 
            // scGeneral.Panel2
            // 
            this.scGeneral.Panel2.Controls.Add(this.listView1);
            this.scGeneral.Size = new System.Drawing.Size(1227, 475);
            this.scGeneral.SplitterDistance = 346;
            this.scGeneral.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.IpAddress,
            this.Port,
            this.Local});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 475);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.tabRawLogs.Click += new System.EventHandler(this.tabRawLogs_Click);
            // 
            // txtRawLogs
            // 
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
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
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
            // Local
            // 
            this.Local.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Local.DataPropertyName = "Local";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.Width = 39;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 507);
            this.Controls.Add(this.tbcMonitor);
            this.Text = "Monitor";
            this.tbcMonitor.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.scGeneral.Panel1.ResumeLayout(false);
            this.scGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).EndInit();
            this.scGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tbcRigStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Local;
    }
}