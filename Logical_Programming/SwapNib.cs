using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To find the swap the nibbles
    /// </summary>
    class SwapNib
    {
        public static void swap()
        {
            Console.WriteLine("Enter a value");
            int x = Utility.ReadInput();
            int res = ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
            Console.WriteLine("After swapping a bits " + res);

            Console.WriteLine(isPowerOfTwo(res) ? "Number is power of 2" : "Number is not a power of 2");
        }

        // Method to check if x is power of 2
        static bool isPowerOfTwo(int res)
        {
            // First x in the below expression 
            // is for the case when x is 0
            return res != 0 && ((res & (res - 1)) == 0);

        }
    }
}
