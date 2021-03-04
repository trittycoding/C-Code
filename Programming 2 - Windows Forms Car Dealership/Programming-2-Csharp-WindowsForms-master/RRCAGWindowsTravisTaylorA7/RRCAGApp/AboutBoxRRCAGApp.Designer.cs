namespace RRCAGApp
{
    partial class AboutBoxRRCAGApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxRRCAGApp));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblAboutBoxRRCAuto = new System.Windows.Forms.Label();
            this.lblAboutBoxVersion = new System.Windows.Forms.Label();
            this.lblAboutBoxCopyright = new System.Windows.Forms.Label();
            this.lblAboutBoxName = new System.Windows.Forms.Label();
            this.txtAboutBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblAboutBoxRRCAuto, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblAboutBoxVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblAboutBoxCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblAboutBoxName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtAboutBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 17);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.54902F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(834, 510);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(6, 6);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(263, 498);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // lblAboutBoxRRCAuto
            // 
            this.lblAboutBoxRRCAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutBoxRRCAuto.Location = new System.Drawing.Point(287, 0);
            this.lblAboutBoxRRCAuto.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.lblAboutBoxRRCAuto.MaximumSize = new System.Drawing.Size(0, 33);
            this.lblAboutBoxRRCAuto.Name = "lblAboutBoxRRCAuto";
            this.lblAboutBoxRRCAuto.Size = new System.Drawing.Size(541, 33);
            this.lblAboutBoxRRCAuto.TabIndex = 19;
            this.lblAboutBoxRRCAuto.Text = "Automotive Management System";
            this.lblAboutBoxRRCAuto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAboutBoxVersion
            // 
            this.lblAboutBoxVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutBoxVersion.Location = new System.Drawing.Point(287, 51);
            this.lblAboutBoxVersion.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.lblAboutBoxVersion.MaximumSize = new System.Drawing.Size(0, 33);
            this.lblAboutBoxVersion.Name = "lblAboutBoxVersion";
            this.lblAboutBoxVersion.Size = new System.Drawing.Size(541, 33);
            this.lblAboutBoxVersion.TabIndex = 0;
            this.lblAboutBoxVersion.Text = "Version 1.0.0.0";
            this.lblAboutBoxVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAboutBoxCopyright
            // 
            this.lblAboutBoxCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutBoxCopyright.Location = new System.Drawing.Point(287, 102);
            this.lblAboutBoxCopyright.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.lblAboutBoxCopyright.MaximumSize = new System.Drawing.Size(0, 33);
            this.lblAboutBoxCopyright.Name = "lblAboutBoxCopyright";
            this.lblAboutBoxCopyright.Size = new System.Drawing.Size(541, 33);
            this.lblAboutBoxCopyright.TabIndex = 21;
            this.lblAboutBoxCopyright.Text = "Copyright © 2017";
            this.lblAboutBoxCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAboutBoxName
            // 
            this.lblAboutBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAboutBoxName.Location = new System.Drawing.Point(287, 153);
            this.lblAboutBoxName.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.lblAboutBoxName.MaximumSize = new System.Drawing.Size(0, 33);
            this.lblAboutBoxName.Name = "lblAboutBoxName";
            this.lblAboutBoxName.Size = new System.Drawing.Size(541, 33);
            this.lblAboutBoxName.TabIndex = 22;
            this.lblAboutBoxName.Text = "Travis Taylor";
            this.lblAboutBoxName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAboutBoxDescription
            // 
            this.txtAboutBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAboutBoxDescription.Location = new System.Drawing.Point(287, 223);
            this.txtAboutBoxDescription.Margin = new System.Windows.Forms.Padding(12, 6, 6, 6);
            this.txtAboutBoxDescription.Multiline = true;
            this.txtAboutBoxDescription.Name = "txtAboutBoxDescription";
            this.txtAboutBoxDescription.ReadOnly = true;
            this.txtAboutBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAboutBoxDescription.Size = new System.Drawing.Size(541, 228);
            this.txtAboutBoxDescription.TabIndex = 23;
            this.txtAboutBoxDescription.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(678, 465);
            this.okButton.Margin = new System.Windows.Forms.Padding(6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 39);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // AboutBoxRRCAGApp
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 544);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBoxRRCAGApp";
            this.Padding = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About RRC Automotive Group";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblAboutBoxRRCAuto;
        private System.Windows.Forms.Label lblAboutBoxVersion;
        private System.Windows.Forms.Label lblAboutBoxCopyright;
        private System.Windows.Forms.Label lblAboutBoxName;
        private System.Windows.Forms.TextBox txtAboutBoxDescription;
        private System.Windows.Forms.Button okButton;
    }
}
