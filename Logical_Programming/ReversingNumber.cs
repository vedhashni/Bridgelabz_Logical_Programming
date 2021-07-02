using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To reverse the number
    /// </summary>
    class ReversingNumber
    {
        // Function is used to reverse the number
        public static void revnum()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem, rev = 0;
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }

            Console.WriteLine("Reversed Number is : {0} ", rev);
        }
    }
}
