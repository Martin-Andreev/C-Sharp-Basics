using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());
        int a = num / 1000;
        int b = num / 100 % 10;
        int c = num / 10 % 10;
        int d = num % 10;
        int sum = a + b + c + d;
        Console.WriteLine("The sum of digits: {0}", sum);
        Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
    }
}
