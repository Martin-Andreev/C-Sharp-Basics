using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        if (num1 > num2)
        {
            if ((num1 - num2) > eps )
            {
                Console.WriteLine("The numbers are not equal(with precision eps = 0.000001)!");
            }

            else
            {
                Console.WriteLine("The numbers are equal(with precision eps = 0.000001!");
            }
        }

        else if (num2 > num1)
        {
            if ((num2 - num1) > eps)
            {
                Console.WriteLine("The two numbers are not equal(with precision eps = 0.000001)!");
            }

            else
            {
                Console.WriteLine("The two numbers are equal(with precision eps = 0.000001)!");
            }
        }
    }
}
