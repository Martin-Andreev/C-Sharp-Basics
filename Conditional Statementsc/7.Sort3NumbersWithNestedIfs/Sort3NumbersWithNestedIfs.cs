using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        double biggest = 0;
        double medium = 0;
        double smallest = 0;

        if ((num1 > num2) && (num1 > num3))
        {
            if (num2 > num3)
            {
                biggest = num1;
                medium = num2;
                smallest = num3;
            }

            else
            {
                biggest = num1;
                medium = num3;
                smallest = num2;
            }
        }

        else if ((num2 > num1) && (num2 > num3))
        {
            if (num1 > num3)
            {
                biggest = num2;
                medium = num1;
                smallest = num3;
            }

            else
            {
                biggest = num2;
                medium = num3;
                smallest = num1;
            }
        }

        else
        {
            if (num1 > num2)
            {
                biggest = num3;
                medium = num1;
                smallest = num2;
            }

            else
            {
                biggest = num3;
                medium = num2;
                smallest = num1;
            }
        }

        Console.WriteLine("{0} {1} {2}", biggest, medium, smallest);
    }
}
