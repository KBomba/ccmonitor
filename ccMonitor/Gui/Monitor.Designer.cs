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
            this.tabRigStats = new System.Windows.Forms.TabPage();
            this.tabRawLogs = new System.Windows.Forms.TabPage();
            this.tabReadMe = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.txtRawLogs = new System.Windows.Forms.TextBox();
            this.txtReadMe = new System.Windows.Forms.TextBox();
            this.scGeneral = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbcMonitor.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabRawLogs.SuspendLayout();
            this.tabReadMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).BeginInit();
            this.scGeneral.Panel1.SuspendLayout();
            this.scGeneral.Panel2.SuspendLayout();
            this.scGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // tabRigStats
            // 
            this.tabRigStats.Location = new System.Drawing.Point(4, 22);
            this.tabRigStats.Name = "tabRigStats";
            this.tabRigStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigStats.Size = new System.Drawing.Size(1233, 481);
            this.tabRigStats.TabIndex = 1;
            this.tabRigStats.Text = "Rig Stats";
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
            // tabReadMe
            // 
            this.tabReadMe.Controls.Add(this.txtReadMe);
            this.tabReadMe.Location = new System.Drawing.Point(4, 22);
            this.tabReadMe.Name = "tabReadMe";
            this.tabReadMe.Size = new System.Drawing.Size(1233, 481);
            this.tabReadMe.TabIndex = 3;
            this.tabReadMe.Text = "Read Me";
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1233, 481);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
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
            this.scGeneral.SplitterDistance = 266;
            this.scGeneral.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(957, 475);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 507);
            this.Controls.Add(this.tbcMonitor);
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.tbcMonitor.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabRawLogs.ResumeLayout(false);
            this.tabRawLogs.PerformLayout();
            this.tabReadMe.ResumeLayout(false);
            this.tabReadMe.PerformLayout();
            this.scGeneral.Panel1.ResumeLayout(false);
            this.scGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).EndInit();
            this.scGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}