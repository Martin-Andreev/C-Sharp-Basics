using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        double temp = 0;

        if (num1 > num2)
        {
            temp = num1;
        }

        else
        {
            temp = num2;
        }

        double result = 0;

        if (temp > num3)
        {
            result = temp;
        }

        else
        {
            result = num3;
        }

        Console.WriteLine(result);
    }
}

