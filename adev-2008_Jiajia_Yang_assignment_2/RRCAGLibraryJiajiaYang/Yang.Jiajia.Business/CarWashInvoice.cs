using System;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-01-26
 * Updated: 2023-01-26
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

                packageCost = value;
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

                fragranceCost = value;
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