using System;
using System.Globalization;
using System.Threading;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)

        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            Console.Write("Enter 1st number: ");
            string input = Console.ReadLine();
            int num1 = int.Parse(input);

            Console.Write("Enter 2nd number: ");
            input = Console.ReadLine();
            int num2 = int.Parse(input);

            Console.Write("Enter 3rd number: ");
            input = Console.ReadLine();
            int num3 = int.Parse(input);

            int sum = num1 + num2 + num3;
            double avg = sum / 3.0;


            Console.Write($"The average is: {avg}");
            Console.WriteLine();







        }
    }
}

