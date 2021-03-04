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
    public class CarWashPackages
    {
        private string packageName;
        private decimal packagePrice;

        public CarWashPackages(string packageName, decimal packagePrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        public string PackageName
        {
            get
            {
                return this.packageName;
            }
        }

        public decimal PackagePrice
        {
            get
            {
                return this.packagePrice;
            }
        }
    }
}