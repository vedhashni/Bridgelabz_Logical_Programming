using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To find the Squareroot
    /// </summary>
    class SquareRoot
    {
        public static void Root()
        {
            Console.WriteLine("Enter n value");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter l value");
            double l = Convert.ToDouble(Console.ReadLine());
            double t = n;
            double rootval;
            int count = 0;
            while (true)
            {
                count++;
                rootval = 0.5 * (t + (n / t));
                if (Math.Abs(rootval - t) < l)
                {
                    break;
                }
                t = rootval;
            }
            Console.WriteLine("Root Value is :" + Math.Round(rootval, 2));
        }
    }
}
