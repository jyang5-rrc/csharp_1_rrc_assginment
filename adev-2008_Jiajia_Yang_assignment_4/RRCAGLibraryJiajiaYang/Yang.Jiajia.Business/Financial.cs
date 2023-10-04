
/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-01-26
 * Updated: 2023-01-26
 */

using System;

namespace Yang.Jiajia.Business
{
    public static class Financial
    {
        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="numberOfPaymentPeriods"></param>
        /// <param name="presentValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods, decimal presentValue)
        {
            decimal futureValue = 0;
            decimal type = 0;
            decimal payment = 0;

            ArgumentOutOfRangeException e;
            if (rate < 0)
            {
                e = new ArgumentOutOfRangeException("rate", rate, "The argument cannot be less than 0.");
                throw e;
            }
            if (rate > 1)
            {
                e = new ArgumentOutOfRangeException("rate", rate, "The argument cannot be greater than 1.");
                throw e;
            }
            if (numberOfPaymentPeriods <= 0)
            {
                e = new ArgumentOutOfRangeException("numberOfPaymentPeriods", numberOfPaymentPeriods, "The argument cannot be less than or equal to 0.");
                throw e;
            }
            if (presentValue <= 0)
            {
                e = new ArgumentOutOfRangeException("presentValue", presentValue, "The argument cannot be less than or equal to 0.");
                throw e;
            }

            if (rate == 0)
                payment = presentValue / numberOfPaymentPeriods;
            else
                payment = rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));

            return Math.Round(payment, 2);
        }
    }
    
}