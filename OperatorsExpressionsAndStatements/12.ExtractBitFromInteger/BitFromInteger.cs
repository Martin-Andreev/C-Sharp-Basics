using System;

class BitFromInteger
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Select bit: ");
        int bit = int.Parse(Console.ReadLine());

        int result = (num >> bit) & 1;
        Console.WriteLine("The {0} bit is: {1}", bit, result);
    }
}