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

namespace RRCAGApp
{
    public partial class CarWashForm : Form
    {
        List<string> interiorServices;
        List<string> exteriorServices;
        List<CarWashPackages> possiblePackages;
        List<CarWashFragrances> possibleFragrances;
        CarWashInvoice carWashInvoice;
        CarWashInvoiceDisplay carWashInvoiceDisplay;

        /// <summary>
        /// Initializes an instance of a Car Wash form.
        /// </summary>
        public CarWashForm()
        {
            InitializeComponent();
            this.mnuCarWashExit.Click += MnuCarWashExit_Click;
            this.mnuCarWashGenerateInvoice.Click += MnuCarWashGenerateInvoice_Click;
            carWashInvoice = new CarWashInvoice(0.07m, 0.05m);

            CarWashPackages standard = new CarWashPackages("Standard", 7.50m);
            CarWashPackages deluxe = new CarWashPackages("Deluxe", 15.00m);
            CarWashPackages executive = new CarWashPackages("Executive", 35.00m);
            CarWashPackages luxury = new CarWashPackages("Luxury", 55.00m);
            CarWashFragrances hawaiian = new CarWashFragrances("Hawaiian Mist", 2.75m);
            CarWashFragrances babyPowder = new CarWashFragrances("Baby Powder", 1.50m);
            CarWashFragrances pine = new CarWashFragrances("Pine", 0);
            CarWashFragrances countryFloral = new CarWashFragrances("Country Floral", 2.25m);
            CarWashFragrances pinaColada = new CarWashFragrances("Vanilla", 2.00m);
            possiblePackages = new List<CarWashPackages>();
            possibleFragrances = new List<CarWashFragrances>();
            possiblePackages.Add(standard);
            possiblePackages.Add(deluxe);
            possiblePackages.Add(executive);
            possiblePackages.Add(luxury);
            possibleFragrances.Add(hawaiian);
            possibleFragrances.Add(babyPowder);
            possibleFragrances.Add(pine);
            possibleFragrances.Add(countryFloral);
            possibleFragrances.Add(pinaColada);
            this.cboCarWashPackage.DisplayMember = "PackageName";
            this.cboCarWashFragrance.DisplayMember = "FragranceName";

            interiorServices = new List<string>();
            exteriorServices = new List<string>();
            interiorServices.Add("Fragrance");
            interiorServices.Add("Shampoo Carpets");
            interiorServices.Add("Shampoo Upholstery");
            interiorServices.Add("Interior Protection Coat");
            exteriorServices.Add("Hand Wash");
            exteriorServices.Add("Hand Wax");
            exteriorServices.Add("Wheel Polish");
            exteriorServices.Add("Detail Engine Compartment");

            this.mnuCarWashGenerateInvoice.Enabled = false;
        }

        private void CarWashForm_Load(object sender, EventArgs e)
        {
            CarWashFormLoad();
        }

        private void MnuCarWashExit_Click1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuCarWashGenerateInvoice_Click(object sender, EventArgs e)
        {
            carWashInvoiceDisplay = new CarWashInvoiceDisplay(carWashInvoice, this);
            carWashInvoiceDisplay.ShowDialog();
            ResetPaymentLabels();
        }

        private void CboCarWashFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageChosen();
            if (cboCarWashFragrance.SelectedIndex != -1)
            {
                carWashInvoice.FragranceCost = (decimal)cboCarWashFragrance.SelectedValue;
                UpdateOutputUI();
            }
        }

        private void CboCarWashPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageChosen();
            if (cboCarWashPackage.SelectedIndex != -1)
            {
                carWashInvoice.PackageCost = (decimal)cboCarWashPackage.SelectedValue;
                UpdateOutputUI();
                mnuCarWashGenerateInvoice.Enabled = true;
            }  
        }

        private void MnuCarWashExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Updates the interior list box depending on what package is chosen.
        /// </summary>
        private void PackageChosen()
        {
            List<string> selectedInterior = new List<string>();
            List<string> selectedExterior = new List<string>();

            for (int i = 0; i < ((cboCarWashPackage.SelectedIndex)+1); i++)
            {
                if (i== 0)
                {
                    string fragranceConcat = interiorServices[0] + "-" + ((CarWashFragrances)cboCarWashFragrance.SelectedItem).FragranceName;
                    selectedInterior.Add(fragranceConcat);
                    selectedExterior.Add(exteriorServices[i]);
                }
                else
                {
                    selectedInterior.Add(interiorServices[i]);
                    selectedExterior.Add(exteriorServices[i]);
                }
            }

            lstCarWashSummaryInteriorBox.DataSource = selectedInterior;
            lstCarWashSummaryExteriorBox.DataSource = selectedExterior;
            lstCarWashSummaryInteriorBox.DisplayMember = "ToString()";
            lstCarWashSummaryExteriorBox.DisplayMember = "ToString()";
        }

        private void UpdateOutputUI()
        {
            if (cboCarWashFragrance.SelectedIndex != -1 && cboCarWashPackage.SelectedIndex != -1)
            {
                lblCarWashSubtotalOut.DataBindings[0].ReadValue();
                lblCarWashPSTOut.DataBindings[0].ReadValue();
                lblCarWashGSTOut.DataBindings[0].ReadValue();
                lblCarWashTotalOut.DataBindings[0].ReadValue();
            }
        }

        public void CarWashFormLoad()
        {
            cboCarWashPackage.DataSource = possiblePackages;
            cboCarWashFragrance.DataSource = possibleFragrances;
            cboCarWashPackage.DisplayMember = "PackageName";
            cboCarWashPackage.ValueMember = "PackagePrice";
            cboCarWashFragrance.DisplayMember = "FragranceName";
            cboCarWashFragrance.ValueMember = "FragrancePrice";
            Binding subtotalBind = new Binding("Text", carWashInvoice, "Subtotal", true);
            subtotalBind.FormatString = "c";
            Binding pstBind = new Binding("Text", carWashInvoice, "ProvincialSalesTaxCharged", true);
            pstBind.FormatString = "N2";
            Binding gstBind = new Binding("Text", carWashInvoice, "GoodsAndServicesTaxCharged", true);
            gstBind.FormatString = "N2";
            Binding totalBind = new Binding("Text", carWashInvoice, "Total", true);
            totalBind.FormatString = "c";

            this.cboCarWashPackage.SelectedIndex = -1;
            this.cboCarWashFragrance.SelectedIndex = 2;
            this.lblCarWashSubtotalOut.DataBindings.Add(subtotalBind);
            this.lblCarWashPSTOut.DataBindings.Add(pstBind);
            this.lblCarWashGSTOut.DataBindings.Add(gstBind);
            this.lblCarWashTotalOut.DataBindings.Add(totalBind);
            this.cboCarWashFragrance.SelectedIndexChanged += CboCarWashFragrance_SelectedIndexChanged;
            this.cboCarWashPackage.SelectedIndexChanged += CboCarWashPackage_SelectedIndexChanged;
        }

        private void ResetPaymentLabels()
        {
            this.cboCarWashPackage.SelectedIndex = -1;
            this.cboCarWashFragrance.SelectedIndex = 2;
            this.lblCarWashSubtotalOut.Text = "$0.00";
            this.lblCarWashPSTOut.Text = "0.00";
            this.lblCarWashGSTOut.Text = "0.00";
            this.lblCarWashTotalOut.Text = "$0.00";
        }
    } 
}
