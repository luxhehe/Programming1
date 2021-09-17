using System;
using System.Globalization;
using System.Threading;


namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            Console.Write("Enter a price: ");
            string input = Console.ReadLine();
            double price = double.Parse(input);
            double VAT = price* 0.21;

            Console.WriteLine($"price { price:0.00}, VAT { VAT:0.00}, total { price + VAT:0.00}");
            Console.ReadKey();



        }
    }
}
