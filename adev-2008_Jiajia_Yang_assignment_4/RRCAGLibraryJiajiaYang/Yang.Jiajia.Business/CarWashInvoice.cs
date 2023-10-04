using System;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 4
 * Created: 2023-02-27
 * Updated: 2023-02-27
 */

namespace Yang.Jiajia.Business
{
    /// <summary>
    /// This class contains functionality that supports the business process of creating an invoice for the car wash department.
    /// </summary>
    public class CarWashInvoice : Invoice
    {
        /// <summary>
        /// The amount charged for the chosen package.
        /// </summary>
        private decimal packageCost;

        /// <summary>
        /// The amount charged for the chosen fragrance.
        /// </summary>
        private decimal fragranceCost;

        /// <summary>
        /// Occurs when the package cost changes.
        /// </summary>
        public event EventHandler PackageCostChanged;

        /// <summary>
        /// Occurs when the fragrance cost changes.
        /// </summary>
        public event EventHandler FragranceCostChanged;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        ///</exception>
        public decimal PackageCost
        {
            get
            {
                return packageCost;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");

                if (this.packageCost != value)
                {
                    packageCost = value;

                    OnPackageCostChanged();
                }
            }
        }

        /// <summary>
        /// Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        ///</exception>
        public decimal FragranceCost
        {
            get
            {
                return fragranceCost;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");

                if (this.fragranceCost != value)
                {
                    fragranceCost = value;

                    OnFragranceCostChanged();
                }
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer. No provincial sales tax is charged for a car wash.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer (Rounded to 2 decimal places). The tax is calculated by multiplying the tax rate by the subtotal.
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get

            {
                return Math.Round(SubTotal * GoodsAndServicesTaxRate, 2);
            }
        }

        /// <summary>
        /// Gets the subtotal of the Invoice. The subtotal is the sum of the package and fragrance cost.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                return PackageCost + FragranceCost;
            }
        }

        /// <summary>
        /// Raises the PackageCostChanged event.
        /// </summary>
        protected virtual void OnPackageCostChanged()
        {
            if (this.PackageCostChanged != null)
            {
                PackageCostChanged(this, new EventArgs()); 
            }
        }

        /// <summary>
        /// Raises the FragranceCostChanged event.
        /// </summary>
        protected virtual void OnFragranceCostChanged()
        {
            if (this.FragranceCostChanged != null)
            {
                FragranceCostChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods, services tax rate, package cost and fragrance cost.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <param name="packageCost">The cost of the chosen package.</param>
        /// <param name="fragranceCost">The cost of the chosen fragrance.</param>
        /// <exception cref="ArgumentOutOfRangeException">when the package cost is less than 0.</exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate, decimal packageCost, decimal fragranceCost)
            : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if (packageCost < 0)
                throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "packageCost");
            if (fragranceCost < 0)
                throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "fragranceCost");

            PackageCost = packageCost;
            FragranceCost = fragranceCost;
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods and services tax rates. The package cost and fragrance cost are zero.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
            : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            PackageCost = 0;
            FragranceCost = 0;

        }



    }
}