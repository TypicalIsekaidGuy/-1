using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2;
            int n = 6;
            string a = "";
            for (int i = m; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
                Console.WriteLine(" ");
            }
        }
    }
}