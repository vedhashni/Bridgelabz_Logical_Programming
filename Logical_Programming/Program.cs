using System;

namespace Logical_Programming
{
    /// <summary>
    /// UC1 - To find fibonacci series
    /// UC2 - To find the perfect number
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programming!");

            while (true)
            {
                // '1' - is used to find the Fibonacci series
                // '2' - is used to find the perfect number

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Program.Fibonacci(num);
                        break;

                    case 2:
                        Console.WriteLine("Enter the number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Program.perfectnumber(n);
                        break;

                    case 3:
                        return;

                    default:
                        break;

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

        // Fuction to find the perfect number

        public static void perfectnumber(int n)
        {
            int s = 0;
            for(int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    s += i;
                }
            }
            if(s==n)
            {
                Console.WriteLine("{0} is perfect number",n);
            }
            else
            {
                Console.WriteLine("{0} is not perfect number",n);
            }
        }
    }
}
