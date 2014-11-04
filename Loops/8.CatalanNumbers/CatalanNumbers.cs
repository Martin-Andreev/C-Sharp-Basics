using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter value of N: ");
        double n = double.Parse(Console.ReadLine());

        double fact = 2 * n;
        double numinator = 1;

        do
        {
            numinator *= fact;
            fact--;
        } while (fact > 0);

        double a = n + 1;
        double factA = 1;

        do
        {
            factA *= a;
            a--;
        } while (a > 0);

        double factN = 1;

        do
        {
            factN *= n;
            n--;
        } while (n > 0);

        Console.WriteLine("Answer: " + numinator / (factA * factN));
    }
}
