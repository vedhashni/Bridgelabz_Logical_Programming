using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To calculate the monthly payment
    /// </summary>
    class MonthlyPayment
    {
        public static void calculatePayment()
        {
            Console.WriteLine("Enter a principal");
            double principal = Utility.ReadInput();
            Console.WriteLine("Enter a interest amount ");
            double rate = Utility.ReadInput();
            Console.WriteLine("Enter a year");
            double year = Utility.ReadInput();
           

            double r = Math.Round(1 + (rate / 1200), 4);
            double n = 12 * year;
            double monthlyPayment = principal * (Math.Pow(r, n)) - principal;
            Console.WriteLine("Monthly payment " + Math.Round(monthlyPayment));

        }
    }
}
