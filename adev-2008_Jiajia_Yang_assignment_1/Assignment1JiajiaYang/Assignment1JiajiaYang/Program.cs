using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yang.Jiajia.Business;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-01-10
 * Updated: 2023-01-11
 */

namespace Yang.Jiajia.RRCAG 
{
    /// <summary>
    /// This program will include implementation to test the following members of the SalesQuote class:
    /// + SalesQuote(decimal, decimal, decimal)
    /// + SetTradeInAmount(decimal) : void
    /// + GetExteriorFinishCost() : decimal
    /// + GetTotal() : decimal
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int testNumber = 0;
            // Testing Constructor SalesQuote(decimal, decimal, decimal)
            Console.WriteLine("Testing Constructor SalesQuote(decimal, decimal, decimal)\n");
            Console.WriteLine("Test {0}",++testNumber);
            Constructor_VehicleSalePrice_Initialize();

            Console.WriteLine("Test {0}", ++testNumber);
            Constructor_tradeInAmount_Initialize();

            Console.WriteLine("Test {0}", ++testNumber);
            Constructor_salesTaxRate_Initialize();

            // Testing method SetTradeInAmount(decimal)
            testNumber= 0;
            Console.WriteLine("Testing method SetTradeInAmount(decimal)\n");
            Console.WriteLine("Test {0}", ++testNumber);
            SetTradeInAmount_Update();

            // Testing method GetExteriorFinishCost()
            testNumber = 0;
            Console.WriteLine("Testing method GetExteriorFinishCost()\n");
            Console.WriteLine("Test {0}", ++testNumber);
            GetExteriorFinishCost_Standard();

            Console.WriteLine("Test {0}", ++testNumber);
            GetExteriorFinishCost_Pearlized();

            Console.WriteLine("Test {0}", ++testNumber);
            GetExteriorFinishCost_Custom();

            // Testing method GetTotal()
            testNumber = 0;
            Console.WriteLine("Testing method GetTotal()\n");
            Console.WriteLine("Test {0}", ++testNumber);
            GetTotal_AccessoriesChosen_ExteriorFinishChosen_Cost1();

            Console.WriteLine("Test {0}", ++testNumber);
            GetTotal_AccessoriesChosen_ExteriorFinishChosen_Cost2();

