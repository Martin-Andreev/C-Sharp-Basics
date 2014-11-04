using System;

class BitModifier
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Select bit: ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Input value of the bit (0 or 1): ");
        int value = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            string p = Convert.ToString(num, 2);
            Console.WriteLine(p);
            num = num & ~(1 << position);
            string z = Convert.ToString(num, 2);
            Console.WriteLine(z);
            Console.WriteLine("Result: {0}", num);
        }

        else
        {
            num = num | (1 << position);
            Console.WriteLine("Result: {0}", num);
        }
    }
}
