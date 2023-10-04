using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Yang.Jiajia.Business;

namespace Yang.Jiajia.Business.Testing
{
   
    [TestClass]
    public class FinancialTest
    {
        /*
         * GetPayment(decimal, int, decimal):decimal Method
         */

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativeRate_Exception()
        {
            //Arrange
            decimal rate = -0.1m;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal actual = payment;

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_GreaterThanOneRate_Exception()
        {
            //Arrange
            decimal rate = 1.1m;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal actual = payment;

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativeNumberOfPaymentPeriods_Exception()
        {
            //Arrange
            decimal rate = 0.1m;
            int numberOfPaymentPeriods = -60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal actual = payment;

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_ZeroNumberOfPaymentPeriods_Exception()
        {
            //Arrange
            decimal rate = 0.1m;
            int numberOfPaymentPeriods = 0;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal actual = payment;

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_ZeroPresentValue_Exception()
        {
            //Arrange
            decimal rate = 0.1m;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 0;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal actual = payment;

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NegativePresentValue_Exception()
        {
            //Arrange
            decimal rate = 0.1m;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = -10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal actual = payment;

        }

        [TestMethod]
        public void GetPayment_ZeroRate_ReturnState()
        {
            //Arrange
            decimal rate = 0;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal expected = 166.67m;
            decimal actual = payment;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPayment_InvalidRate_ReturnState()
        {
            //Arrange
            decimal rate = 0.1m;
            int numberOfPaymentPeriods = 60;
            decimal presentValue = 10000m;

            //Act
            decimal payment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
            decimal expected = 1003.30m;
            decimal actual = payment;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        












    }
}
