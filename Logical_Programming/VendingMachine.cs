using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    class VendingMachine
    {
        public static void Generat()
        {
            Console.WriteLine("Enter the amount");
            int a = Convert.ToInt32(Console.ReadLine());
            Minnotes(a);
        }
        private static void Minnotes(int a)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] count = new int[notes.Length];
            for (int i = 0; i < notes.Length; i++)
            {
                if (a >= notes[i])
                {
                    count[i] = a / notes[i];
                    a = a - (count[i] * notes[i]);
                    if (a < 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Currency count....");
            for (int b = 0; a < notes.Length; a++)
            {
                if (count[b] != 0)
                {
                    Console.WriteLine(notes[b] + "--->" + count[b]);
                }
            }
        }
    }
}
