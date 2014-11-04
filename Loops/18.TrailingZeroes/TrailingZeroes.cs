using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger fact = 1;
        int count = 0;


        while (n > 0)
        {
            fact *= n;
            n--;
        }

        while (fact % 10 == 0)
        {
            count++;
            fact = fact / 10; 
        }

        Console.WriteLine(count);
    }
}
