using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logical_Programming
{
    /// <summary>
    /// To find distinct coupon numbers
    /// </summary>
    class CouponNumber
    {
        public static void GeneratingCouponNum()
        {
            Console.WriteLine("Enter start time");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end time");
            int e = Convert.ToInt32(Console.ReadLine());
            int num = e - s;
            int randomcount = 0;

            HashSet<int> mySet = new HashSet<int>();

            while (mySet.Count() < num + 1)
            {
                randomcount++;
                Random random = new Random();
                int r = random.Next(s, e + 1);
                mySet.Add(r);

            }
            foreach (int val in mySet)
            {
                Console.WriteLine(val + " ");
            }

            Console.WriteLine("Random Count : " + randomcount);
        }
    }
}
