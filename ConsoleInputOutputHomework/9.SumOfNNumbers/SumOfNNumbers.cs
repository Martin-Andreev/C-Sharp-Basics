using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        double sum = 0;
        int count = 1;

        while (num > 0)
        {
            Console.Write("Number {0}: ", count);
            double number = double.Parse(Console.ReadLine());
            sum += number;
            count++;
            num--;
        }

        Console.WriteLine("Result: {0}", sum);
    }
}
