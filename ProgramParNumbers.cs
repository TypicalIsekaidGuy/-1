using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int resultat = 0;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if ((i % 10 == 1) | (i % 10 == 2) | (i % 10 == 3) | (i % 10 == 4) | (i % 10 == 6) | (i % 10 == 7) | (i % 10 == 8) | (i % 10 == 9))
                {
                    resultat += i;
                    count++;
                }
            }
            while (resultat % 10 != 0)
            {
                if ((N % 10 == 1) | (N % 10 == 2) | (N % 10 == 3) | (N % 10 == 4) | (N % 10 == 6) | (N % 10 == 7) | (N % 10 == 8) | (N % 10 == 9))
                {
                    resultat -= N;
                }
                N--;
                count--;
            }
            Console.WriteLine($"{resultat} {count}");
        }
    }
}