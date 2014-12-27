namespace ccMonitor.Gui
{
    partial class RigTab
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
            this.tbcRig = new System.Windows.Forms.TabControl();
            this.tabRigOverview = new System.Windows.Forms.TabPage();
            this.tabRigApiConsole = new System.Windows.Forms.TabPage();
            this.txtApiConsole = new System.Windows.Forms.TextBox();
            this.tbcRig.SuspendLayout();
            this.tabRigApiConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRig
            // 
            this.tbcRig.Controls.Add(this.tabRigOverview);
            this.tbcRig.Controls.Add(this.tabRigApiConsole);
            this.tbcRig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRig.Location = new System.Drawing.Point(0, 0);
            this.tbcRig.Name = "tbcRig";
            this.tbcRig.SelectedIndex = 0;
            this.tbcRig.Size = new System.Drawing.Size(1176, 586);
            this.tbcRig.TabIndex = 0;
            // 
            // tabRigOverview
            // 
            this.tabRigOverview.Location = new System.Drawing.Point(4, 22);
            this.tabRigOverview.Name = "tabRigOverview";
            this.tabRigOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigOverview.Size = new System.Drawing.Size(1168, 560);
            this.tabRigOverview.TabIndex = 0;
            this.tabRigOverview.Text = "Rig overview";
            // 
            // tabRigApiConsole
            // 
            this.tabRigApiConsole.Controls.Add(this.txtApiConsole);
            this.tabRigApiConsole.Location = new System.Drawing.Point(4, 22);
            this.tabRigApiConsole.Name = "tabRigApiConsole";
            this.tabRigApiConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigApiConsole.Size = new System.Drawing.Size(1168, 560);
            this.tabRigApiConsole.TabIndex = 1;
            this.tabRigApiConsole.Text = "API console";
            // 
            // txtApiConsole
            // 
            this.txtApiConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtApiConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApiConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtApiConsole.Location = new System.Drawing.Point(3, 3);
            this.txtApiConsole.Multiline = true;
            this.txtApiConsole.Name = "txtApiConsole";
            this.txtApiConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtApiConsole.Size = new System.Drawing.Size(1162, 554);
            this.txtApiConsole.TabIndex = 0;
            this.txtApiConsole.Text = " >  ";
            this.txtApiConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApiConsole_KeyDown);
            // 
            // RigTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcRig);
            this.Name = "RigTab";
            this.Size = new System.Drawing.Size(1176, 586);
            this.tbcRig.ResumeLayout(false);
            this.tabRigApiConsole.ResumeLayout(false);
            this.tabRigApiConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabRigOverview;
        private System.Windows.Forms.TabPage tabRigApiConsole;
        private System.Windows.Forms.TextBox txtApiConsole;
        internal System.Windows.Forms.TabControl tbcRig;
    }
}
