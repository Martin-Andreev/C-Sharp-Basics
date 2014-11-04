using System;

class MoonGravitation
{
    static void Main()
    {
        Console.Write("Input your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * (17.0 / 100.0);
        Console.WriteLine("Your moon weight is: {0}", moonWeight);
    }
}
