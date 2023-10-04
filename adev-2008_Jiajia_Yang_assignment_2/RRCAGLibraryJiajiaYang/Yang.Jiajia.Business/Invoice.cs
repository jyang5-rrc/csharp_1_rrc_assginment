
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
    /// The invoice class.
    /// </summary>
    public abstract class Invoice 
    {
        /// <summary>
        /// The provincial sales tax rate applied to the invoice.
        /// </summary>
        private decimal provincialSalesTaxRate;

        /// <summary>
        /// The goods and services tax rate applied to the invoice.
        /// </summary>
        private decimal goodsAndServicesTaxRate;

        /// <summary>
        /// Gets and sets the provincial sales tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to greater than 1.
        /// </exception>
        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return provincialSalesTaxRate;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");
                if (value > 1)
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.", "value");

                provincialSalesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to greater than 1.
        /// </exception>
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return goodsAndServicesTaxRate;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");
                if (value > 1)
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.", "value");

                goodsAndServicesTaxRate = value;
            }

        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer (Rounded to two decimal places).
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged 
        {
            get;
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer (Rounded to two decimal places).
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the Invoice. The total is the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                return SubTotal + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged;
            }
        }

        /// <summary>
        /// Initializes an instance of Invoice with a provincial and goods and services tax rates.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to greater than 1.
        /// </exception>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "provincialSalesTaxRate");
            if(provincialSalesTaxRate > 1)
                throw new ArgumentOutOfRangeException("The argument cannot be grater than 1.", "provincialSalesTaxRate");
            if (goodsAndServicesTaxRate < 0)
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "goodsAndServicesTaxRate");
            if (goodsAndServicesTaxRate > 1)
                throw new ArgumentOutOfRangeException("The argument cannot be grater than 1.", "goodsAndServicesTaxRate");

            this.ProvincialSalesTaxRate = provincialSalesTaxRate;
            this.GoodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }

    }
}