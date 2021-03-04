using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    /// <summary>
    /// Launcher form for RRC Automotive group.
    /// </summary>
    public partial class RRCAGForm : Form
    {
        /// <summary>
        /// Initializes a RRCAGForm object and sets it's initial state.
        /// </summary>
        public RRCAGForm()
        {
            InitializeComponent();          
            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_clicked;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
            this.mnuDataVehicle.Click += MnuDataVehicle_Click;
        }

        private void MnuDataVehicle_Click(object sender, EventArgs e)
        {
            VehicleDataForm vehicleDataForm1 = new VehicleDataForm();
            vehicleDataForm1.Show();
        }

        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm carWashForm1 = new CarWashForm();
            carWashForm1.ShowDialog();
        }

        /// <summary>
        /// Method called when user clicks exit from menu. Shuts down the application.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Method called when Help, About is clicked from menu. Shows the About dialog box.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBoxRRCAGApp aboutBox1 = new AboutBoxRRCAGApp();
            aboutBox1.ShowDialog();
        }

        /// <summary>
        /// Method called when File, Open, Sales Quote is clicked from menu. Shows the SalesQuote form.
        /// </summary>
        private void MnuFileOpenSalesQuote_clicked(object publisher, EventArgs e)
        {
            SalesQuoteForm salesQuoteForm1 = new SalesQuoteForm();
            salesQuoteForm1.ShowDialog();
        }       
    }
}
