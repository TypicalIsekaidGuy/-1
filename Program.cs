using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int sum = 0;
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Vashe chislo: {sum / N}");
        }
    }
}