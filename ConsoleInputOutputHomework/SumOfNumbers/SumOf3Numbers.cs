using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string firstNum = Console.ReadLine();
        double num1 = double.Parse(firstNum);

        Console.Write("Enter the second number: ");
        string secondNum = Console.ReadLine();
        double num2 = double.Parse(secondNum);

        Console.Write("Enter the third number: ");
        string thirdNum = Console.ReadLine();
        double num3 = double.Parse(thirdNum);

        double sum = num1 + num2 + num3;

        Console.WriteLine("The sum of these three numbers is: {0}", sum);
    }
}
