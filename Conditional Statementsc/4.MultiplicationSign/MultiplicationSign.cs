using System;

class MultiplicationSign
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        if ((num1 == 0) || (num2 == 0) || (num3 == 0))
        {
            Console.WriteLine("0");
        }

        else if (num1 > 0)
        {
            if (num2 > 0)
            {
                if (num3 > 0)
                {
                    Console.WriteLine("+");
                }

                else
                {
                    Console.WriteLine("-");
                }
            }

            else
            {
                if (num3 > 0)
                {
                    Console.WriteLine("-");
                }

                else
                {
                    Console.WriteLine("+");
                }
            }
        }

        else
        {
            if (num2 > 0)
            {
                if (num3 > 0)
                {
                    Console.WriteLine("-");
                }

                else
                {
                    Console.WriteLine("+");
                }
            }

            else
            {
                if (num3 > 0)
                {
                    Console.WriteLine("+");
                }

                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
