using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taylor.Travis.Business;
using RRCAG.Data;
using System.Data.OleDb;

namespace RRCAGApp
{ 
    /// <summary>
    /// Form that performs the action of generating a sales quote for a vehicle, including financing information.
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        private SalesQuote new1;
        BindingSource bindVehicleSelector;
        DataSet dataSet;

        /// <summary>
        /// Initializes a SalesQuoteForm object and sets the state of that SalesQuoteForm object.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();
            cboVehicleIDSelector.Focus();
            btnVehicleSalesQuoteFormCalculateQuote.Click += BtnVehicleSalesQuoteFormCalculateQuote_Click;
            this.nudVehicleSalesQuoteFormFinanceYears.ValueChanged += NudVehicleSalesQuoteFormFinanceInterestOrYears_ValueChanged;
            this.nudVehicleSalesQuoteFormFinanceInterest.ValueChanged += NudVehicleSalesQuoteFormFinanceInterestOrYears_ValueChanged;
            this.chkVehicleSalesQuoteFormAccessoriesComputer.CheckedChanged += AccessoriesOrRadio_CheckedChanged;
            this.chkVehicleSalesQuoteFormAccessoriesLeather.CheckedChanged += AccessoriesOrRadio_CheckedChanged;
            this.chkVehicleSalesQuoteFormAccessoriesStereo.CheckedChanged += AccessoriesOrRadio_CheckedChanged;
            this.radVehicleSalesQuoteFormExteriorCustom.CheckedChanged += AccessoriesOrRadio_CheckedChanged;
            this.radVehicleSalesQuoteFormExteriorPearl.CheckedChanged += AccessoriesOrRadio_CheckedChanged;
            this.radVehicleSalesQuoteFormExteriorStandard.CheckedChanged += AccessoriesOrRadio_CheckedChanged;
            this.btnVehicleSalesQuoteFormReset.Click += BtnVehicleSalesQuoteFormReset_Click;
            this.txtVehicleSalesQuoteFormTradeInAmount.TextChanged += VehicleSalesQuoteFormTextbox_TextChanged;
            this.errorProviderVehicleSalesQuoteForm.SetIconPadding(this.cboVehicleIDSelector, 3);
            this.errorProviderVehicleSalesQuoteForm.SetIconPadding(this.txtVehicleSalesQuoteFormTradeInAmount, 3);
            this.mnuVehicleSalesQuoteFileClose.Click += VehicleSalesQuoteMenuFileClose_Click;
            this.cboVehicleIDSelector.SelectedIndexChanged += CboVehicleIDSelector_SelectedIndexChanged;
            this.mnuVehicleSalesQuoteVehicleInfo.Click += MnuVehicleSalesQuoteVehicleInfo_Click;
        }

        /// <summary>
        /// 
        /// </summary>
        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormLoad();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method called when the vehicle info selection on the main menu is clicked. Creates an instance of a 
        /// vehicle information form.
        /// </summary>
        private void MnuVehicleSalesQuoteVehicleInfo_Click(object sender, EventArgs e)
        {

            VehicleInformationForm vehicleInfoForm = new VehicleInformationForm(bindVehicleSelector);
            vehicleInfoForm.ShowDialog();
        }

        /// <summary>
        /// Method called when the combobox's index changes. Resets the summary and payment fields on the form.
        /// </summary>
        private void CboVehicleIDSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
                ResetSummaryAndPaymentFields();
                mnuVehicleSalesQuoteVehicleInfo.Enabled = true;
        }

        /// <summary>
        /// Method called when the close selection on the menu is clicked. Closes the form.
        /// </summary>
        private void VehicleSalesQuoteMenuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method called when the vehicle sale price textbox or trade-in amount textbox are changed. The summary and payment fields are reset and 
        /// the SalesQuoteForm object is set to null.
        /// </summary>
        private void VehicleSalesQuoteFormTextbox_TextChanged(object sender, EventArgs e)
        {
            ResetSummaryAndPaymentFields();
            new1 = null;
        }

        /// <summary>
        /// Method called when the accessories checkboxes or exterior finish radio buttons are changed. If the SalesQuoteForm
        /// object is not null, a new quote is generated. The summary and financing labels are populated with the new information.
        /// </summary>
        private void AccessoriesOrRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(new1 != null)
            {
                GenerateVehicleSalesQuote();
                Summary();
                FinancingCalculator();
            }
        }

        /// <summary>
        /// Method called when the numerical up/down for interest or years is changed. Runs financial calculator to update labels.
        /// </summary>
        private void NudVehicleSalesQuoteFormFinanceInterestOrYears_ValueChanged(object sender, EventArgs e)
        {
            FinancingCalculator();
        }

        /// <summary>
        /// Method called when "Calculate Quote" button is clicked. A new quote is generated.
        /// </summary>
        private void BtnVehicleSalesQuoteFormCalculateQuote_Click(object sender, EventArgs e)
        {
            errorProviderVehicleSalesQuoteForm.SetError(txtVehicleSalesQuoteFormTradeInAmount, "");
            errorProviderVehicleSalesQuoteForm.SetError(cboVehicleIDSelector, "");
            GenerateVehicleSalesQuote();
        }

        /// <summary>
        /// Method called when "Reset" button is clicked. A dialog box is shown, asking the user if they want 
        /// to reset the form. Clicking yes will reset the form, clicking no will do nothing and close the box without resetting info.
        /// </summary>
        private void BtnVehicleSalesQuoteFormReset_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Do you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (x.Equals(DialogResult.Yes))
            {
                ResetSalesQuoteForm();
            }
        }

        /// <summary>
        /// Creates a connection to the database and binds the data to the vehicle price combobox.
        /// </summary>
        private void FormLoad()
        {
            //Opening DB connection
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AMDatabase.mdb";
            dbConnection.Open();

            //Connect DBCommand to Connection object, selecting data using DBCommand
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.CommandText = "SELECT * FROM VehicleStock WHERE SoldBy = 0";
            dbCommand.Connection = dbConnection;

            //Create DataAdapter, CommandBuilder, Dataset
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = dbCommand;
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder();
            commandBuilder.DataAdapter = dataAdapter;
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "VehicleStock");

            //Bind the info using BindingSource: bind to DataSet's table
            bindVehicleSelector = new BindingSource();
            bindVehicleSelector.DataSource = dataSet.Tables["VehicleStock"];
            cboVehicleIDSelector.DataSource = bindVehicleSelector;
            cboVehicleIDSelector.DisplayMember = "StockNumber";
            cboVehicleIDSelector.ValueMember = "BasePrice";
            cboVehicleIDSelector.SelectedIndex = -1;
            this.mnuVehicleSalesQuoteVehicleInfo.Enabled = false;

            if (bindVehicleSelector.Count.Equals(0))
            {
                MessageBox.Show("There are no vehicles in stock.", "Sales Quote Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Parses user input information, validates that info and assigns the resulting variables as parameters to an
        /// already created SalesQuote object that was null. Summary and Finance labels are populated based on the SalesQuote object's values.
        /// </summary>
        private void GenerateVehicleSalesQuote()
        {
            //Variables for taking user input
            string tradeInAmountUserInputString = txtVehicleSalesQuoteFormTradeInAmount.Text;
            Accessories accessoriesSelectedByUser;
            ExteriorFinish exteriorSelectedByUser;
            decimal vehicleSalePriceUserInputNumber = -1;
            decimal tradeInAmountUserInputNumber = -1;

            //Validation of vehicle price:
            //If field is null or empty
            if (cboVehicleIDSelector.SelectedIndex == -1)
                errorProviderVehicleSalesQuoteForm.SetError(cboVehicleIDSelector, "A vehicle must be selected.");

            else
            {
                //No error path
                errorProviderVehicleSalesQuoteForm.SetError(cboVehicleIDSelector, "");
                vehicleSalePriceUserInputNumber = Decimal.Parse(cboVehicleIDSelector.SelectedValue.ToString());
            }

            
            //Trade-In Amount validation
            //If field is empty or null
            if (tradeInAmountUserInputString.Equals(""))
                errorProviderVehicleSalesQuoteForm.SetError(txtVehicleSalesQuoteFormTradeInAmount, "Trade-in amount is a required field.");

            //If the field contains any sort of character
            else if (!(Decimal.TryParse(tradeInAmountUserInputString, out tradeInAmountUserInputNumber)))
                errorProviderVehicleSalesQuoteForm.SetError(txtVehicleSalesQuoteFormTradeInAmount, "Trade-in amount cannot contain letters or special characters.");

            //If the string contains a number but it is less than 0
            else if (Decimal.TryParse(tradeInAmountUserInputString, out tradeInAmountUserInputNumber) && tradeInAmountUserInputNumber < 0)
                errorProviderVehicleSalesQuoteForm.SetError(txtVehicleSalesQuoteFormTradeInAmount, "Trade-in value cannot be less than zero.");

            //If the string contains a number, but is greater than the vehicle sale price
            else if(Decimal.TryParse(tradeInAmountUserInputString, out tradeInAmountUserInputNumber) && tradeInAmountUserInputNumber > vehicleSalePriceUserInputNumber)
                errorProviderVehicleSalesQuoteForm.SetError(txtVehicleSalesQuoteFormTradeInAmount, "Trade-In Amount cannot be greater than vehicle sale price.");

            else
            {
                //No error path
                errorProviderVehicleSalesQuoteForm.SetError(txtVehicleSalesQuoteFormTradeInAmount, "");
                Decimal.TryParse(tradeInAmountUserInputString, out tradeInAmountUserInputNumber);
            }

            //Checkboxes for accessories selected
            if (chkVehicleSalesQuoteFormAccessoriesComputer.Checked)
                accessoriesSelectedByUser = Accessories.ComputerNavigation;

            else if(chkVehicleSalesQuoteFormAccessoriesLeather.Checked)
                accessoriesSelectedByUser = Accessories.LeatherInterior;

            else if(chkVehicleSalesQuoteFormAccessoriesStereo.Checked)
                accessoriesSelectedByUser = Accessories.StereoSystem;

            else if(chkVehicleSalesQuoteFormAccessoriesStereo.Checked && chkVehicleSalesQuoteFormAccessoriesLeather.Checked)
                accessoriesSelectedByUser = Accessories.StereoAndLeather;

            else if(chkVehicleSalesQuoteFormAccessoriesStereo.Checked && chkVehicleSalesQuoteFormAccessoriesComputer.Checked)
                accessoriesSelectedByUser = Accessories.StereoAndNavigation;

            else if(chkVehicleSalesQuoteFormAccessoriesLeather.Checked && chkVehicleSalesQuoteFormAccessoriesComputer.Checked)
                accessoriesSelectedByUser = Accessories.LeatherAndNavigation;

            else if(chkVehicleSalesQuoteFormAccessoriesComputer.Checked && chkVehicleSalesQuoteFormAccessoriesLeather.Checked && chkVehicleSalesQuoteFormAccessoriesStereo.Checked)
                accessoriesSelectedByUser = Accessories.All;

            else
                accessoriesSelectedByUser = Accessories.None;

            //Exterior finish selected by user
            if(radVehicleSalesQuoteFormExteriorStandard.Checked)
                exteriorSelectedByUser = ExteriorFinish.Standard;

            else if(radVehicleSalesQuoteFormExteriorPearl.Checked)
                exteriorSelectedByUser = ExteriorFinish.Pearlized;

            else if(radVehicleSalesQuoteFormExteriorCustom.Checked)
                exteriorSelectedByUser = ExteriorFinish.Custom;

            else
                exteriorSelectedByUser = ExteriorFinish.None;
            
            if (errorProviderVehicleSalesQuoteForm.GetError(cboVehicleIDSelector).Equals("") && errorProviderVehicleSalesQuoteForm.GetError(txtVehicleSalesQuoteFormTradeInAmount).Equals("") && vehicleSalePriceUserInputNumber >= tradeInAmountUserInputNumber)
            {
                new1 = new SalesQuote(vehicleSalePriceUserInputNumber, tradeInAmountUserInputNumber, 0.13m, accessoriesSelectedByUser, exteriorSelectedByUser);
                Summary();
                FinancingCalculator();
            }
        }

        /// <summary>
        /// Populates the summary labels according to values calculated based on the SalesQuote object.
        /// </summary>
        private void Summary()
        {
            lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.Text = String.Format("{0:C}", new1.VehicleSalePrice);
            lblVehicleSalesQuoteFormSummaryOptionsOut.Text = String.Format("{0:N2}", (new1.FinishCost+new1.AccessoryCost));
            lblVehicleSalesQuoteFormSummarySubtotalOut.Text = String.Format("{0:C}", new1.Subtotal);
            lblVehicleSalesQuoteFormSummarySalesTaxOut.Text = String.Format("{0:N2}", new1.SalesTax);
            lblVehicleSalesQuoteFormSummaryTotalOut.Text = String.Format("{0:C}", new1.Total);
            lblVehicleSalesQuoteFormSummaryTIAOut.Text = String.Format("{0:N2}", -(new1.TradeInAmount));
            lblVehicleSalesQuoteFormSummaryAmountDueOut.Text = String.Format("{0:C}", new1.AmountDue);
        }

        /// <summary>
        /// Populates the monthly payment label using the amount due and values from the numerical up/downs in the Finance groupbox.
        /// </summary>
        private void FinancingCalculator()
        {
            if(new1 != null)
            lblVehicleSalesQuoteFormFinancePaymentOut.Text = 
                    String.Format("{0:C}", Financial.GetPayment((nudVehicleSalesQuoteFormFinanceInterest.Value/1200m), (((int)nudVehicleSalesQuoteFormFinanceYears.Value)*12), new1.AmountDue));
        }

        /// <summary>
        /// Resets SalesQuoteForm labels to their default state.
        /// </summary>
        protected void ResetSalesQuoteForm()
        {
            cboVehicleIDSelector.SelectedIndex = -1;
            txtVehicleSalesQuoteFormTradeInAmount.Text = "0";
            chkVehicleSalesQuoteFormAccessoriesLeather.Checked = false;
            chkVehicleSalesQuoteFormAccessoriesStereo.Checked = false;
            chkVehicleSalesQuoteFormAccessoriesComputer.Checked = false;
            radVehicleSalesQuoteFormExteriorStandard.Checked = true;
            nudVehicleSalesQuoteFormFinanceYears.Value = 1;
            nudVehicleSalesQuoteFormFinanceInterest.Value = 5.0m;
            ResetSummaryAndPaymentFields();
            errorProviderVehicleSalesQuoteForm.SetError(cboVehicleIDSelector, "");
            errorProviderVehicleSalesQuoteForm.SetError(txtVehicleSalesQuoteFormTradeInAmount, "");
            mnuVehicleSalesQuoteVehicleInfo.Enabled = false;
            cboVehicleIDSelector.Focus();
        }

        /// <summary>
        /// Resets the summary and payment field labels to their default state only.
        /// </summary>
        private void ResetSummaryAndPaymentFields()
        {
            lblVehicleSalesQuoteFormSummaryAmountDueOut.Text = "";
            lblVehicleSalesQuoteFormSummaryVehicleSalePriceOut.Text = "";
            lblVehicleSalesQuoteFormSummaryOptionsOut.Text = "";
            lblVehicleSalesQuoteFormSummarySalesTaxOut.Text = "";
            lblVehicleSalesQuoteFormSummarySubtotalOut.Text = "";
            lblVehicleSalesQuoteFormSummaryTotalOut.Text = "";
            lblVehicleSalesQuoteFormSummaryTIAOut.Text = "";
            lblVehicleSalesQuoteFormSummaryAmountDueOut.Text = "";
            lblVehicleSalesQuoteFormFinancePaymentOut.Text = "";
        }
    }
}
