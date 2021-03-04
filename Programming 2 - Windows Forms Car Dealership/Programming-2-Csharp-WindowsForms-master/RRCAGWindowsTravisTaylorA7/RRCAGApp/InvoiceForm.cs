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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            this.lblInvoiceDateOut.Text = today.ToString("MM-dd-yyyy");
        }

        public string ChangeInvoiceTitle
        {
            set
            {
                this.lblInvoiceTitle.Text = value;
            }
        }
    }
}
