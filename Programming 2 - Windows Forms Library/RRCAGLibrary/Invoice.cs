using System;

namespace Taylor.Travis.Business
{
    public abstract class Invoice
    {
        private decimal provincialSalesTaxRate;
        private decimal goodsAndServicesTaxRate;

        //Events
        /// <summary>
        /// Occurs when the provincial sales tax rate of the invoice changes.
        /// </summary>
        public event EventHandler ProvincialSalesTaxChanged;

        /// <summary>
        /// Occurs when the goods and services tax rate of the invoice changes.
        /// </summary>
        public event EventHandler GoodsAndServicesTaxChanged;

        //On Methods
        /// <summary>
        /// Raises the ProvincialSalesTaxChanged event.
        /// </summary>
        protected virtual void OnProvincialSalesTaxChanged()
        {
            if (ProvincialSalesTaxChanged != null)
                ProvincialSalesTaxChanged(this, new EventArgs());
        }

        /// <summary>
        /// Raises the GoodsAndServicesTaxChanged event.
        /// </summary>
        protected virtual void OnGoodsAndServicesTaxChanged()
        {
            if (GoodsAndServicesTaxChanged != null)
                GoodsAndServicesTaxChanged(this, new EventArgs());
        }

        /// <summary>
        /// Initializes an instance of Invoice with provincial and goods/services tax rates.
        /// </summary>
        /// <param name="provincialSalesTaxRate">Provincial sales tax rate.</param>
        /// <param name="goodsAndServicesTaxRate">Goods and services tax rate.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when provincial sales tax rate is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when provincial sales tax rate is greater than one.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when goods/services tax is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when goods/services tax is greater than one.</exception>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be less than 0.");
            else if (provincialSalesTaxRate > 1)
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be greater than 1.");
            else if (goodsAndServicesTaxRate < 0)
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be less than 0.");
            else if (goodsAndServicesTaxRate > 1)
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be greater than 1.");
            this.GoodsAndServicesTaxRate = goodsAndServicesTaxRate;
            this.ProvincialSalesTaxRate = provincialSalesTaxRate;
        }

        /// <summary>
        /// Gets/Sets the provincial sales tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the property is set to less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the property is greater than one.</exception>
        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return this.provincialSalesTaxRate;
            }
            
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The value cannot be less than 0.");
                if(value > 1)
                    throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The value cannot be greater than 1.");
                if (value != this.goodsAndServicesTaxRate)
                    OnProvincialSalesTaxChanged();
                this.provincialSalesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets/Sets the goods and services tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the property is set to less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the property is set to greater than one.</exception>
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return this.goodsAndServicesTaxRate;
            }

            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The value cannot be less than 0.");
                if(value > 1)
                    throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The value cannot be greater than 1.");
                if (value != this.goodsAndServicesTaxRate)
                    OnGoodsAndServicesTaxChanged();
                this.goodsAndServicesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer.
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer.
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the subtotal of the invoice.
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the invoice by calculating sum of subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                decimal total = this.SubTotal + this.ProvincialSalesTaxCharged + this.GoodsAndServicesTaxCharged;
                return total;
            }
        }
    }
}