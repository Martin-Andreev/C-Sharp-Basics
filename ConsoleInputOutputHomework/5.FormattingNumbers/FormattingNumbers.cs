using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("First number(0 <= a <= 500: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10:X}|{1:X}|{2,10:0.##}|{3,-10:0.###}|", a, Convert.ToString(a, 2).PadLeft(10,'0'), b, c);
    }
}
