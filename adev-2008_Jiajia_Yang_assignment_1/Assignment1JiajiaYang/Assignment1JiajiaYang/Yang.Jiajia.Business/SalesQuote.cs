using System;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-01-10
 * Updated: 2023-01-11
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
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in value, sales tax rate, accessories chosen and exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories.</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish.</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            this.vehicleSalePrice= vehicleSalePrice;
            this.tradeInAmount= tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in amount, sales tax rate, no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
            :this(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None){}

        /// <summary>
        /// Gets the sale price of the vehicle.
        /// </summary>
        /// <returns> the sale price of the vehicle.</returns>
        public decimal GetVehicleSalePrice()
        {
            return vehicleSalePrice;
        }

        /// <summary>
        /// Sets the sale price of the vehicle.
        /// </summary>
        /// <param name="vehicleSalePrice"> the selling price of the vehicle.</param>
        public void SetVehicleSalePrice(decimal vehicleSalePrice)
        {
            this.vehicleSalePrice = vehicleSalePrice;
        }

        /// <summary>
        /// Gets the trade in amount.
        /// </summary>
        /// <returns>the trade in amount.</returns>
        public decimal GetTradeInAmount()
        {
            return tradeInAmount;
        }

        /// <summary>
        /// Sets the trade in amount.
        /// </summary>
        /// <param name="tradeInAmount"> The amount offered to the customer for the trade in of their vehicle.</param>
        public void SetTradeInAmount(decimal tradeInAmount)
        {
            this.tradeInAmount = tradeInAmount;
        }

        /// <summary>
        /// Gets the tax rate applied to the sale of a vehicle.
        /// </summary>
        /// <returns>the tax rate applied to the sale of a vehicle.</returns>
        public decimal GetSalesTaxRate()
        {
            return salesTaxRate;
        }

        /// <summary>
        /// Gets the accessories chosen for the vehicle.
        /// </summary>
        /// <returns>the accessories chosen for the vehicle.</returns>
        public Accessories GetAccessoriesChosen()
        {
            return accessoriesChosen;
        }

        /// <summary>
        /// Sets the accessories chosen for the vehicle.
        /// </summary>
        /// <param name="accessoriesChosen">The chosen accessories.</param>
        public void SetAccessoriesChosen(Accessories accessoriesChosen)
        {
            this.accessoriesChosen = accessoriesChosen;
        }

        /// <summary>
        /// Gets the exterior finish chosen for the vehicle.
        /// </summary>
        /// <returns>the exterior finish chosen for the vehicle.</returns>
        public ExteriorFinish GetExteriorFinishChosen()
        {
            return exteriorFinishChosen;
        }

        /// <summary>
        /// Sets the exterior finish chosen for the vehicle.
        /// </summary>
        /// <param name="exteriorFinishChosen">The chosen exterior finish.</param>
        public void SetExteriorFinishChosen(ExteriorFinish exteriorFinishChosen)
        {
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Returns the cost of the accessories chosen.
        /// Accessories have the following costs:
        /// Stereo System - $505.05
        /// Leather Interior - $1,010.10
        /// Computer Navigation - $1,515.15
        /// </summary>
        /// <returns>Returns the cost of the accessories chosen.</returns>
        public decimal GetAccessoriesCost()
        {
            decimal accessoriesCost = 0;
            switch (accessoriesChosen)
            {
                case  Accessories.StereoSystem:
                    accessoriesCost = 505.05M;
                    break;
                case Accessories.LeatherInterior:
                    accessoriesCost = 1010.10M;
                    break;
                case Accessories.StereoAndLeather:
                    accessoriesCost = 505.05M + 1010.10M;
                    break;
                case Accessories.ComputerNavigation:
                    accessoriesCost = 1515.15M;
                    break;
                case Accessories.StereoAndNavigation:
                    accessoriesCost = 505.05M + 1515.15M;
                    break;
                case Accessories.LeatherAndNavigation:
                    accessoriesCost = 1010.10M + 1515.15M;
                    break;
                case Accessories.All:
                    accessoriesCost = 505.05M + 1010.10M + 1515.15M;
                    break;
                case Accessories.None:
                    accessoriesCost = 0;
                    break;
            }
            return accessoriesCost;
        }

        /// <summary>
        /// Returns the cost of the exterior finish chosen.
        /// Exterior Finishes have the following costs:
        /// Standard - $202.02
        /// Pearlized -$404.04
        /// Custom - $606.06
        /// </summary>
        /// <returns></returns>
        public decimal GetExteriorFinishCost()
        {
            decimal exteriorFinishCost = 0;
            switch (exteriorFinishChosen)
            {
                case ExteriorFinish.Standard:
                    exteriorFinishCost = 202.02M;
                    break;
                case ExteriorFinish.Pearlized:
                    exteriorFinishCost = 404.04M;
                    break;
                case ExteriorFinish.Custom:
                    exteriorFinishCost = 606.06M;
                    break;
                case ExteriorFinish.None:
                    exteriorFinishCost = 0;
                    break;
                    
            }
            return exteriorFinishCost;

        }

        /// <summary>
        /// Return the sum of the cost of accessories chosen and the cost of the exterior finish chosen (rounded to two decimal places).
        /// </summary>
        /// <returns>Return the sum of the cost of accessories chosen and the cost of the exterior finish chosen (rounded to two decimal places).</returns>
        public decimal GetTotalOptions()
        {
            return Math.Round(GetAccessoriesCost() + GetExteriorFinishCost(), 2);
        }

        /// <summary>
        /// Returns the sum of the vehicle’s sale price, accessories and exterior finish costs (rounded to two decimal places).
        /// </summary>
        /// <returns>Returns the sum of the vehicle’s sale price, accessories and exterior finish costs (rounded to two decimal places).</returns>
        public decimal GetSubTotal()
        {
            return Math.Round(GetVehicleSalePrice() + GetTotalOptions(), 2);

        }

        /// <summary>
        /// Returns the amount of tax to charge based on the subtotal (rounded to two decimal places).
        /// </summary>
        /// <returns>Returns the amount of tax to charge based on the subtotal (rounded to two decimal places).</returns>
        public decimal GetSaleTax()
        {
            return Math.Round(GetSubTotal() * GetSalesTaxRate(), 2);
        }

        /// <summary>
        /// Returns the sum of the subtotal and taxes.
        /// </summary>
        /// <returns>Returns the sum of the subtotal and taxes.</returns>
        public decimal GetTotal()
        {
            return GetSubTotal() + GetSaleTax();
        }

        /// <summary>
        /// Returns the difference of the total and trade-in amount (rounded to two decimal places).
        /// </summary>
        /// <returns></returns>
        public decimal GetAmountDue()
        {
            return Math.Round(GetTotal() - GetTradeInAmount(), 2);
        }
    }
}

