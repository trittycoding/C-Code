namespace RRCAGApp
{
    partial class SalesQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.lblVSQVehicleSelection = new System.Windows.Forms.Label();
            this.lblVSQTradeInValue = new System.Windows.Forms.Label();
            this.txtVehicleSalesQuoteFormTradeInAmount = new System.Windows.Forms.TextBox();
            this.grpVSQAccessories = new System.Windows.Forms.GroupBox();
            this.chkVehicleSalesQuoteFormAccessoriesComputer = new System.Windows.Forms.CheckBox();
            this.chkVehicleSalesQuoteFormAccessoriesLeather = new System.Windows.Forms.CheckBox();
            this.chkVehicleSalesQuoteFormAccessoriesStereo = new System.Windows.Forms.CheckBox();
            this.grpVSQExterior = new System.Windows.Forms.GroupBox();
            this.radVehicleSalesQuoteFormExteriorCustom = new System.Windows.Forms.RadioButton();
            this.radVehicleSalesQuoteFormExteriorPearl = new System.Windows.Forms.RadioButton();
            this.radVehicleSalesQuoteFormExteriorStandard = new System.Windows.Forms.RadioButton();
            this.btnVehicleSalesQuoteFormReset = new System.Windows.Forms.Button();
            this.grpVSQSummary = new System.Windows.Forms.GroupBox();
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut = new System.Windows.Forms.Label();
            this.lblVehicleSalesQuoteFormSummaryTIAOut = new System.Windows.Forms.Label();
            this.lblVehicleSalesQuoteFormSummaryTotalOut = new System.Windows.Forms.Label();
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut = new System.Windows.Forms.Label();
            this.lblVehicleSalesQuoteFormSummarySubtotalOut = new System.Windows.Forms.Label();
            this.lblVehicleSalesQuoteFormSummaryOptionsOut = new System.Windows.Forms.Label();
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut = new System.Windows.Forms.Label();
            this.lblVSQSummaryAmountDue = new System.Windows.Forms.Label();
            this.lblVSQSummaryTIA = new System.Windows.Forms.Label();
            this.lblVSQSummaryTotal = new System.Windows.Forms.Label();
            this.lblVSQSummarySTR = new System.Windows.Forms.Label();
            this.lblVSQSummarySubtotal = new System.Windows.Forms.Label();
            this.lblVSQSummaryOptions = new System.Windows.Forms.Label();
            this.lblVSQSummaryVSP = new System.Windows.Forms.Label();
            this.grpVSQFinance = new System.Windows.Forms.GroupBox();
            this.lblVehicleSalesQuoteFormFinancePaymentOut = new System.Windows.Forms.Label();
            this.lblVSQFinancePayment = new System.Windows.Forms.Label();
            this.lblVSQFinanceInterest = new System.Windows.Forms.Label();
            this.nudVehicleSalesQuoteFormFinanceYears = new System.Windows.Forms.NumericUpDown();
            this.nudVehicleSalesQuoteFormFinanceInterest = new System.Windows.Forms.NumericUpDown();
            this.lblVSQFinanceYears = new System.Windows.Forms.Label();
            this.btnVehicleSalesQuoteFormCalculateQuote = new System.Windows.Forms.Button();
            this.errorProviderVehicleSalesQuoteForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuVehicleSalesQuoteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleSalesQuoteFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuvehicleSalesQuoteView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleSalesQuoteVehicleInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cboVehicleIDSelector = new System.Windows.Forms.ComboBox();
            this.grpVSQAccessories.SuspendLayout();
            this.grpVSQExterior.SuspendLayout();
            this.grpVSQSummary.SuspendLayout();
            this.grpVSQFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSalesQuoteFormFinanceYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSalesQuoteFormFinanceInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVehicleSalesQuoteForm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVSQVehicleSelection
            // 
            this.lblVSQVehicleSelection.AutoSize = true;
            this.lblVSQVehicleSelection.Location = new System.Drawing.Point(131, 53);
            this.lblVSQVehicleSelection.Name = "lblVSQVehicleSelection";
            this.lblVSQVehicleSelection.Size = new System.Drawing.Size(89, 25);
            this.lblVSQVehicleSelection.TabIndex = 1;
            this.lblVSQVehicleSelection.Text = "Vehicle:";
            // 
            // lblVSQTradeInValue
            // 
            this.lblVSQTradeInValue.AutoSize = true;
            this.lblVSQTradeInValue.Location = new System.Drawing.Point(61, 108);
            this.lblVSQTradeInValue.Name = "lblVSQTradeInValue";
            this.lblVSQTradeInValue.Size = new System.Drawing.Size(159, 25);
            this.lblVSQTradeInValue.TabIndex = 3;
            this.lblVSQTradeInValue.Text = "Trade-In Value:";
            // 
            // txtVehicleSalesQuoteFormTradeInAmount
            // 
            this.txtVehicleSalesQuoteFormTradeInAmount.Location = new System.Drawing.Point(243, 102);
            this.txtVehicleSalesQuoteFormTradeInAmount.Name = "txtVehicleSalesQuoteFormTradeInAmount";
            this.txtVehicleSalesQuoteFormTradeInAmount.Size = new System.Drawing.Size(220, 31);
            this.txtVehicleSalesQuoteFormTradeInAmount.TabIndex = 2;
            this.txtVehicleSalesQuoteFormTradeInAmount.Text = "0";
            this.txtVehicleSalesQuoteFormTradeInAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpVSQAccessories
            // 
            this.grpVSQAccessories.Controls.Add(this.chkVehicleSalesQuoteFormAccessoriesComputer);
            this.grpVSQAccessories.Controls.Add(this.chkVehicleSalesQuoteFormAccessoriesLeather);
            this.grpVSQAccessories.Controls.Add(this.chkVehicleSalesQuoteFormAccessoriesStereo);
            this.grpVSQAccessories.Location = new System.Drawing.Point(66, 158);
            this.grpVSQAccessories.Name = "grpVSQAccessories";
            this.grpVSQAccessories.Size = new System.Drawing.Size(429, 280);
            this.grpVSQAccessories.TabIndex = 3;
            this.grpVSQAccessories.TabStop = false;
            this.grpVSQAccessories.Text = "Accessories";
            // 
            // chkVehicleSalesQuoteFormAccessoriesComputer
            // 
            this.chkVehicleSalesQuoteFormAccessoriesComputer.AutoSize = true;
            this.chkVehicleSalesQuoteFormAccessoriesComputer.Location = new System.Drawing.Point(43, 210);
            this.chkVehicleSalesQuoteFormAccessoriesComputer.Name = "chkVehicleSalesQuoteFormAccessoriesComputer";
            this.chkVehicleSalesQuoteFormAccessoriesComputer.Size = new System.Drawing.Size(245, 29);
            this.chkVehicleSalesQuoteFormAccessoriesComputer.TabIndex = 2;
            this.chkVehicleSalesQuoteFormAccessoriesComputer.Text = "Computer Navigation";
            this.chkVehicleSalesQuoteFormAccessoriesComputer.UseVisualStyleBackColor = true;
            // 
            // chkVehicleSalesQuoteFormAccessoriesLeather
            // 
            this.chkVehicleSalesQuoteFormAccessoriesLeather.AutoSize = true;
            this.chkVehicleSalesQuoteFormAccessoriesLeather.Location = new System.Drawing.Point(43, 136);
            this.chkVehicleSalesQuoteFormAccessoriesLeather.Name = "chkVehicleSalesQuoteFormAccessoriesLeather";
            this.chkVehicleSalesQuoteFormAccessoriesLeather.Size = new System.Drawing.Size(189, 29);
            this.chkVehicleSalesQuoteFormAccessoriesLeather.TabIndex = 1;
            this.chkVehicleSalesQuoteFormAccessoriesLeather.Text = "Leather Interior";
            this.chkVehicleSalesQuoteFormAccessoriesLeather.UseVisualStyleBackColor = true;
            // 
            // chkVehicleSalesQuoteFormAccessoriesStereo
            // 
            this.chkVehicleSalesQuoteFormAccessoriesStereo.AutoSize = true;
            this.chkVehicleSalesQuoteFormAccessoriesStereo.Location = new System.Drawing.Point(43, 61);
            this.chkVehicleSalesQuoteFormAccessoriesStereo.Name = "chkVehicleSalesQuoteFormAccessoriesStereo";
            this.chkVehicleSalesQuoteFormAccessoriesStereo.Size = new System.Drawing.Size(184, 29);
            this.chkVehicleSalesQuoteFormAccessoriesStereo.TabIndex = 0;
            this.chkVehicleSalesQuoteFormAccessoriesStereo.Text = "Stereo System";
            this.chkVehicleSalesQuoteFormAccessoriesStereo.UseVisualStyleBackColor = true;
            // 
            // grpVSQExterior
            // 
            this.grpVSQExterior.Controls.Add(this.radVehicleSalesQuoteFormExteriorCustom);
            this.grpVSQExterior.Controls.Add(this.radVehicleSalesQuoteFormExteriorPearl);
            this.grpVSQExterior.Controls.Add(this.radVehicleSalesQuoteFormExteriorStandard);
            this.grpVSQExterior.Location = new System.Drawing.Point(66, 470);
            this.grpVSQExterior.Name = "grpVSQExterior";
            this.grpVSQExterior.Size = new System.Drawing.Size(429, 284);
            this.grpVSQExterior.TabIndex = 4;
            this.grpVSQExterior.TabStop = false;
            this.grpVSQExterior.Text = "Exterior Finish";
            // 
            // radVehicleSalesQuoteFormExteriorCustom
            // 
            this.radVehicleSalesQuoteFormExteriorCustom.AutoSize = true;
            this.radVehicleSalesQuoteFormExteriorCustom.Location = new System.Drawing.Point(43, 207);
            this.radVehicleSalesQuoteFormExteriorCustom.Name = "radVehicleSalesQuoteFormExteriorCustom";
            this.radVehicleSalesQuoteFormExteriorCustom.Size = new System.Drawing.Size(246, 29);
            this.radVehicleSalesQuoteFormExteriorCustom.TabIndex = 2;
            this.radVehicleSalesQuoteFormExteriorCustom.Text = "Customized Detailing";
            this.radVehicleSalesQuoteFormExteriorCustom.UseVisualStyleBackColor = true;
            // 
            // radVehicleSalesQuoteFormExteriorPearl
            // 
            this.radVehicleSalesQuoteFormExteriorPearl.AutoSize = true;
            this.radVehicleSalesQuoteFormExteriorPearl.Location = new System.Drawing.Point(43, 138);
            this.radVehicleSalesQuoteFormExteriorPearl.Name = "radVehicleSalesQuoteFormExteriorPearl";
            this.radVehicleSalesQuoteFormExteriorPearl.Size = new System.Drawing.Size(133, 29);
            this.radVehicleSalesQuoteFormExteriorPearl.TabIndex = 1;
            this.radVehicleSalesQuoteFormExteriorPearl.Text = "Pearlized";
            this.radVehicleSalesQuoteFormExteriorPearl.UseVisualStyleBackColor = true;
            // 
            // radVehicleSalesQuoteFormExteriorStandard
            // 
            this.radVehicleSalesQuoteFormExteriorStandard.AutoSize = true;
            this.radVehicleSalesQuoteFormExteriorStandard.Checked = true;
            this.radVehicleSalesQuoteFormExteriorStandard.Location = new System.Drawing.Point(44, 69);
            this.radVehicleSalesQuoteFormExteriorStandard.Name = "radVehicleSalesQuoteFormExteriorStandard";
            this.radVehicleSalesQuoteFormExteriorStandard.Size = new System.Drawing.Size(130, 29);
            this.radVehicleSalesQuoteFormExteriorStandard.TabIndex = 0;
            this.radVehicleSalesQuoteFormExteriorStandard.TabStop = true;
            this.radVehicleSalesQuoteFormExteriorStandard.Text = "Standard";
            this.radVehicleSalesQuoteFormExteriorStandard.UseVisualStyleBackColor = true;
            // 
            // btnVehicleSalesQuoteFormReset
            // 
            this.btnVehicleSalesQuoteFormReset.Location = new System.Drawing.Point(66, 790);
            this.btnVehicleSalesQuoteFormReset.Name = "btnVehicleSalesQuoteFormReset";
            this.btnVehicleSalesQuoteFormReset.Size = new System.Drawing.Size(154, 61);
            this.btnVehicleSalesQuoteFormReset.TabIndex = 7;
            this.btnVehicleSalesQuoteFormReset.Text = "Reset";
            this.btnVehicleSalesQuoteFormReset.UseVisualStyleBackColor = true;
            // 
            // grpVSQSummary
            // 
            this.grpVSQSummary.Controls.Add(this.lblVehicleSalesQuoteFormSummaryAmountDueOut);
            this.grpVSQSummary.Controls.Add(this.lblVehicleSalesQuoteFormSummaryTIAOut);
            this.grpVSQSummary.Controls.Add(this.lblVehicleSalesQuoteFormSummaryTotalOut);
            this.grpVSQSummary.Controls.Add(this.lblVehicleSalesQuoteFormSummarySalesTaxOut);
            this.grpVSQSummary.Controls.Add(this.lblVehicleSalesQuoteFormSummarySubtotalOut);
            this.grpVSQSummary.Controls.Add(this.lblVehicleSalesQuoteFormSummaryOptionsOut);
            this.grpVSQSummary.Controls.Add(this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut);
            this.grpVSQSummary.Controls.Add(this.lblVSQSummaryAmountDue);
            this.grpVSQSummary.Controls.Add(this.lblVSQSummaryTIA);
            this.grpVSQSummary.Controls.Add(this.lblVSQSummaryTotal);
            this.grpVSQSummary.Controls.Add(this.lblVSQSummarySTR);
            this.grpVSQSummary.Controls.Add(this.lblVSQSummarySubtotal);
            this.grpVSQSummary.Controls.Add(this.lblVSQSummaryOptions);
            this.grpVSQSummary.Controls.Add(this.lblVSQSummaryVSP);
            this.grpVSQSummary.Location = new System.Drawing.Point(561, 24);
            this.grpVSQSummary.Name = "grpVSQSummary";
            this.grpVSQSummary.Size = new System.Drawing.Size(654, 544);
            this.grpVSQSummary.TabIndex = 8;
            this.grpVSQSummary.TabStop = false;
            this.grpVSQSummary.Text = "Summary";
            // 
            // lblVehicleSalesQuoteFormSummaryAmountDueOut
            // 
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.Location = new System.Drawing.Point(263, 472);
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.MinimumSize = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.Name = "lblVehicleSalesQuoteFormSummaryAmountDueOut";
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.Size = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.TabIndex = 20;
            this.lblVehicleSalesQuoteFormSummaryAmountDueOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicleSalesQuoteFormSummaryTIAOut
            // 
            this.lblVehicleSalesQuoteFormSummaryTIAOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormSummaryTIAOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormSummaryTIAOut.Location = new System.Drawing.Point(263, 402);
            this.lblVehicleSalesQuoteFormSummaryTIAOut.MinimumSize = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryTIAOut.Name = "lblVehicleSalesQuoteFormSummaryTIAOut";
            this.lblVehicleSalesQuoteFormSummaryTIAOut.Size = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryTIAOut.TabIndex = 19;
            this.lblVehicleSalesQuoteFormSummaryTIAOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicleSalesQuoteFormSummaryTotalOut
            // 
            this.lblVehicleSalesQuoteFormSummaryTotalOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormSummaryTotalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormSummaryTotalOut.Location = new System.Drawing.Point(263, 342);
            this.lblVehicleSalesQuoteFormSummaryTotalOut.MinimumSize = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryTotalOut.Name = "lblVehicleSalesQuoteFormSummaryTotalOut";
            this.lblVehicleSalesQuoteFormSummaryTotalOut.Size = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryTotalOut.TabIndex = 18;
            this.lblVehicleSalesQuoteFormSummaryTotalOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicleSalesQuoteFormSummarySalesTaxOut
            // 
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.Location = new System.Drawing.Point(263, 271);
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.MinimumSize = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.Name = "lblVehicleSalesQuoteFormSummarySalesTaxOut";
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.Size = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.TabIndex = 17;
            this.lblVehicleSalesQuoteFormSummarySalesTaxOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicleSalesQuoteFormSummarySubtotalOut
            // 
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.Location = new System.Drawing.Point(263, 206);
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.MinimumSize = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.Name = "lblVehicleSalesQuoteFormSummarySubtotalOut";
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.Size = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.TabIndex = 16;
            this.lblVehicleSalesQuoteFormSummarySubtotalOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicleSalesQuoteFormSummaryOptionsOut
            // 
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.Location = new System.Drawing.Point(263, 138);
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.MinimumSize = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.Name = "lblVehicleSalesQuoteFormSummaryOptionsOut";
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.Size = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.TabIndex = 15;
            this.lblVehicleSalesQuoteFormSummaryOptionsOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut
            // 
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.Location = new System.Drawing.Point(263, 63);
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.MinimumSize = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.Name = "lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut";
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.Size = new System.Drawing.Size(350, 31);
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.TabIndex = 14;
            this.lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVSQSummaryAmountDue
            // 
            this.lblVSQSummaryAmountDue.AutoSize = true;
            this.lblVSQSummaryAmountDue.Location = new System.Drawing.Point(104, 478);
            this.lblVSQSummaryAmountDue.Name = "lblVSQSummaryAmountDue";
            this.lblVSQSummaryAmountDue.Size = new System.Drawing.Size(136, 25);
            this.lblVSQSummaryAmountDue.TabIndex = 13;
            this.lblVSQSummaryAmountDue.Text = "Amount Due:";
            // 
            // lblVSQSummaryTIA
            // 
            this.lblVSQSummaryTIA.AutoSize = true;
            this.lblVSQSummaryTIA.Location = new System.Drawing.Point(63, 408);
            this.lblVSQSummaryTIA.Name = "lblVSQSummaryTIA";
            this.lblVSQSummaryTIA.Size = new System.Drawing.Size(177, 25);
            this.lblVSQSummaryTIA.TabIndex = 11;
            this.lblVSQSummaryTIA.Text = "Trade-In Amount:";
            // 
            // lblVSQSummaryTotal
            // 
            this.lblVSQSummaryTotal.AutoSize = true;
            this.lblVSQSummaryTotal.Location = new System.Drawing.Point(169, 344);
            this.lblVSQSummaryTotal.Name = "lblVSQSummaryTotal";
            this.lblVSQSummaryTotal.Size = new System.Drawing.Size(66, 25);
            this.lblVSQSummaryTotal.TabIndex = 9;
            this.lblVSQSummaryTotal.Text = "Total:";
            // 
            // lblVSQSummarySTR
            // 
            this.lblVSQSummarySTR.AutoSize = true;
            this.lblVSQSummarySTR.Location = new System.Drawing.Point(63, 274);
            this.lblVSQSummarySTR.Name = "lblVSQSummarySTR";
            this.lblVSQSummarySTR.Size = new System.Drawing.Size(177, 25);
            this.lblVSQSummarySTR.TabIndex = 7;
            this.lblVSQSummarySTR.Text = "Sales Tax (13%):";
            // 
            // lblVSQSummarySubtotal
            // 
            this.lblVSQSummarySubtotal.AutoSize = true;
            this.lblVSQSummarySubtotal.Location = new System.Drawing.Point(143, 212);
            this.lblVSQSummarySubtotal.Name = "lblVSQSummarySubtotal";
            this.lblVSQSummarySubtotal.Size = new System.Drawing.Size(97, 25);
            this.lblVSQSummarySubtotal.TabIndex = 5;
            this.lblVSQSummarySubtotal.Text = "Subtotal:";
            // 
            // lblVSQSummaryOptions
            // 
            this.lblVSQSummaryOptions.AutoSize = true;
            this.lblVSQSummaryOptions.Location = new System.Drawing.Point(143, 144);
            this.lblVSQSummaryOptions.Name = "lblVSQSummaryOptions";
            this.lblVSQSummaryOptions.Size = new System.Drawing.Size(92, 25);
            this.lblVSQSummaryOptions.TabIndex = 3;
            this.lblVSQSummaryOptions.Text = "Options:";
            // 
            // lblVSQSummaryVSP
            // 
            this.lblVSQSummaryVSP.AutoSize = true;
            this.lblVSQSummaryVSP.Location = new System.Drawing.Point(27, 69);
            this.lblVSQSummaryVSP.Name = "lblVSQSummaryVSP";
            this.lblVSQSummaryVSP.Size = new System.Drawing.Size(208, 25);
            this.lblVSQSummaryVSP.TabIndex = 1;
            this.lblVSQSummaryVSP.Text = "Vehicle\'s Sale Price:";
            // 
            // grpVSQFinance
            // 
            this.grpVSQFinance.Controls.Add(this.lblVehicleSalesQuoteFormFinancePaymentOut);
            this.grpVSQFinance.Controls.Add(this.lblVSQFinancePayment);
            this.grpVSQFinance.Controls.Add(this.lblVSQFinanceInterest);
            this.grpVSQFinance.Controls.Add(this.nudVehicleSalesQuoteFormFinanceYears);
            this.grpVSQFinance.Controls.Add(this.nudVehicleSalesQuoteFormFinanceInterest);
            this.grpVSQFinance.Controls.Add(this.lblVSQFinanceYears);
            this.grpVSQFinance.Location = new System.Drawing.Point(561, 584);
            this.grpVSQFinance.Name = "grpVSQFinance";
            this.grpVSQFinance.Size = new System.Drawing.Size(654, 170);
            this.grpVSQFinance.TabIndex = 5;
            this.grpVSQFinance.TabStop = false;
            this.grpVSQFinance.Text = "Finance";
            // 
            // lblVehicleSalesQuoteFormFinancePaymentOut
            // 
            this.lblVehicleSalesQuoteFormFinancePaymentOut.AutoSize = true;
            this.lblVehicleSalesQuoteFormFinancePaymentOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblVehicleSalesQuoteFormFinancePaymentOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalesQuoteFormFinancePaymentOut.Location = new System.Drawing.Point(432, 91);
            this.lblVehicleSalesQuoteFormFinancePaymentOut.MinimumSize = new System.Drawing.Size(160, 31);
            this.lblVehicleSalesQuoteFormFinancePaymentOut.Name = "lblVehicleSalesQuoteFormFinancePaymentOut";
            this.lblVehicleSalesQuoteFormFinancePaymentOut.Size = new System.Drawing.Size(160, 31);
            this.lblVehicleSalesQuoteFormFinancePaymentOut.TabIndex = 5;
            // 
            // lblVSQFinancePayment
            // 
            this.lblVSQFinancePayment.AutoSize = true;
            this.lblVSQFinancePayment.Location = new System.Drawing.Point(417, 54);
            this.lblVSQFinancePayment.Name = "lblVSQFinancePayment";
            this.lblVSQFinancePayment.Size = new System.Drawing.Size(184, 25);
            this.lblVSQFinancePayment.TabIndex = 4;
            this.lblVSQFinancePayment.Text = "Monthly Payment:";
            // 
            // lblVSQFinanceInterest
            // 
            this.lblVSQFinanceInterest.AutoSize = true;
            this.lblVSQFinanceInterest.Location = new System.Drawing.Point(232, 29);
            this.lblVSQFinanceInterest.Name = "lblVSQFinanceInterest";
            this.lblVSQFinanceInterest.Size = new System.Drawing.Size(140, 50);
            this.lblVSQFinanceInterest.TabIndex = 2;
            this.lblVSQFinanceInterest.Text = "Annual \r\nInterest Rate:";
            // 
            // nudVehicleSalesQuoteFormFinanceYears
            // 
            this.nudVehicleSalesQuoteFormFinanceYears.Location = new System.Drawing.Point(32, 93);
            this.nudVehicleSalesQuoteFormFinanceYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVehicleSalesQuoteFormFinanceYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVehicleSalesQuoteFormFinanceYears.Name = "nudVehicleSalesQuoteFormFinanceYears";
            this.nudVehicleSalesQuoteFormFinanceYears.Size = new System.Drawing.Size(120, 31);
            this.nudVehicleSalesQuoteFormFinanceYears.TabIndex = 1;
            this.nudVehicleSalesQuoteFormFinanceYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudVehicleSalesQuoteFormFinanceInterest
            // 
            this.nudVehicleSalesQuoteFormFinanceInterest.DecimalPlaces = 2;
            this.nudVehicleSalesQuoteFormFinanceInterest.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudVehicleSalesQuoteFormFinanceInterest.Location = new System.Drawing.Point(237, 93);
            this.nudVehicleSalesQuoteFormFinanceInterest.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            65536});
            this.nudVehicleSalesQuoteFormFinanceInterest.Name = "nudVehicleSalesQuoteFormFinanceInterest";
            this.nudVehicleSalesQuoteFormFinanceInterest.Size = new System.Drawing.Size(120, 31);
            this.nudVehicleSalesQuoteFormFinanceInterest.TabIndex = 3;
            this.nudVehicleSalesQuoteFormFinanceInterest.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            // 
            // lblVSQFinanceYears
            // 
            this.lblVSQFinanceYears.AutoSize = true;
            this.lblVSQFinanceYears.Location = new System.Drawing.Point(27, 54);
            this.lblVSQFinanceYears.Name = "lblVSQFinanceYears";
            this.lblVSQFinanceYears.Size = new System.Drawing.Size(142, 25);
            this.lblVSQFinanceYears.TabIndex = 0;
            this.lblVSQFinanceYears.Text = "No. Of Years:";
            // 
            // btnVehicleSalesQuoteFormCalculateQuote
            // 
            this.btnVehicleSalesQuoteFormCalculateQuote.BackColor = System.Drawing.SystemColors.Control;
            this.btnVehicleSalesQuoteFormCalculateQuote.Location = new System.Drawing.Point(993, 791);
            this.btnVehicleSalesQuoteFormCalculateQuote.Name = "btnVehicleSalesQuoteFormCalculateQuote";
            this.btnVehicleSalesQuoteFormCalculateQuote.Size = new System.Drawing.Size(226, 60);
            this.btnVehicleSalesQuoteFormCalculateQuote.TabIndex = 6;
            this.btnVehicleSalesQuoteFormCalculateQuote.Text = "Calculate Quote";
            this.btnVehicleSalesQuoteFormCalculateQuote.UseVisualStyleBackColor = false;
            this.btnVehicleSalesQuoteFormCalculateQuote.Click += new System.EventHandler(this.BtnVehicleSalesQuoteFormCalculateQuote_Click);
            // 
            // errorProviderVehicleSalesQuoteForm
            // 
            this.errorProviderVehicleSalesQuoteForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderVehicleSalesQuoteForm.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleSalesQuoteFile,
            this.mnuvehicleSalesQuoteView});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 40);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuVehicleSalesQuoteFile
            // 
            this.mnuVehicleSalesQuoteFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleSalesQuoteFileClose});
            this.mnuVehicleSalesQuoteFile.Name = "mnuVehicleSalesQuoteFile";
            this.mnuVehicleSalesQuoteFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mnuVehicleSalesQuoteFile.Size = new System.Drawing.Size(64, 36);
            this.mnuVehicleSalesQuoteFile.Text = "&File";
            // 
            // mnuVehicleSalesQuoteFileClose
            // 
            this.mnuVehicleSalesQuoteFileClose.Name = "mnuVehicleSalesQuoteFileClose";
            this.mnuVehicleSalesQuoteFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuVehicleSalesQuoteFileClose.Size = new System.Drawing.Size(262, 38);
            this.mnuVehicleSalesQuoteFileClose.Text = "&Close";
            // 
            // mnuvehicleSalesQuoteView
            // 
            this.mnuvehicleSalesQuoteView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleSalesQuoteVehicleInfo});
            this.mnuvehicleSalesQuoteView.Name = "mnuvehicleSalesQuoteView";
            this.mnuvehicleSalesQuoteView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.mnuvehicleSalesQuoteView.Size = new System.Drawing.Size(78, 36);
            this.mnuvehicleSalesQuoteView.Text = "&View";
            // 
            // mnuVehicleSalesQuoteVehicleInfo
            // 
            this.mnuVehicleSalesQuoteVehicleInfo.Name = "mnuVehicleSalesQuoteVehicleInfo";
            this.mnuVehicleSalesQuoteVehicleInfo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuVehicleSalesQuoteVehicleInfo.Size = new System.Drawing.Size(476, 38);
            this.mnuVehicleSalesQuoteVehicleInfo.Text = "Vehicle &Information...";
            // 
            // cboVehicleIDSelector
            // 
            this.cboVehicleIDSelector.BackColor = System.Drawing.SystemColors.Window;
            this.cboVehicleIDSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleIDSelector.FormattingEnabled = true;
            this.cboVehicleIDSelector.Location = new System.Drawing.Point(246, 53);
            this.cboVehicleIDSelector.Name = "cboVehicleIDSelector";
            this.cboVehicleIDSelector.Size = new System.Drawing.Size(217, 33);
            this.cboVehicleIDSelector.TabIndex = 10;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnVehicleSalesQuoteFormCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 894);
            this.Controls.Add(this.cboVehicleIDSelector);
            this.Controls.Add(this.btnVehicleSalesQuoteFormCalculateQuote);
            this.Controls.Add(this.grpVSQFinance);
            this.Controls.Add(this.grpVSQSummary);
            this.Controls.Add(this.btnVehicleSalesQuoteFormReset);
            this.Controls.Add(this.grpVSQExterior);
            this.Controls.Add(this.grpVSQAccessories);
            this.Controls.Add(this.txtVehicleSalesQuoteFormTradeInAmount);
            this.Controls.Add(this.lblVSQTradeInValue);
            this.Controls.Add(this.lblVSQVehicleSelection);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle Sales Quote";
            this.Load += new System.EventHandler(this.SalesQuoteForm_Load);
            this.grpVSQAccessories.ResumeLayout(false);
            this.grpVSQAccessories.PerformLayout();
            this.grpVSQExterior.ResumeLayout(false);
            this.grpVSQExterior.PerformLayout();
            this.grpVSQSummary.ResumeLayout(false);
            this.grpVSQSummary.PerformLayout();
            this.grpVSQFinance.ResumeLayout(false);
            this.grpVSQFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSalesQuoteFormFinanceYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleSalesQuoteFormFinanceInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVehicleSalesQuoteForm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVSQVehicleSelection;
        private System.Windows.Forms.Label lblVSQTradeInValue;
        private System.Windows.Forms.TextBox txtVehicleSalesQuoteFormTradeInAmount;
        private System.Windows.Forms.GroupBox grpVSQAccessories;
        private System.Windows.Forms.CheckBox chkVehicleSalesQuoteFormAccessoriesComputer;
        private System.Windows.Forms.CheckBox chkVehicleSalesQuoteFormAccessoriesLeather;
        private System.Windows.Forms.CheckBox chkVehicleSalesQuoteFormAccessoriesStereo;
        private System.Windows.Forms.GroupBox grpVSQExterior;
        private System.Windows.Forms.RadioButton radVehicleSalesQuoteFormExteriorCustom;
        private System.Windows.Forms.RadioButton radVehicleSalesQuoteFormExteriorPearl;
        private System.Windows.Forms.RadioButton radVehicleSalesQuoteFormExteriorStandard;
        private System.Windows.Forms.Button btnVehicleSalesQuoteFormReset;
        private System.Windows.Forms.GroupBox grpVSQSummary;
        private System.Windows.Forms.Label lblVSQSummaryVSP;
        private System.Windows.Forms.GroupBox grpVSQFinance;
        private System.Windows.Forms.Button btnVehicleSalesQuoteFormCalculateQuote;
        private System.Windows.Forms.Label lblVSQSummarySTR;
        private System.Windows.Forms.Label lblVSQSummarySubtotal;
        private System.Windows.Forms.Label lblVSQSummaryOptions;
        private System.Windows.Forms.Label lblVSQSummaryAmountDue;
        private System.Windows.Forms.Label lblVSQSummaryTIA;
        private System.Windows.Forms.Label lblVSQSummaryTotal;
        private System.Windows.Forms.Label lblVSQFinanceYears;
        private System.Windows.Forms.Label lblVSQFinancePayment;
        private System.Windows.Forms.Label lblVSQFinanceInterest;
        private System.Windows.Forms.NumericUpDown nudVehicleSalesQuoteFormFinanceYears;
        private System.Windows.Forms.NumericUpDown nudVehicleSalesQuoteFormFinanceInterest;
        private System.Windows.Forms.ErrorProvider errorProviderVehicleSalesQuoteForm;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormSummaryAmountDueOut;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormSummaryTIAOut;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormSummaryTotalOut;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormSummarySalesTaxOut;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormSummarySubtotalOut;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormSummaryOptionsOut;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut;
        private System.Windows.Forms.Label lblVehicleSalesQuoteFormFinancePaymentOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleSalesQuoteFile;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleSalesQuoteFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuvehicleSalesQuoteView;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleSalesQuoteVehicleInfo;
        private System.Windows.Forms.ComboBox cboVehicleIDSelector;
    }
}