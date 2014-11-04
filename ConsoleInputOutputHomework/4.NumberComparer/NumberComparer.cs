using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double maxNum = Math.Max(num1, num2);

        Console.WriteLine("Number {0} is greater!", maxNum);
    }
}
