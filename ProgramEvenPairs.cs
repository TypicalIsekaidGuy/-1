using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < n-1; i++)
            {
                if (array[i - 1] % 2 == 0 && array[i + 1] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}
