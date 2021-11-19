using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && x < 4)
            {
                Console.WriteLine("x входит");
            }
            else
            {

                Console.WriteLine("x не входит");
            }
            if (y > 0 && y < 4)
            {
                Console.WriteLine("y входит");
            }
            else
            {

                Console.WriteLine("y не входит");
            }
            if (z > 0 && z < 4)
            {
                Console.WriteLine("z входит");
            }
            else
            {

                Console.WriteLine("z не входит");
            }
        }
    }
}
