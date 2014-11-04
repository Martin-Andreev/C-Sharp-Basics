using System;

class Calculations
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double iFactorial = 1;
        double S = 1;

        //S = 1 + 1!/x + 2!/x2 + … + n!/xn

        for (int i = 1; i <= n; i++)
        {
            iFactorial *= i;
            S += iFactorial / Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}", S);
    }
}
