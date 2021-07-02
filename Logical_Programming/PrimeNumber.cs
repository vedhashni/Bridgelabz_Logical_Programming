using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To find the prime number
    /// </summary>
    class PrimeNumber
    {
        public static void FindingPrime()
        {
            Console.WriteLine("Enter a lower bound");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a higher bound");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int i = l; i <= h; i++)
            {
                int m = 2;
                int isPrime = 1;
                while (m < i)
                {
                    if (i % m == 0)
                    {
                        isPrime = 0;
                    }
                    m++;
                }
                if (isPrime == 1 && i != 1)
                {
                    Console.WriteLine("Number is prime:" + i);
                }
            }
        }
    }
}
