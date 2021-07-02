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
                // '3' - is used to find the prime number in a range
                // '4' -  is used to reverse a number
                // '5' - is used to generate distinct coupon number
                // '6' - is used to find the elapsed time
                // '7' - is used to find the minimaal notes
                // '8' - is used to find the day of the week
                // '9' - is used to find the temperature conversion celsius to fahrenheit
                // '10' - is used to find the monthly payment
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
                        PrimeNumber.FindingPrime();
                        break;

                    case 4:
                        ReversingNumber.revnum();
                        break;

                    case 5:
                        CouponNumber.GeneratingCouponNum();
                        break;

                    case 6:
                        StopWatch.elapsed();
                        break;

                    case 7:
                        VendingMachine.Generat();
                        break;

                    case 8:
                        Day.dayofweek();
                        break;

                    case 9:
                        TemperatureConversion.Conversion();
                        break;

                    case 10:
                        MonthlyPayment.calculatePayment();
                        break;

                    case 11:
                        SquareRoot.Root();
                        break;

                    case 12:
                        BinaryConversion.bincon();
                        break;

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
