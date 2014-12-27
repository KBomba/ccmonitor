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
            this.tbcBenchmarkOverview = new System.Windows.Forms.TabControl();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.tabHashCharts = new System.Windows.Forms.TabPage();
            this.tabSensorCharts = new System.Windows.Forms.TabPage();
            this.tbcBenchmarkOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcBenchmarkOverview
            // 
            this.tbcBenchmarkOverview.Controls.Add(this.tabDetails);
            this.tbcBenchmarkOverview.Controls.Add(this.tabHashCharts);
            this.tbcBenchmarkOverview.Controls.Add(this.tabSensorCharts);
            this.tbcBenchmarkOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcBenchmarkOverview.Location = new System.Drawing.Point(0, 0);
            this.tbcBenchmarkOverview.Name = "tbcBenchmarkOverview";
            this.tbcBenchmarkOverview.SelectedIndex = 0;
            this.tbcBenchmarkOverview.Size = new System.Drawing.Size(1184, 562);
            this.tbcBenchmarkOverview.TabIndex = 0;
            // 
            // tabDetails
            // 
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(1176, 536);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            // 
            // tabHashCharts
            // 
            this.tabHashCharts.Location = new System.Drawing.Point(4, 22);
            this.tabHashCharts.Name = "tabHashCharts";
            this.tabHashCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabHashCharts.Size = new System.Drawing.Size(1176, 536);
            this.tabHashCharts.TabIndex = 1;
            this.tabHashCharts.Text = "Hashrate charts";
            // 
            // tabSensorCharts
            // 
            this.tabSensorCharts.Location = new System.Drawing.Point(4, 22);
            this.tabSensorCharts.Name = "tabSensorCharts";
            this.tabSensorCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabSensorCharts.Size = new System.Drawing.Size(1176, 536);
            this.tabSensorCharts.TabIndex = 2;
            this.tabSensorCharts.Text = "Sensor charts";
            // 
            // BenchmarkOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.tbcBenchmarkOverview);
            this.Name = "BenchmarkOverview";
            this.Text = "Benchmark overview";
            this.tbcBenchmarkOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcBenchmarkOverview;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.TabPage tabHashCharts;
        private System.Windows.Forms.TabPage tabSensorCharts;
    }
}