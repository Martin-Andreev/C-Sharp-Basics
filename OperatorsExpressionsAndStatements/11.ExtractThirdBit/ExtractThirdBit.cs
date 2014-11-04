using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Input a number: ");
        uint num = uint.Parse(Console.ReadLine());
        uint thirdBit = (num >> 3) & 1;
        Console.WriteLine("The bit is: {0}", thirdBit);
    }
}
