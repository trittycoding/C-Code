namespace RRCAGApp
{
    partial class CarWashForm
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
            this.mnuCarWashFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarWashGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCarWashExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCarWashPackage = new System.Windows.Forms.Label();
            this.lblCarWashFragrance = new System.Windows.Forms.Label();
            this.cboCarWashFragrance = new System.Windows.Forms.ComboBox();
            this.cboCarWashPackage = new System.Windows.Forms.ComboBox();
            this.grpCarWashSummary = new System.Windows.Forms.GroupBox();
            this.lstCarWashSummaryInteriorBox = new System.Windows.Forms.ListBox();
            this.lstCarWashSummaryExteriorBox = new System.Windows.Forms.ListBox();
            this.lblCarWashSummaryExterior = new System.Windows.Forms.Label();
            this.lblCarWashSummaryInterior = new System.Windows.Forms.Label();
            this.lblCarWashSubtotal = new System.Windows.Forms.Label();
            this.lblCarWashSubtotalOut = new System.Windows.Forms.Label();
            this.lblCarWashPST = new System.Windows.Forms.Label();
            this.lblCarWashPSTOut = new System.Windows.Forms.Label();
            this.lblCarWashGST = new System.Windows.Forms.Label();
            this.lblCarWashGSTOut = new System.Windows.Forms.Label();
            this.lblCarWashTotal = new System.Windows.Forms.Label();
            this.lblCarWashTotalOut = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpCarWashSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarWashFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCarWashFile
            // 
            this.mnuCarWashFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarWashGenerateInvoice,
            this.toolStripMenuItem1,
            this.mnuCarWashExit});
            this.mnuCarWashFile.Name = "mnuCarWashFile";
            this.mnuCarWashFile.Size = new System.Drawing.Size(64, 38);
            this.mnuCarWashFile.Text = "&File";
            // 
            // mnuCarWashGenerateInvoice
            // 
            this.mnuCarWashGenerateInvoice.Name = "mnuCarWashGenerateInvoice";
            this.mnuCarWashGenerateInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuCarWashGenerateInvoice.Size = new System.Drawing.Size(448, 38);
            this.mnuCarWashGenerateInvoice.Text = "&Generate Invoice...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(445, 6);
            // 
            // mnuCarWashExit
            // 
            this.mnuCarWashExit.Name = "mnuCarWashExit";
            this.mnuCarWashExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuCarWashExit.Size = new System.Drawing.Size(448, 38);
            this.mnuCarWashExit.Text = "E&xit";
            // 
            // lblCarWashPackage
            // 
            this.lblCarWashPackage.AutoSize = true;
            this.lblCarWashPackage.Location = new System.Drawing.Point(49, 86);
            this.lblCarWashPackage.Name = "lblCarWashPackage";
            this.lblCarWashPackage.Size = new System.Drawing.Size(102, 25);
            this.lblCarWashPackage.TabIndex = 6;
            this.lblCarWashPackage.Text = "Package:";
            // 
            // lblCarWashFragrance
            // 
            this.lblCarWashFragrance.AutoSize = true;
            this.lblCarWashFragrance.Location = new System.Drawing.Point(370, 86);
            this.lblCarWashFragrance.Name = "lblCarWashFragrance";
            this.lblCarWashFragrance.Size = new System.Drawing.Size(116, 25);
            this.lblCarWashFragrance.TabIndex = 3;
            this.lblCarWashFragrance.Text = "Fragrance:";
            // 
            // cboCarWashFragrance
            // 
            this.cboCarWashFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarWashFragrance.FormattingEnabled = true;
            this.cboCarWashFragrance.Location = new System.Drawing.Point(375, 142);
            this.cboCarWashFragrance.Name = "cboCarWashFragrance";
            this.cboCarWashFragrance.Size = new System.Drawing.Size(267, 33);
            this.cboCarWashFragrance.TabIndex = 1;
            // 
            // cboCarWashPackage
            // 
            this.cboCarWashPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarWashPackage.FormattingEnabled = true;
            this.cboCarWashPackage.Location = new System.Drawing.Point(54, 142);
            this.cboCarWashPackage.Name = "cboCarWashPackage";
            this.cboCarWashPackage.Size = new System.Drawing.Size(267, 33);
            this.cboCarWashPackage.TabIndex = 0;
            // 
            // grpCarWashSummary
            // 
            this.grpCarWashSummary.Controls.Add(this.lstCarWashSummaryInteriorBox);
            this.grpCarWashSummary.Controls.Add(this.lstCarWashSummaryExteriorBox);
            this.grpCarWashSummary.Controls.Add(this.lblCarWashSummaryExterior);
            this.grpCarWashSummary.Controls.Add(this.lblCarWashSummaryInterior);
            this.grpCarWashSummary.Location = new System.Drawing.Point(25, 210);
            this.grpCarWashSummary.Name = "grpCarWashSummary";
            this.grpCarWashSummary.Size = new System.Drawing.Size(676, 352);
            this.grpCarWashSummary.TabIndex = 5;
            this.grpCarWashSummary.TabStop = false;
            this.grpCarWashSummary.Text = "Summary";
            // 
            // lstCarWashSummaryInteriorBox
            // 
            this.lstCarWashSummaryInteriorBox.FormattingEnabled = true;
            this.lstCarWashSummaryInteriorBox.ItemHeight = 25;
            this.lstCarWashSummaryInteriorBox.Location = new System.Drawing.Point(20, 88);
            this.lstCarWashSummaryInteriorBox.Name = "lstCarWashSummaryInteriorBox";
            this.lstCarWashSummaryInteriorBox.Size = new System.Drawing.Size(289, 204);
            this.lstCarWashSummaryInteriorBox.TabIndex = 2;
            // 
            // lstCarWashSummaryExteriorBox
            // 
            this.lstCarWashSummaryExteriorBox.FormattingEnabled = true;
            this.lstCarWashSummaryExteriorBox.ItemHeight = 25;
            this.lstCarWashSummaryExteriorBox.Location = new System.Drawing.Point(350, 88);
            this.lstCarWashSummaryExteriorBox.Name = "lstCarWashSummaryExteriorBox";
            this.lstCarWashSummaryExteriorBox.Size = new System.Drawing.Size(289, 204);
            this.lstCarWashSummaryExteriorBox.TabIndex = 2;
            // 
            // lblCarWashSummaryExterior
            // 
            this.lblCarWashSummaryExterior.AutoSize = true;
            this.lblCarWashSummaryExterior.Location = new System.Drawing.Point(345, 56);
            this.lblCarWashSummaryExterior.Name = "lblCarWashSummaryExterior";
            this.lblCarWashSummaryExterior.Size = new System.Drawing.Size(92, 25);
            this.lblCarWashSummaryExterior.TabIndex = 1;
            this.lblCarWashSummaryExterior.Text = "Exterior:";
            // 
            // lblCarWashSummaryInterior
            // 
            this.lblCarWashSummaryInterior.AutoSize = true;
            this.lblCarWashSummaryInterior.Location = new System.Drawing.Point(15, 56);
            this.lblCarWashSummaryInterior.Name = "lblCarWashSummaryInterior";
            this.lblCarWashSummaryInterior.Size = new System.Drawing.Size(84, 25);
            this.lblCarWashSummaryInterior.TabIndex = 0;
            this.lblCarWashSummaryInterior.Text = "Interior:";
            // 
            // lblCarWashSubtotal
            // 
            this.lblCarWashSubtotal.AutoSize = true;
            this.lblCarWashSubtotal.Location = new System.Drawing.Point(397, 582);
            this.lblCarWashSubtotal.Name = "lblCarWashSubtotal";
            this.lblCarWashSubtotal.Size = new System.Drawing.Size(97, 25);
            this.lblCarWashSubtotal.TabIndex = 6;
            this.lblCarWashSubtotal.Text = "Subtotal:";
            // 
            // lblCarWashSubtotalOut
            // 
            this.lblCarWashSubtotalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashSubtotalOut.Location = new System.Drawing.Point(517, 581);
            this.lblCarWashSubtotalOut.Name = "lblCarWashSubtotalOut";
            this.lblCarWashSubtotalOut.Size = new System.Drawing.Size(182, 40);
            this.lblCarWashSubtotalOut.TabIndex = 7;
            this.lblCarWashSubtotalOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCarWashPST
            // 
            this.lblCarWashPST.AutoSize = true;
            this.lblCarWashPST.Location = new System.Drawing.Point(435, 639);
            this.lblCarWashPST.Name = "lblCarWashPST";
            this.lblCarWashPST.Size = new System.Drawing.Size(59, 25);
            this.lblCarWashPST.TabIndex = 8;
            this.lblCarWashPST.Text = "PST:";
            // 
            // lblCarWashPSTOut
            // 
            this.lblCarWashPSTOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashPSTOut.Location = new System.Drawing.Point(517, 638);
            this.lblCarWashPSTOut.Name = "lblCarWashPSTOut";
            this.lblCarWashPSTOut.Size = new System.Drawing.Size(182, 40);
            this.lblCarWashPSTOut.TabIndex = 9;
            this.lblCarWashPSTOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCarWashGST
            // 
            this.lblCarWashGST.AutoSize = true;
            this.lblCarWashGST.Location = new System.Drawing.Point(433, 700);
            this.lblCarWashGST.Name = "lblCarWashGST";
            this.lblCarWashGST.Size = new System.Drawing.Size(61, 25);
            this.lblCarWashGST.TabIndex = 10;
            this.lblCarWashGST.Text = "GST:";
            // 
            // lblCarWashGSTOut
            // 
            this.lblCarWashGSTOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashGSTOut.Location = new System.Drawing.Point(517, 699);
            this.lblCarWashGSTOut.Name = "lblCarWashGSTOut";
            this.lblCarWashGSTOut.Size = new System.Drawing.Size(182, 39);
            this.lblCarWashGSTOut.TabIndex = 11;
            this.lblCarWashGSTOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCarWashTotal
            // 
            this.lblCarWashTotal.AutoSize = true;
            this.lblCarWashTotal.Location = new System.Drawing.Point(428, 757);
            this.lblCarWashTotal.Name = "lblCarWashTotal";
            this.lblCarWashTotal.Size = new System.Drawing.Size(66, 25);
            this.lblCarWashTotal.TabIndex = 12;
            this.lblCarWashTotal.Text = "Total:";
            // 
            // lblCarWashTotalOut
            // 
            this.lblCarWashTotalOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCarWashTotalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarWashTotalOut.Location = new System.Drawing.Point(517, 756);
            this.lblCarWashTotalOut.Name = "lblCarWashTotalOut";
            this.lblCarWashTotalOut.Size = new System.Drawing.Size(182, 37);
            this.lblCarWashTotalOut.TabIndex = 13;
            this.lblCarWashTotalOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 852);
            this.Controls.Add(this.lblCarWashTotalOut);
            this.Controls.Add(this.lblCarWashTotal);
            this.Controls.Add(this.lblCarWashGSTOut);
            this.Controls.Add(this.lblCarWashGST);
            this.Controls.Add(this.lblCarWashPSTOut);
            this.Controls.Add(this.lblCarWashPST);
            this.Controls.Add(this.lblCarWashSubtotalOut);
            this.Controls.Add(this.lblCarWashSubtotal);
            this.Controls.Add(this.grpCarWashSummary);
            this.Controls.Add(this.cboCarWashPackage);
            this.Controls.Add(this.cboCarWashFragrance);
            this.Controls.Add(this.lblCarWashFragrance);
            this.Controls.Add(this.lblCarWashPackage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CarWashForm";
            this.ShowIcon = false;
            this.Text = "Car Wash";
            this.Load += new System.EventHandler(this.CarWashForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCarWashSummary.ResumeLayout(false);
            this.grpCarWashSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWashFile;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWashGenerateInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWashExit;
        private System.Windows.Forms.Label lblCarWashPackage;
        private System.Windows.Forms.Label lblCarWashFragrance;
        private System.Windows.Forms.ComboBox cboCarWashFragrance;
        private System.Windows.Forms.ComboBox cboCarWashPackage;
        private System.Windows.Forms.GroupBox grpCarWashSummary;
        private System.Windows.Forms.ListBox lstCarWashSummaryInteriorBox;
        private System.Windows.Forms.ListBox lstCarWashSummaryExteriorBox;
        private System.Windows.Forms.Label lblCarWashSummaryExterior;
        private System.Windows.Forms.Label lblCarWashSummaryInterior;
        private System.Windows.Forms.Label lblCarWashSubtotal;
        private System.Windows.Forms.Label lblCarWashSubtotalOut;
        private System.Windows.Forms.Label lblCarWashPST;
        private System.Windows.Forms.Label lblCarWashPSTOut;
        private System.Windows.Forms.Label lblCarWashGST;
        private System.Windows.Forms.Label lblCarWashGSTOut;
        private System.Windows.Forms.Label lblCarWashTotal;
        private System.Windows.Forms.Label lblCarWashTotalOut;
    }
}