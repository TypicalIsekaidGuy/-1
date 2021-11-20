using System;
namespace ConsoleApp7
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int snus = 0;
            string cock = Convert.ToString(Console.ReadLine());
            string aue = "";
            for (int i = 0; i < (cock.Length); i++)
            {
                if (i != 0)
                {
                    aue += cock[i];
                }
                else
                {
                    aue += cock[i];
                    aue = aue.ToUpper();
                }

            }
            Console.WriteLine($"{aue}");
        }

    }
}