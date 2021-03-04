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
    public partial class CarWashInvoiceDisplay : InvoiceForm
    {
        public CarWashInvoiceDisplay(CarWashInvoice carWashInvoice, CarWashForm carWashForm1)
        {
            InitializeComponent();
            Binding packagePriceBind = new Binding("Text", carWashInvoice, "PackageCost", true);
            Binding fragrancePriceBind = new Binding("Text", carWashInvoice, "FragranceCost", true);
            Binding subtotalInvoiceBind = new Binding("Text", carWashInvoice, "Subtotal", true);
            Binding taxesBind = new Binding("Text", carWashInvoice, "GoodsAndServicesTaxCharged", true);
            Binding totalBind = new Binding("Text", carWashInvoice, "Total", true);
            packagePriceBind.FormatString = "c";
            fragrancePriceBind.FormatString = "N2";
            subtotalInvoiceBind.FormatString = "N2";
            taxesBind.FormatString = "N2";
            totalBind.FormatString = "c";
            

            this.lblCarWashInvoicePackagePriceOut.DataBindings.Add(packagePriceBind);
            this.lblCarWashInvoiceFragracePriceOut.DataBindings.Add(fragrancePriceBind);
            this.lblCarWashInvoiceSubtotalOut.DataBindings.Add(subtotalInvoiceBind);
            this.lblCarWashInvoiceTaxesOut.DataBindings.Add(taxesBind);
            this.lblCarWashInvoiceTotalOut.DataBindings.Add(totalBind);
        }

        private void CarWashInvoiceDisplay_Load(object sender, EventArgs e)
        {
            this.ChangeInvoiceTitle = "Car Wash Invoice";
        }
    }
}
