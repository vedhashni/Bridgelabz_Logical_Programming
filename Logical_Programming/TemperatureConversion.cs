using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{

    /// <summary>
    /// To find the temperature conversion
    /// </summary>
    class TemperatureConversion
    {
        public static void Conversion()

        {
            Console.WriteLine("Enter the Celsius:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());

            double m = (c * 9 / 5) + 32;
            double n = (f - 32) * 5 / 9;
            Console.WriteLine("Celusis To Fahrenheit Temperature : " + Math.Round(m));
            Console.WriteLine("Fahrenheit To Celusis Temperature : " + Math.Round(n));
        }
    }
}
