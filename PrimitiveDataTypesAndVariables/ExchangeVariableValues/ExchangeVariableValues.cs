using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp = a;

        Console.WriteLine("Before the exchanging a = {0} and b = {1}", a, b);

        a = b;
        b = temp;

        Console.WriteLine("After the exchanging a = {0} and b = {1}", a, b);

    }
}
