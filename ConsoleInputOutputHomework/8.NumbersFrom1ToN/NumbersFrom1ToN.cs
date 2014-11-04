using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
}
