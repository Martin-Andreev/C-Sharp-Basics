using System;

class PrintMyAge
{
    static void Main()
    {
        Console.Write("How old are you: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old!", age + 10);
    }
}
