using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

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
	/// Class <c>SalesQuote</c>
	/// This class contains functionality that supports the business process of determining a quote for the sale of a vehicle.
	/// </summary>
    public class SalesQuote
    {
        /// <summary>
        /// The selling price of the vehicle being sold.
        /// </summary>
        private decimal vehicleSalePrice;

        /// <summary>
        /// The amount offered to the customer for the trade in of their vehicle.
        /// </summary>
        private decimal tradeInAmount;

        /// <summary>
        /// The tax rate applied to the sale of a vehicle.
        /// </summary>
        private decimal salesTaxRate;

        /// <summary>
        /// The chosen accessories.
        /// </summary>
        private Accessories accessoriesChosen;

        /// <summary>
        /// The chosen exterior finish.
        /// </summary>
        private ExteriorFinish exteriorFinishChosen;

        /// <summary>
        /// Gets and sets the sale price of the vehicle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than or equal to 0.
        /// </exception>
        public decimal VehicleSalePrice
        {
            get
            {
                return this.vehicleSalePrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than or equal to 0.");
                }
                this.vehicleSalePrice = value;
            }
        }

        /// <summary>
        /// Gets and sets the trade in amount.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        /// </exception>
        public decimal TradeInAmount
        {
            get
            {
                return this.tradeInAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than 0.");
                }
                this.tradeInAmount = value;
            }
        }

        /// <summary>
        /// Gets and sets the accessories that were chosen.
        /// </summary>
        ///<exception cref="InvalidEnumArgumentException">
        /// Occurs when the property is set to an invalid value. 
        /// </exception>
        public Accessories AccessoriesChosen
        {
            get
            {
                return this.accessoriesChosen;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Accessories), value))
                {
                    throw new InvalidEnumArgumentException(
                        "The value is an invalid enumeration value");
                }
                this.accessoriesChosen = value;
            }

        }

        /// <summary>
        /// Gets and sets the exterior finish that was chosen.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when the property is set to an invalid value. 
        /// </exception>
        public ExteriorFinish ExteriorFinishChosen
        {
            get
            {
                return this.exteriorFinishChosen;
            }
            set
            {
                if (!Enum.IsDefined(typeof(ExteriorFinish), value))
                {
                    throw new InvalidEnumArgumentException(
                        "The value is an invalid enumeration value");
                }
                this.exteriorFinishChosen = value;
            }

        }

        /// <summary>
        /// Gets the cost of accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                decimal accessoriesCost = 0;
                decimal stereoSystem = 505.05M;
                decimal leatherInterior = 1010.10M;
                decimal computerNavigation = 1515.15M;

                switch (accessoriesChosen)
                {
                    case Accessories.StereoSystem:
                        accessoriesCost = stereoSystem;
                        break;
                    case Accessories.LeatherInterior:
                        accessoriesCost = leatherInterior;
                        break;
                    case Accessories.StereoAndLeather:
                        accessoriesCost = stereoSystem + leatherInterior;
                        break;
                    case Accessories.ComputerNavigation:
                        accessoriesCost = computerNavigation;
                        break;
                    case Accessories.StereoAndNavigation:
                        accessoriesCost = stereoSystem + computerNavigation;
                        break;
                    case Accessories.LeatherAndNavigation:
                        accessoriesCost = leatherInterior + computerNavigation;
                        break;
                    case Accessories.All:
                        accessoriesCost = stereoSystem + leatherInterior + computerNavigation;
                        break;
                    case Accessories.None:
                        accessoriesCost = 0;
                        break;
                }
                return accessoriesCost;
            }
        }

        /// <summary>
        /// Gets the cost of the exterior finish chosen.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                decimal exteriorFinishCost = 0;
                decimal standard = 202.02M;
                decimal pearlized = 404.04M;
                decimal custom = 606.06M;

                switch (exteriorFinishChosen)
                {
                    case ExteriorFinish.Standard:
                        exteriorFinishCost = standard;
                        break;
                    case ExteriorFinish.Pearlized:
                        exteriorFinishCost = pearlized;
                        break;
                    case ExteriorFinish.Custom:
                        exteriorFinishCost = custom;
                        break;
                    case ExteriorFinish.None:
                        exteriorFinishCost = 0;
                        break;

                }
                return exteriorFinishCost;
            }
        }

        /// <summary>
        /// Gets the sum of the cost of the chosen accessories and exterior finish (rounded to two decimal places).
        /// </summary>
        public decimal TotalOptions
        {
            get
            {
                decimal totalOptions;
                totalOptions = this.AccessoryCost + this.FinishCost;

                return Math.Round(totalOptions, 2);
            }

        }

        /// <summary>
        /// Gets the sum of the vehicle’s sale price and the Accessory and Finish Cost (rounded to two decimal places).
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                decimal subTotal;
                subTotal = this.VehicleSalePrice + this.TotalOptions;

                return Math.Round(subTotal, 2);
            }

        }

        /// <summary>
        /// Gets the amount of tax to charge based on the subtotal (rounded to two decimal places).
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                decimal salesTax;
                salesTax = this.SubTotal * salesTaxRate;

                return Math.Round(salesTax, 2);
            }
        }

        /// <summary>
        /// Gets the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                decimal total;
                total = this.SubTotal + this.SalesTax;

                return total;
            }
        }

        /// <summary>
        /// Gets the result of subtracting the trade-in amount from the total (rounded to two decimal places).
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                decimal amountDue;
                amountDue = this.Total - this.TradeInAmount;

                return amountDue;
            }
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in value, sales tax rate, accessories chosen and exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories.</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish.</param>
        /// <exception cref="ArgumentOutOfRangeException">when the vehicle sale price is less than or equal to 0.</exception>
        /// <exception cref="ArgumentOutOfRangeException">when the trade in amount is less than 0.</exception>
        /// <exception cref="ArgumentOutOfRangeException">when the sales tax rate is less than 0.</exception>
        /// <exception cref="ArgumentOutOfRangeException">when the sales tax rate is greater than 1.</exception>
        /// <exception cref="InvalidEnumArgumentException">when the accessories chosen is an invalid argument.</exception>
        /// <exception cref="InvalidEnumArgumentException">when the exterior finish chosen is an invalid argument. </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            if (vehicleSalePrice <= 0)
                throw new ArgumentOutOfRangeException(
                    "The argument cannot be less than or equal to 0.", "vehicleSalePrice");
            if (tradeInAmount < 0)
                throw new ArgumentOutOfRangeException(
                    "The argument cannot be less than 0.", "tradeInAmount");
            if (salesTaxRate < 0)
                throw new ArgumentOutOfRangeException(
                    "The argument cannot be less than 0.", "salesTaxRate");
            if (salesTaxRate > 1)
                throw new ArgumentOutOfRangeException(
                    "The argument cannot be greater than 1.", "salesTaxRate");
            if (!Enum.IsDefined(typeof(Accessories), accessoriesChosen))
                throw new InvalidEnumArgumentException(
                    "The argument is an invalid enumeration value.");
            if (!Enum.IsDefined(typeof(ExteriorFinish), exteriorFinishChosen))
                throw new InvalidEnumArgumentException(
                    "The argument is an invalid enumeration value.");


            this.VehicleSalePrice = vehicleSalePrice;
            this.TradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.AccessoriesChosen = accessoriesChosen;
            this.ExteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in amount, sales tax rate, no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
            : this(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None)
        {

        }


    }
}

