using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("{0} {1}", num2, num1);
        }

        else
        {
            Console.WriteLine("{0} {1}", num1, num2);
        }
    }
}
