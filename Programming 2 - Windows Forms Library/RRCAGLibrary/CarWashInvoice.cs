using System;

namespace Taylor.Travis.Business
{
    public class CarWashInvoice : Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;

        //Events
        /// <summary>
        /// Occurs when the pacakge cost changes.
        /// </summary>
        public event EventHandler PackageCostChanged;

        /// <summary>
        /// Occurs when the fragrance cost changes.
        /// </summary>
        public event EventHandler FragranceCostChanged;

        //On Methods
        /// <summary>
        /// Raises the PackageCostChanged event.
        /// </summary>
        protected virtual void OnPackageCostChanged()
        {
            if (PackageCostChanged != null)
                PackageCostChanged(this, new EventArgs());
        }

        /// <summary>
        /// Raises the FragranceCostChanged event.
        /// </summary>
        protected virtual void OnFragranceCostChanged()
        {
            if (FragranceCostChanged != null)
                FragranceCostChanged(this, new EventArgs());
        }

        /// <summary>
        /// Initializes an instance of the CarWashInvoice with provinical and goods/services sales tax rates, package cost and fragrance cost.
        /// </summary>
        /// <param name="packageCost">Package cost.</param>
        /// <param name="fragranceCost">Fragrance cost.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when provinical sales tax rate is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when provincial sales tax rate is greater than one.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when goods/services sales tax rate is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when goods/services sales tax rate is greater than one.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when package cost is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when fragrance cost is less than zero.</exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate, decimal packageCost, decimal fragranceCost) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "Argument cannot be less than 0.");
            else if (provincialSalesTaxRate > 1)
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "Argument cannot be greater than 1.");
            else if (goodsAndServicesTaxRate < 0)
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "Argument cannot be less than 0.");
            else if (goodsAndServicesTaxRate > 1)
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "Argument cannot be greater than 1.");
            else if (packageCost < 0)
                throw new ArgumentOutOfRangeException("packageCost", "Argument cannot be less than 0.");
            else if (fragranceCost < 0)
                throw new ArgumentOutOfRangeException("fragranceCost", "Argument cannot be less than 0.");           
            this.PackageCost = packageCost;
            this.FragranceCost = fragranceCost;
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with provincial and goods/services tax rates. Fragrance and package costs are zero by default.
        /// </summary>
        /// <param name="provincialSalesTaxRate">Provincial sales tax rate./</param>
        /// <param name="goodsAndServicesTaxRate">Goods/services tax rate.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when provinical sales tax rate is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when provincial sales tax rate is greater than one.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when goods/services sales tax rate is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when goods/services sales tax rate is greater than one.</exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate) : this(provincialSalesTaxRate, goodsAndServicesTaxRate, 0m, 0m)
        {
        }

        /// <summary>
        /// Gets/Sets the amount charged for the chosen package.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the property is set top less than zero.</exception>
        public decimal PackageCost
        {
            get
            {
                return this.packageCost;
            }
                
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("packageCost", "The value cannot be less than 0.");
                if (value != this.packageCost)
                    OnPackageCostChanged();

                this.packageCost = value;
            }
        }

        /// <summary>
        /// Gets/Sets the amount charged for the chosen fragrance.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the property is set to less than zero.</exception>
        public decimal FragranceCost
        {
            get
            {
                return this.fragranceCost;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("fragranceCost", "The value cannot be less than 0.");    

                if(value != this.fragranceCost)
                    OnFragranceCostChanged();

                this.fragranceCost = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer. No provincial sales tax is charged for a car wash.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return 0m;
            }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer.
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get
            {
                decimal taxCharged = (this.FragranceCost * base.GoodsAndServicesTaxRate) + (this.PackageCost * base.GoodsAndServicesTaxRate);
                return taxCharged;
            }
        }

        /// <summary>
        /// Gets the subtotal of the invoice.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                decimal subtotal = this.FragranceCost + this.PackageCost;
                return subtotal;
            }
        }
    }
}