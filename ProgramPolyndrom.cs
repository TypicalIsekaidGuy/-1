using System;
class HelloWorld
{
    static void main(string[] args)
    {
        int snus = 0;
        string cock = Convert.ToString(Console.ReadLine());
        string aue ="";
        for (int i = 0; i < (cock.Length); i++)
        {
            if (i != 0)
            {
                aue += cock[i];
            }
            else
            {
                aue += cock[i];
                aue.ToUpper();
            }

        }
        Console.WriteLine($"{aue}");
    }

}