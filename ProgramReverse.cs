using System;
namespace ConsoleApp8
{
    class Snus
    {
        static void Main(string[] args)
        {
            string cock = Convert.ToString(Console.ReadLine());
            string aue = "";
            for (int i = 0; i < (cock.Length); i++)
            {
                aue += cock[(cock.Length) - 1 - i];

            }
            Console.WriteLine(aue);
        }

    }
}