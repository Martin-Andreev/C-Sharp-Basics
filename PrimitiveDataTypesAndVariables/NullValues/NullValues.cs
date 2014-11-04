using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt = 5;
        nullDouble = 10;

        Console.WriteLine(nullInt.GetValueOrDefault());
        Console.WriteLine(nullDouble.GetValueOrDefault());
    }
}
