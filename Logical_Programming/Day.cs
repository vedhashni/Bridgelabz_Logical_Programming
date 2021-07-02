using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To find the day of week
    /// </summary>
    class Day
    {
       
        public static void dayofweek()
        {
        List<string> myList = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        Console.WriteLine("Enter the date :");
        int d = Utility.ReadInput();
        Console.WriteLine("Enter the month :");
        int m = Utility.ReadInput();
        Console.WriteLine("Enter the year :");
        int y = Utility.ReadInput();

        int y0 = y - (14 - m) / 12;
         int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
         int m0 = m + 12 * ((14 - m) / 12) - 2;
         int d0 = (d + x + 31 * m0 / 12) % 7;
         Console.WriteLine("Day is :" + d0);
        }
    }
}
