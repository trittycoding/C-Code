using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taylor.Travis.Business;

namespace RRCAGApp
{
    public class CarWashFragrances
    {
        private string fragranceName;
        private decimal fragrancePrice;

        public CarWashFragrances(string fragranceName, decimal fragrancePrice)
        {
            this.fragranceName = fragranceName;
            this.fragrancePrice = fragrancePrice;
        }

        public string FragranceName
        {
            get
            {
                return this.fragranceName;
            }
        }

        public decimal FragrancePrice
        {
            get
            {
                return this.fragrancePrice;
            }
        }

        public override string ToString()
        {
            return FragranceName;
        }
    }
}