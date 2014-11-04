using System;

class HexadecimalFormat
{
    static void Main()
    {
        int value = 254;
        Console.WriteLine("0x{0}", value.ToString("X"));
    }
}