using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Yang.Jiajia.Business;
using System.ComponentModel;

namespace Yang.Jiajia.Business.Testing
{
    [TestClass]
    public class SalesQuoteTest
    {
        /*
         *Constructor1: SalesQuote(decimal, decimal, decimal, Accessories, ExteriorFinish)
         */

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeVehicleSalePrice_Exception()
        {

            //Arrange
            decimal vehicleSalePrice = -10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_ZeroVehicleSalePrice_Exception()
        {

            //Arrange
            decimal vehicleSalePrice = 0;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeTradeInAmount_Exception()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = -500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeSalesTaxRate_Exception()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = -0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GraterThanOneSalesTaxRate_Exception()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = -500m;
            decimal salesTaxRate = 12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);


        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor1_InvalidAccessories_Exception()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = (Accessories)99;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);


        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void Constructor1_InvalidExteriorFinish_Exception()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = (ExteriorFinish)99;

            //Act
            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);


        }

        [TestMethod]
        public void Constructor1_VehicleSalePrice_Initalized()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            decimal expected = 10000m;
            decimal actual = (decimal)target.GetField("vehicleSalePrice");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Constructor1_PositiveTradeInAmount_Initalized()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            decimal expected = 500m;
            decimal actual = (decimal)target.GetField("tradeInAmount");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Constructor1_ZeroTradeInAmount_Initalized()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 0;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("tradeInAmount");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Constructor1_SalesTaxRate_Initalized()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            decimal expected = 0.12m;
            decimal actual = (decimal)target.GetField("salesTaxRate");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Constructor1_ZeroSalesTaxRate_Initalized()
        {

            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("salesTaxRate");

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Constructor1_AccessoriesChosen_Initalized()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            Accessories expected = Accessories.ComputerNavigation;
            Accessories actual = (Accessories)target.GetField("accessoriesChosen");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor1_ExteriorFinishChosen_Initalized()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            ExteriorFinish expected = ExteriorFinish.Standard;
            ExteriorFinish actual = (ExteriorFinish)target.GetField("exteriorFinishChosen");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /*
         *Constructor2: SalesQuote(decimal, decimal, decimal)
         */

        [TestMethod]
        public void Constructor2_AccessoriesChosenIsNone_Initialized()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(sales);
            Accessories expected = Accessories.None;
            Accessories actual = (Accessories)target.GetField("accessoriesChosen");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor2_ExteriorFinishChosenIsNone_Initalized()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(sales);
            ExteriorFinish expected = ExteriorFinish.None;
            ExteriorFinish actual = (ExteriorFinish)target.GetField("exteriorFinishChosen");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /*
         * VehicleSalePrice property
         */

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VehicleSalePriceProperty_NegativeValue_Excepiton()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            sales.VehicleSalePrice = -1m;
            decimal actual = sales.VehicleSalePrice;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VehicleSalePrice_ZeroValue_Excepiton()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            sales.VehicleSalePrice = 0;
            decimal actual = sales.VehicleSalePrice;
        }

        [TestMethod]
        public void VehicleSalePricePropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            decimal expected = 10000m;
            decimal actual = sales.VehicleSalePrice;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VehicleSalePricePropertySet_PostiveValue_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(sales);
            sales.VehicleSalePrice = 20000m;
            decimal expected = 20000m;
            decimal actual = (decimal)target.GetField("vehicleSalePrice");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VehicleSalePricePropertySet_NegativeValue_StateNotUpdate()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            try
            {
                //Act
                sales.VehicleSalePrice = -1m;
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                decimal expected = 10000m;
                decimal actual = (decimal)target.GetField("vehicleSalePrice");
                Assert.AreEqual(expected, actual);

            }

        }

        [TestMethod]
        public void VehicleSalePricePropertySet_ZeroValue_StateNotUpdate()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            try
            {
                //Act
                sales.VehicleSalePrice = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                decimal expected = 10000m;
                decimal actual = (decimal)target.GetField("vehicleSalePrice");
                Assert.AreEqual(expected, actual);

            }

        }


 

        /*
         * TradeInAmount property
         */

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TradeInAmountProperty_NegativeValue_Excepiton()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            sales.TradeInAmount = -1m;
            decimal actual = sales.TradeInAmount;
        }

        [TestMethod]
        public void TradeInAmountePropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            decimal expected = 500m;
            decimal actual = sales.TradeInAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TradeInAmountPropertySet_PostiveValue_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(sales);
            sales.TradeInAmount = 99m;
            decimal expected = 99m;
            decimal actual = (decimal)target.GetField("tradeInAmount");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TradeInAmountPropertySet_ZeroValue_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(sales);
            sales.TradeInAmount = 0;
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("tradeInAmount");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TradeInAmountPropertySet_NegativeValue_StateNotUpdate()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            try
            {
                //Act
                sales.TradeInAmount = -1m;
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                decimal expected = 500m;
                decimal actual = (decimal)target.GetField("tradeInAmount");
                Assert.AreEqual(expected, actual);

            }

        }

        /*
         * AccessoriesChosen property
         */

        [TestMethod]
        public void AccessoriesChosenPropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            Accessories expected = Accessories.ComputerNavigation;
            Accessories actual = sales.AccessoriesChosen;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void AccessoriesChosenProperty_InvalidValue_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = (Accessories)99;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            Accessories actual = sales.AccessoriesChosen;

        }

        [TestMethod]
        public void AccessoriesChosenPropertySet_ValidValue_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            sales.AccessoriesChosen = Accessories.LeatherInterior;
            Accessories expected = Accessories.LeatherInterior;
            Accessories actual = (Accessories)target.GetField("accessoriesChosen");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoriesChosenPropertySet_InvalidValue_StateNotUpdate()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            try
            {
                //Act
                sales.AccessoriesChosen = (Accessories)99;
            }
            catch (InvalidEnumArgumentException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                Accessories expected = Accessories.ComputerNavigation;
                Accessories actual = (Accessories)target.GetField("accessoriesChosen");
                Assert.AreEqual(expected, actual);

            }

        }




        /*
         * ExteriorFinishChosen property
         */

        [TestMethod]
        public void ExteriorFinishChosenPropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            ExteriorFinish expected = ExteriorFinish.Standard;
            ExteriorFinish actual = sales.ExteriorFinishChosen;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEnumArgumentException))]
        public void ExteriorFinishChosenProperty_InvalidValue_Exception()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = (ExteriorFinish)99;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            ExteriorFinish actual = sales.ExteriorFinishChosen;

        }

        [TestMethod]
        public void ExteriorFinishChosenPropertySet_ValidValue_UpdateState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            PrivateObject target = new PrivateObject(sales);
            sales.ExteriorFinishChosen = ExteriorFinish.Pearlized;
            ExteriorFinish expected = ExteriorFinish.Pearlized;
            ExteriorFinish actual = (ExteriorFinish)target.GetField("exteriorFinishChosen");

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ExteriorFinishChosenPropertySet_InvalidValue_StateNotUpdate()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            try
            {
                //Act
                sales.ExteriorFinishChosen = (ExteriorFinish)99;
            }
            catch (InvalidEnumArgumentException)
            {
                //Assert
                PrivateObject target = new PrivateObject(sales);
                ExteriorFinish expected = ExteriorFinish.Standard;
                ExteriorFinish actual = (ExteriorFinish)target.GetField("exteriorFinishChosen");
                Assert.AreEqual(expected, actual);

            }

        }


        /*
         * AccessoryCost property
         */

        [TestMethod]
        public void AccessoryCostPropertyGet_StereoSystem_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 505.05m;
            decimal actual = sales.AccessoryCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoryCostPropertyGet_LeatherInterior_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1010.10m;
            decimal actual = sales.AccessoryCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoryCostPropertyGet_ComputerNavigation_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1515.15m;
            decimal actual = sales.AccessoryCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoryCostPropertyGet_AllChosen_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 3030.30m;
            decimal actual = sales.AccessoryCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AccessoryCostPropertyGet_NoneChosen_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 0;
            decimal actual = sales.AccessoryCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }



        /*
         * FinishCost property
         */

        [TestMethod]
        public void FinishCostPropertyGet_Standard_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 202.02m;
            decimal actual = sales.FinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FinishCostPropertyGet_Pearlized_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 404.04m;
            decimal actual = sales.FinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FinishCostPropertyGet_Custom_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 606.06m;
            decimal actual = sales.FinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FinishCostPropertyGet_NoneChosen_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 0;
            decimal actual = sales.FinishCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * TotalOptions property
         */

        [TestMethod]
        public void TotalOptionsPropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1717.17m;
            decimal actual = sales.TotalOptions;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * SubTotal property
         */

        [TestMethod]
        public void SubTotalPropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 11717.17m;
            decimal actual = sales.SubTotal;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * SalesTax property
         */

        [TestMethod]
        public void SalesTaxPropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 1406.06m;
            decimal actual = sales.SalesTax;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * Total property
         */

        [TestMethod]
        public void TotalPropertyGet_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 13123.23m;
            decimal actual = sales.Total;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * AmountDue Property
         */

        [TestMethod]
        public void AmountDueProperty_ReturnState()
        {
            //Arrange
            decimal vehicleSalePrice = 10000m;
            decimal tradeInAmount = 500m;
            decimal salesTaxRate = 0.12m;
            Accessories accessoriesChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            //Act
            SalesQuote sales = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expected = 12623.23m;
            decimal actual = sales.AmountDue;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        









    }


}   
