using System;

namespace ProgramPerimetr2Int
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Perimetr(a, b, c)}");
        }
        static int Perimetr(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
