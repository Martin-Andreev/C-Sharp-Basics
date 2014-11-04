using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(FindGreatestCommonDivisor(num1, num2));
    }

    static int FindGreatestCommonDivisor(int num1, int num2)
    {
        while (num1 != 0 && num2 != 0)
        {
            if (num1 > num2)
                num1 %= num2;
            else
                num2 %= num1;
        }

        if (num1 == 0)
            return num2;
        else
            return num1;
    }
}
