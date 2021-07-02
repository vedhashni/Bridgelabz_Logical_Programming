using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To find the the decimal to binary conversion
    /// </summary>
    class BinaryConversion
    {
        public static void bincon()
        {
            Console.WriteLine("Enter a decimal value");
            int deci = Utility.ReadInput();
            int i;
            int[] myArr = new int[15];
            for (i = 0; deci > 0; i++)
            {
                myArr[i] = deci % 2;
                deci = deci / 2;
            }
            Console.WriteLine("Binary Representation:");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(myArr[i]);
            }
        }
    }
}
