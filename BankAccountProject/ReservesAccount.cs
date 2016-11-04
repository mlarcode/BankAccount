using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class ReservesAccount: Account_Types
    {
        static void Main()
        {
            Console.WriteLine(CompoundInterest(5000, 0.20, 12, 1));
        }

        /// <summary>
        /// CompoundInterest.
        /// </summary>
        static double CompoundInterest(double principal,
        double interestRate,
        int timesPerYear,
        double years)
        {
            // (1 + r/n)
            double body = 1 + (interestRate / timesPerYear);

            // nt
            double exponent = timesPerYear * years;

            // P(1 + r/n)^nt
            return principal * Math.Pow(body, exponent);







        }
    }
}
