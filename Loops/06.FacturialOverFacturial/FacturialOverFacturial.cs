using System;

class FacturialOverFacturial
{
    static void Main()
    {
        Console.Write("Enter value of N: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter value of K: ");
        double k = double.Parse(Console.ReadLine());

        double facN = 1;
        double facK = 1;

        do
        {
            facN *= n;
            n--;
        }
        while (n > 0);

        do
        {
            facK *= k;
            k--;
        }
        while (k > 0);

        Console.WriteLine("Result: {0}", facN / facK);
    }
}
