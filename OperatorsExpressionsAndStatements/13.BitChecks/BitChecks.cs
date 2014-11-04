using System;

class BitChecks
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Select bit: ");
        int bit = int.Parse(Console.ReadLine());

        bool bitOne = false;

        if (((num >> bit) & 1) == 1)
        {
            bitOne = true;
            Console.WriteLine("The {0} bit is 1? {1}", bit, bitOne );
        }

        else
        {
            Console.WriteLine("The {0} bit is 1? {1}", bit, bitOne);
        }
        
    }
}
