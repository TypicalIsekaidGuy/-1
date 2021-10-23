using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            string a = "";
            for (int i = 0; i < m; i++)
            {
                a += "*";
                Console.WriteLine($"{a}");
            }
        }
    }
}
