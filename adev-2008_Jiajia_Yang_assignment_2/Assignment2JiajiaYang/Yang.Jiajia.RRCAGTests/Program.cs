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
 * Created: 2023-01-27
 * Updated: 2023-01-27
 */

namespace Yang.Jiajia.RRCAGTests
{
    /// <summary>
    /// This program will include implementation to test the following members of the Financial class:
    /// + GetPayment(decimal, int, decimal) : decimal
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int testNumber = 0;
            // Testing method GetPayment(decimal, int, decimal) : decimal
            Console.WriteLine("Testing method GetPayment(decimal, int, decimal) : decimal\n");
            Console.WriteLine("Test {0}", ++testNumber);
            Method_GetPayment_test1();

            Console.WriteLine("Test {0}", ++testNumber);
            Method_GetPayment_test2();

            Console.WriteLine("Test {0}", ++testNumber);
            Method_GetPayment_test3();

            Console.WriteLine("Test {0}", ++testNumber);
            Method_GetPayment_test4();

            Console.WriteLine("Test {0}", ++testNumber);
            Method_GetPayment_test5();

            Console.WriteLine("Test {0}", ++testNumber);
            Method_GetPayment_test6();

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }

        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// Test data: rate=0.05，numberOfPaymentPeriods=10, presentValue=101010.10
        /// Expected： 500
        /// Actual: 500
        /// </summary>
        static void Method_GetPayment_test1()
        {
            //Set
            decimal rate = 0.05M;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 101010.10M;

            try
            {
                //Act
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

                //Confirm
                decimal expected = 500m;
                Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// Test data: rate=0，numberOfPaymentPeriods=10, presentValue=101010.10
        /// Expected： 500
        /// Actual: 500
        /// </summary>
        static void Method_GetPayment_test2()
        {
            //Set
            decimal rate = 0;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 101010.10M;

            try
            {
                //Act
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

                //Confirm
                decimal expected = 500m;
                Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();

            }
        }

        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// Test data: rate=-0.01，numberOfPaymentPeriods=10, presentValue=101010.10
        /// Expected： The argument cannot be less than or equal to 0.Parameter name: rate Actual value was -0.01.
        /// Actual: The argument cannot be less than or equal to 0.Parameter name: rate Actual value was -0.01.
        /// </summary>
        static void Method_GetPayment_test3()
        {
            //Set
            decimal rate = -0.01m;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 101010.10M;

            

            try
            {
                //Act
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

                //Confirm
                decimal expected = 500m;
                Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Expected: The argument cannot be less than or equal to 0.\nParameter name: rate\nActual value was -0.01.\n");
                Console.WriteLine("Actual:{0}\n", e.Message);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// Test data: rate=1.01，numberOfPaymentPeriods=10, presentValue=101010.10
        /// Expected： The argument cannot be greater than 1.Parameter name: rate Actual value was 1.01.
        /// Actual: The argument cannot be greater than 1.Parameter name: rate Actual value was 1.01.
        /// </summary>
        static void Method_GetPayment_test4()
        {
            //Set
            decimal rate = 1.01m;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 101010.10M;

            try
            {
                //Act
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

                //Confirm
                decimal expected = 500m;
                Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Expected:The argument cannot be greater than 1.\nParameter name: rate\nActual value was 1.01.\n");
                Console.WriteLine("Actual:{0}\n", e.Message);
            }
        }

        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// Test data: rate=0.05，numberOfPaymentPeriods=0, presentValue=101010.10
        /// Expected： The argument cannot be less than or equal to 0.Parameter name: numberOfPaymentPeriods Actual value was 0.
        /// Actual: The argument cannot be less than or equal to 0.Parameter name: numberOfPaymentPeriods Actual value was 0.
        /// </summary>
        static void Method_GetPayment_test5()
        {
            //Set
            decimal rate = 0.05m;
            int numberOfPaymentPeriods = 0;
            decimal presentValue = 101010.10M;

            try
            {
                //Act
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

                //Confirm
                decimal expected = 500m;
                Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Expected:The argument cannot be less than or equal to 0.\nParameter name: numberOfPaymentPeriods\nActual value was 0.\n");
                Console.WriteLine("Actual:{0}\n", e.Message);
            }
        }

        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// Test data: rate=0.05，numberOfPaymentPeriods=10, presentValue=0
        /// Expected： The argument cannot be less than or equal to 0.Parameter name: presentValue Actual value was 0.
        /// Actual: The argument cannot be less than or equal to 0.Parameter name: presentValue Actual value was 0.
        /// </summary>
        static void Method_GetPayment_test6()
        {
            //Set
            decimal rate = 0.05m;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 0;

            try
            {
                //Act
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);

                //Confirm
                decimal expected = 500m;
                Console.WriteLine("Expected:{0}\nActual:{0}\n", expected, actual);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Expected:The argument cannot be less than or equal to 0.\nParameter name: presentValue\nActual value was 0.\n");
                Console.WriteLine("Actual:{0}\n", e.Message);
            }
        }
    }
}
