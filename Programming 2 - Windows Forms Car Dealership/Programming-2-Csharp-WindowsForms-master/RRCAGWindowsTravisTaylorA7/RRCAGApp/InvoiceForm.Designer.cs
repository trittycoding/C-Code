namespace RRCAGApp
{
    partial class InvoiceForm
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
            this.lblInvoiceCompany = new System.Windows.Forms.Label();
            this.lblInvoiceAddress = new System.Windows.Forms.Label();
            this.lblInvoiceMailing = new System.Windows.Forms.Label();
            this.lblInvoicePhone = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceDateOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInvoiceCompany
            // 
            this.lblInvoiceCompany.AutoSize = true;
            this.lblInvoiceCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceCompany.Location = new System.Drawing.Point(29, 28);
            this.lblInvoiceCompany.Name = "lblInvoiceCompany";
            this.lblInvoiceCompany.Size = new System.Drawing.Size(593, 63);
            this.lblInvoiceCompany.TabIndex = 0;
            this.lblInvoiceCompany.Text = "RRC Automotive Group";
            // 
            // lblInvoiceAddress
            // 
            this.lblInvoiceAddress.AutoSize = true;
            this.lblInvoiceAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceAddress.Location = new System.Drawing.Point(35, 117);
            this.lblInvoiceAddress.Name = "lblInvoiceAddress";
            this.lblInvoiceAddress.Size = new System.Drawing.Size(238, 29);
            this.lblInvoiceAddress.TabIndex = 1;
            this.lblInvoiceAddress.Text = "777 Inheritance Drive";
            // 
            // lblInvoiceMailing
            // 
            this.lblInvoiceMailing.AutoSize = true;
            this.lblInvoiceMailing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceMailing.Location = new System.Drawing.Point(35, 170);
            this.lblInvoiceMailing.Name = "lblInvoiceMailing";
            this.lblInvoiceMailing.Size = new System.Drawing.Size(232, 29);
            this.lblInvoiceMailing.TabIndex = 2;
            this.lblInvoiceMailing.Text = "Winnipeg, MB I0I 0I0";
            // 
            // lblInvoicePhone
            // 
            this.lblInvoicePhone.AutoSize = true;
            this.lblInvoicePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoicePhone.Location = new System.Drawing.Point(35, 226);
            this.lblInvoicePhone.Name = "lblInvoicePhone";
            this.lblInvoicePhone.Size = new System.Drawing.Size(159, 29);
            this.lblInvoicePhone.TabIndex = 3;
            this.lblInvoicePhone.Text = "204-867-5309";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(32, 302);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(277, 51);
            this.lblInvoiceTitle.TabIndex = 4;
            this.lblInvoiceTitle.Text = "[Invoice Title]";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(1171, 38);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(63, 25);
            this.lblInvoiceDate.TabIndex = 5;
            this.lblInvoiceDate.Text = "Date:";
            // 
            // lblInvoiceDateOut
            // 
            this.lblInvoiceDateOut.AutoSize = true;
            this.lblInvoiceDateOut.Location = new System.Drawing.Point(1289, 38);
            this.lblInvoiceDateOut.Name = "lblInvoiceDateOut";
            this.lblInvoiceDateOut.Size = new System.Drawing.Size(69, 25);
            this.lblInvoiceDateOut.TabIndex = 6;
            this.lblInvoiceDateOut.Text = "[Date]";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1526, 878);
            this.Controls.Add(this.lblInvoiceDateOut);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceTitle);
            this.Controls.Add(this.lblInvoicePhone);
            this.Controls.Add(this.lblInvoiceMailing);
            this.Controls.Add(this.lblInvoiceAddress);
            this.Controls.Add(this.lblInvoiceCompany);
            this.Name = "InvoiceForm";
            this.ShowIcon = false;
            this.Text = "[Form Title]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceCompany;
        private System.Windows.Forms.Label lblInvoiceAddress;
        private System.Windows.Forms.Label lblInvoiceMailing;
        private System.Windows.Forms.Label lblInvoicePhone;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDateOut;
    }
}