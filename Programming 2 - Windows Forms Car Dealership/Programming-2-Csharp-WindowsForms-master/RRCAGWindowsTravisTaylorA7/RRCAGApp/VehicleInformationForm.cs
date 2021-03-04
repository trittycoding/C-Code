using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRCAG.Data;

namespace RRCAGApp
{
    public partial class VehicleInformationForm : Form
    {
        /// <summary>
        /// Creates an instance of a vehicle information form.
        /// </summary>
        /// <param name="bindVehicleSelector">Binding source object used for sales quote combo box.</param>
        public VehicleInformationForm(BindingSource bindVehicleSelector)
        {
            InitializeComponent();
            this.btnVehicleInfoClose.Click += BtnVehicleInfoClose_Click;
            this.lblVehicleInfoStockOut.DataBindings.Add("Text", bindVehicleSelector, "StockNumber");
            this.lblVehicleInfoColourOut.DataBindings.Add("Text", bindVehicleSelector, "Colour");
            this.lblVehicleInfoMfrOut.DataBindings.Add("Text", bindVehicleSelector, "Make");
            this.lblVehicleInfoModelOut.DataBindings.Add("Text", bindVehicleSelector, "Model");
            this.lblVehicleInfoYearOut.DataBindings.Add("Text", bindVehicleSelector, "ManufacturedYear");
            Binding mileageBind = new Binding("Text", bindVehicleSelector, "Mileage", true);
            Binding basePriceBind = new Binding("Text", bindVehicleSelector, "BasePrice", true);
            mileageBind.FormatString = "N0";
            basePriceBind.FormatString = "c";
            this.lblVehicleInfoMileageOut.DataBindings.Add(mileageBind);
            this.lblVehicleInfoBasePriceOut.DataBindings.Add(basePriceBind);

            //DataRowView x --> x.Row[column_name] returns the row for a given column
            Boolean transmissionBool = Convert.ToBoolean(((DataRowView)bindVehicleSelector.Current)["Automatic"]);
            if (transmissionBool)
            {
                this.lblVehicleInfoTransmissionOut.Text = "Automatic";
            }
            else
            {
                this.lblVehicleInfoTransmissionOut.Text = "Manual";
            }
        }

        /// <summary>
        /// When the user clicks the close option on the menu, close the form.
        /// </summary>
        private void BtnVehicleInfoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
