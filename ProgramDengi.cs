using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите на сколько клиент скупил товара:");
            int roflan = Convert.ToInt32(Console.ReadLine());
            switch (roflan)
            {
                case > 500 when roflan < 1000:
                    Console.WriteLine($"Всего покупатель заплатит {roflan * 0.97}");
                    break;
                case > 1000:
                    Console.WriteLine($"Всего покупатель заплатит {roflan * 0.95}");
                    break;
                default:
                    Console.WriteLine($"Всего покупатель заплатит {roflan}");
                    break;
            }
        }
    }
}