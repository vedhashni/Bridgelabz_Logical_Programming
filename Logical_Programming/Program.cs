using System;

namespace Logical_Programming
{
    /// <summary>
    /// UC1 - To find fibonacci series
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programming!");

            while (true)
            {
                // '1' - is used to find the Fibonacci series

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Program.Fibonacci(num);
                        break;

                    case 2:
                        return;
                }
            }
        }

        // Function to find the fibonacci series

        public static void Fibonacci(int num)
        {
            int f1 = 0;
            int f2 = 1;
            int s = 0;
            for(int i=2;i<num;i++)
            {
                s = f1 + f2;
                Console.Write("{0}", s);
                f1 = f2;
                f2 = s;
            }
        }
    }
}
