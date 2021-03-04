using System;
using System.Collections.Generic;
using System.Text;

namespace Taylor.Travis.Business
{
    public static class Financial
    {
        /// <summary>
        /// Returns payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// </summary>
        /// <param name="rate">Interest rate per period</param>
        /// <param name="numberOfPaymentPeriods">Number of payment periods in the annuity.</param>
        /// <param name="presentValue">Present value or lump sum that a series of payments to be paid in the future is worth now.</param>
        /// <returns>Returns payment amount per payment period in an annuity.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when rate is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when rate is greater than one.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when number of payments is less than or equal to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when present value is less than or equal to zero.</exception>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods, decimal presentValue)
        {
            if (rate <= 0)
                throw new ArgumentOutOfRangeException("rate", "The argument cannot be less than or equal to 0.");
            else if (rate > 1)
                throw new ArgumentOutOfRangeException("rate", "The argument cannot be greater than 1.");
            else if (numberOfPaymentPeriods <= 0)
                throw new ArgumentOutOfRangeException("numberOfPaymentPeriods", "The argument cannot be less than or equal to 0.");
            else if (presentValue <= 0)
                throw new ArgumentOutOfRangeException("presentValue", "The argument cannot be less than or equal to 0.");
   
            // Conditional Operator --> condition ? consequence : alternative 
            // If condition is true, then consequence is the result. If not, then alternative is the result.
            decimal futureValue = 0;
            decimal type = 0;
            return (rate == 0) ? presentValue / numberOfPaymentPeriods : rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));
        }
    }
}
