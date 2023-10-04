using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Yang.Jiajia.Business;

namespace Yang.Jiajia.Business.Testing
{
    
    [TestClass]
    public class CarWashInvoiceTest
    {
        /*
         * Constructor1: CarWashInvoice(decimal, decimal, decimal, decimal)
         */

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeProvincialSalesTaxRate_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = -0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal actual = (decimal)target.GetField("provincialSalesTaxRate");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GreaterThanOneProvincialSalesTaxRate_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 1.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal actual = (decimal)target.GetField("provincialSalesTaxRate");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeGoodsAndServiceTaxRate_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = -0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal actual = (decimal)target.GetField("goodsAndServiceTaxRate");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_GreaterThanOneGoodsAndServiceTaxRate_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 1.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal actual = (decimal)target.GetField("goodsAndServiceTaxRate");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativePackageCost_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = -10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal actual = (decimal)target.GetField("packageCost");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor1_NegativeFragranceCost_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = -5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal actual = (decimal)target.GetField("fragranceCost");

        }

        [TestMethod]
        public void Constructor1_PackageCost_Initialized()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 10.00m;
            decimal actual = (decimal)target.GetField("packageCost");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Constructor1_FragranceCost_Initialized()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 5.00m;
            decimal actual = (decimal)target.GetField("fragranceCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * Constructor2:CarWashInvoice(decimal, decimal)
         */
        [TestMethod]
        public void Constructor2_PackageCostIsZero_Initialized()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate);
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("packageCost");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Constructor2_FragranceCostIsZero_Initialized()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate);
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("fragranceCost");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        /*
         * PackageCost Property
         */

        [TestMethod]
        public void PackageCostPropertyGet_ReturnState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal expected = 10.00m;
            decimal actual = carWash.PackageCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PackageCostPropertySet_NegativePackageCost_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = -10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal actual = carWash.PackageCost;
        }


        [TestMethod]
        public void PackageCostPropertySet_PositiveValue_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;
            
            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWash.PackageCost = 20m;
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 20m;
            decimal actual = (decimal)target.GetField("packageCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PackageCostPropertySet_ZeroValue_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWash.PackageCost = 0;
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("packageCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PackageCostPropertySet_NegativeValue_StateNotUpdate()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);

            try
            {
                //Act
                carWash.PackageCost = -20m;

            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWash);
                decimal expected = 10m;
                decimal actual = (decimal)target.GetField("packageCost");

                //Assert
                Assert.AreEqual(expected, actual);
            }


        }


        /*
         * FragranceCost Property
         */

        [TestMethod]
        public void FragranceCostPropertyGet_ReturnState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal expected = 5.00m;
            decimal actual = carWash.FragranceCost;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FragranceCostPropertySet_NegativePackageCost_Exception()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = -5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal actual = carWash.FragranceCost;
        }


        [TestMethod]
        public void FragranceCostPropertySet_PositiveValue_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWash.FragranceCost = 20m;
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 20m;
            decimal actual = (decimal)target.GetField("fragranceCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FragranceCostPropertySet_ZeroValue_UpdateState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            carWash.FragranceCost = 0;
            PrivateObject target = new PrivateObject(carWash);
            decimal expected = 0;
            decimal actual = (decimal)target.GetField("fragranceCost");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FragranceCostPropertySet_NegativeValue_StateNotUpdate()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);

            try
            {
                //Act
                carWash.FragranceCost = -20m;

            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWash);
                decimal expected = 5m;
                decimal actual = (decimal)target.GetField("fragranceCost");

                //Assert
                Assert.AreEqual(expected, actual);
            }


        }


        /*
         * ProvincialSalesTaxCharged Property
         */

        [TestMethod]
        public void ProvincialSalesTaxChargedPropertyGet_ReturnState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal expected = 0;
            decimal actual = carWash.ProvincialSalesTaxCharged;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * GoodsAndServicesTaxCharged Property
         */

        [TestMethod]
        public void GoodsAndServicesTaxChargedPropertyGet_ReturnState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal expected = 0.75m;
            decimal actual = carWash.GoodsAndServicesTaxCharged;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /*
         * SubTotal Property
         */

        [TestMethod]
        public void SubTotalPropertyGet_ReturnState()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.05m;
            decimal goodsAndServiceTaxRate = 0.05m;
            decimal packageCost = 10.00m;
            decimal fragranceCost = 5.00m;

            //Act
            CarWashInvoice carWash = new CarWashInvoice(provincialSalesTaxRate, goodsAndServiceTaxRate, packageCost, fragranceCost);
            decimal expected = 15.00m;
            decimal actual = carWash.SubTotal;

            //Assert
            Assert.AreEqual(expected, actual);
        }

















    }
}
