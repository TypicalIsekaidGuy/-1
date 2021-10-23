using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            int i = 1;
            do
            {
                i++;
                sum *= i;

            } while (i < p);
            Console.WriteLine($"{sum}");
        }
    }
}