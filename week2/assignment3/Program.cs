using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");
            string input = Console.ReadLine();
            int seconds = int.Parse(input);
            int hours = seconds / 3600;
            seconds = seconds % 3600;
            int minutes = seconds / 60;
            seconds = seconds % 60;
     
            Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");
            Console.WriteLine();





        }
    }
}
