namespace ccMonitor.Gui
{
    partial class HashLogView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHashLogs = new System.Windows.Forms.DataGridView();
            this.clmTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHashCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashLogs)).BeginInit();
            this.SuspendLayout();
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
            this.dgvHashLogs.TabIndex = 1;
            // 
            // clmTimeStamp
            // 
            this.clmTimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTimeStamp.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "-1";
            this.clmTimeStamp.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmTimeStamp.HeaderText = "Timestamp";
            this.clmTimeStamp.Name = "clmTimeStamp";
            this.clmTimeStamp.ReadOnly = true;
            this.clmTimeStamp.Width = 83;
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
            // HashLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHashLogs);
            this.Name = "HashLogView";
            this.Size = new System.Drawing.Size(1130, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHashLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHashLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHashCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDifficulty;
    }
}