            Console.WriteLine("Test {0}", ++testNumber);
            GetTotal_AccessoriesChosen_ExteriorFinishChosen_Cost3();

        }

        /// <summary>
        /// Initialize the selling price of the vehicle being sold.
        /// Test data: vehicleSalePrice = 50000, tradeInAmount = 5000, salesTaxRate = 0.12
        /// Expected： 50000.00
        /// Actual: 50000.00
        /// </summary>
        static void Constructor_VehicleSalePrice_Initialize()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;

            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //Confirm
            decimal expected = vehicleSalePrice;
            decimal actual = sales1.GetVehicleSalePrice();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Initialize the amount offered to the customer for the trade in of their vehicle.
        /// Test data: vehicleSalePrice = 50000, tradeInAmount = 5000, salesTaxRate = 0.12
        /// Expected： 50000.00
        /// Actual: 50000.00
        /// </summary>
        static void Constructor_tradeInAmount_Initialize()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;

            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //Confirm
            decimal expected = tradeInAmount;
            decimal actual = sales1.GetTradeInAmount();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Initialize the tax rate applied to the sale of a vehicle.
        /// Test data: vehicleSalePrice = 50000, tradeInAmount = 5000, salesTaxRate = 0.12
        /// Expected： 50000.00
        /// Actual: 50000.00
        /// </summary>
        static void Constructor_salesTaxRate_Initialize()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;

            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            //Confirm
            decimal expected = salesTaxRate;
            decimal actual = sales1.GetSalesTaxRate();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Update the trade in amount.
        /// Test data: vehicleSalePrice = 50000, tradeInAmount = 5000, salesTaxRate = 0.12, newTradeInAmount = 1000
        /// Expected： 1000.00
        /// Actual: 1000.00
        /// </summary>
        static void SetTradeInAmount_Update()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal newTradeInAmount = 1000;
            decimal salesTaxRate = 0.12M;

            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            sales1.SetTradeInAmount(newTradeInAmount);
            
            //Confirm
            decimal expected = newTradeInAmount;
            decimal actual = sales1.GetTradeInAmount();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Get the exterior finish chosen for the vehicle. 
        /// Test data: exteriorFinishChosen=ExteriorFinish.Standard
        /// Expected： 202.02
        /// Actual: 202.02
        /// </summary>
        static void GetExteriorFinishCost_Standard()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;
            Accessories accessoriesChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;
            ExteriorFinish newExteriorFinishChosen = ExteriorFinish.Standard;


            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            sales1.SetExteriorFinishChosen(newExteriorFinishChosen);

            //Confirm
            decimal expected = 202.02M;
            decimal actual = sales1.GetExteriorFinishCost();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Get the exterior finish chosen for the vehicle. 
        /// Test data: exteriorFinishChosen=ExteriorFinish.Pearlized
        /// Expected： 404.04
        /// Actual: 404.04
        /// </summary>
        static void GetExteriorFinishCost_Pearlized()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;
            Accessories accessoriesChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;
            ExteriorFinish newExteriorFinishChosen = ExteriorFinish.Pearlized;


            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            sales1.SetExteriorFinishChosen(newExteriorFinishChosen);

            //Confirm
            decimal expected = 404.04M;
            decimal actual = sales1.GetExteriorFinishCost();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Get the exterior finish chosen for the vehicle. 
        /// Test data: exteriorFinishChosen=ExteriorFinish.Custom
        /// Expected： 606.06
        /// Actual: 606.06
        /// </summary>
        static void GetExteriorFinishCost_Custom()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;
            Accessories accessoriesChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;
            ExteriorFinish newExteriorFinishChosen = ExteriorFinish.Custom;


            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            sales1.SetExteriorFinishChosen(newExteriorFinishChosen);

            //Confirm
            decimal expected = 606.06M;
            decimal actual = sales1.GetExteriorFinishCost();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Get the sum of the subtotal and taxes when  accessories chose StereoSystem and exteriorFinish chose none.
        /// Teat data:vehicleSalePrice = 50000, tradeInAmount = 5000, salesTaxRate = 0.12 accessoriesChosen = Accessories.StereoSystem exteriorFinishChosen = ExteriorFinish.None
        /// Expected： 56565.66
        /// Actual: 56565.66
        /// </summary>
        static void GetTotal_AccessoriesChosen_ExteriorFinishChosen_Cost1()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;
            Accessories accessoriesChosen = Accessories.None;
            Accessories newAccessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            sales1.SetAccessoriesChosen(newAccessoriesChosen);

            //Confirm
            decimal expected = 56565.66M;
            decimal actual = sales1.GetTotal();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Get the sum of the subtotal and taxes when  accessories chose Leather Interior and exteriorFinish chose none.
        /// Teat data:vehicleSalePrice = 50000, tradeInAmount = 5000, salesTaxRate = 0.12 accessoriesChosen = Accessories.LeatherInterior exteriorFinishChosen = ExteriorFinish.None
        /// Expected： 57131.31
        /// Actual: 57131.31
        /// </summary>
        static void GetTotal_AccessoriesChosen_ExteriorFinishChosen_Cost2()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;
            Accessories accessoriesChosen = Accessories.None;
            Accessories newAccessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            sales1.SetAccessoriesChosen(newAccessoriesChosen);

            //Confirm
            decimal expected = 57131.31M;
            decimal actual = sales1.GetTotal();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
        }

        /// <summary>
        /// Get the sum of the subtotal and taxes when  accessories chose Computer Navigation and exteriorFinish chose none.
        /// Teat data:vehicleSalePrice = 50000, tradeInAmount = 5000, salesTaxRate = 0.12 accessoriesChosen = Accessories.ComputerNavigation exteriorFinishChosen = ExteriorFinish.None
        /// Expected： 57131.31
        /// Actual: 57131.31
        /// </summary>
        static void GetTotal_AccessoriesChosen_ExteriorFinishChosen_Cost3()
        {
            //Set
            decimal vehicleSalePrice = 50000;
            decimal tradeInAmount = 5000;
            decimal salesTaxRate = 0.12M;
            Accessories accessoriesChosen = Accessories.None;
            Accessories newAccessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            //Act
            SalesQuote sales1 = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            sales1.SetAccessoriesChosen(newAccessoriesChosen);

            //Confirm
            decimal expected = 57696.97M;
            decimal actual = sales1.GetTotal();

            Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
            // wait for exit
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        
    }
}
