namespace RRCAGApp
{
    partial class VehicleDataForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuVehicleDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleDataFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuVehicleDataFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleDataEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleDataEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVehicleData = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleDataFile,
            this.mnuVehicleDataEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2154, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuVehicleDataFile
            // 
            this.mnuVehicleDataFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleDataFileSave,
            this.toolStripMenuItem1,
            this.mnuVehicleDataFileClose});
            this.mnuVehicleDataFile.Name = "mnuVehicleDataFile";
            this.mnuVehicleDataFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mnuVehicleDataFile.Size = new System.Drawing.Size(64, 36);
            this.mnuVehicleDataFile.Text = "&File";
            // 
            // mnuVehicleDataFileSave
            // 
            this.mnuVehicleDataFileSave.Name = "mnuVehicleDataFileSave";
            this.mnuVehicleDataFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuVehicleDataFileSave.Size = new System.Drawing.Size(262, 38);
            this.mnuVehicleDataFileSave.Text = "&Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(259, 6);
            // 
            // mnuVehicleDataFileClose
            // 
            this.mnuVehicleDataFileClose.Name = "mnuVehicleDataFileClose";
            this.mnuVehicleDataFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuVehicleDataFileClose.Size = new System.Drawing.Size(262, 38);
            this.mnuVehicleDataFileClose.Text = "&Close";
            // 
            // mnuVehicleDataEdit
            // 
            this.mnuVehicleDataEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleDataEditDelete});
            this.mnuVehicleDataEdit.Name = "mnuVehicleDataEdit";
            this.mnuVehicleDataEdit.Size = new System.Drawing.Size(67, 36);
            this.mnuVehicleDataEdit.Text = "&Edit";
            // 
            // mnuVehicleDataEditDelete
            // 
            this.mnuVehicleDataEditDelete.Name = "mnuVehicleDataEditDelete";
            this.mnuVehicleDataEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuVehicleDataEditDelete.Size = new System.Drawing.Size(235, 38);
            this.mnuVehicleDataEditDelete.Text = "&Delete";
            // 
            // dgvVehicleData
            // 
            this.dgvVehicleData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleData.Location = new System.Drawing.Point(0, 43);
            this.dgvVehicleData.MultiSelect = false;
            this.dgvVehicleData.Name = "dgvVehicleData";
            this.dgvVehicleData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVehicleData.RowTemplate.Height = 33;
            this.dgvVehicleData.Size = new System.Drawing.Size(2154, 1207);
            this.dgvVehicleData.TabIndex = 1;
            // 
            // VehicleDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2154, 1248);
            this.Controls.Add(this.dgvVehicleData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "VehicleDataForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vehicle Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleDataFile;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleDataFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleDataFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleDataEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleDataEditDelete;
        private System.Windows.Forms.DataGridView dgvVehicleData;
    }
}