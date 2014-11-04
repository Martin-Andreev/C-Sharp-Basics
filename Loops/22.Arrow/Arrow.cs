using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dotsOut = n / 2;
        int dotsIn = n - 2;
        int ds = n;


        Console.Write(new string('.', dotsOut));
        Console.Write(new string('#', ds));
        Console.WriteLine(new string('.', dotsOut));

        ds = 1;

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', dotsOut));
            Console.Write(new string('#', ds));
            Console.Write(new string('.', dotsIn));
            Console.Write(new string('#', ds));
            Console.WriteLine(new string('.', dotsOut));
        }

        ds = (n / 2) + 1;

        Console.Write(new string('#', ds));
        Console.Write(new string('.', dotsIn));
        Console.WriteLine(new string('#', ds));

        dotsOut = 1;
        dotsIn = (n * 2) - 5;
        ds = 1;

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', dotsOut));
            Console.Write(new string('#', ds));
            Console.Write(new string('.', dotsIn));
            Console.Write(new string('#', ds));
            Console.WriteLine(new string('.', dotsOut));

            dotsOut++;
            dotsIn -= 2;
        }

        ds = 1;

        Console.Write(new string('.', dotsOut));
        Console.Write(new string('#', ds));
        Console.WriteLine(new string('.', dotsOut));
    }
}
