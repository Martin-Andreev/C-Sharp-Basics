using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());
        double num5 = double.Parse(Console.ReadLine());

        double temp = 0;
        double temp2 = 0;
        double result = 0;
        double maxNum = 0;

        if (num1 > num2)
        {
            temp = num1;
        }

        else
        {
            temp = num2;
        }

        if (num3 > num4)
        {
            temp2 = num3;
        }

        else
        {
            temp2 = num4;
        }

        if (temp >temp2)
        {
            result = temp;
        }

        else
        {
            result = temp2;
        }

        if (result > num5)
        {
            maxNum = result;
        }

        else
        {
            maxNum = num5;
        }

        Console.WriteLine(maxNum);
    }
}
