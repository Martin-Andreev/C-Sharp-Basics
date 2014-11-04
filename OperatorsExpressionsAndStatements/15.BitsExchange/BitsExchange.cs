using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Input a number: ");

        long num = 2521;
        string c = Convert.ToString(num, 2);
        uint mask1 = (1 << 7);
        uint mask2 = (1 << 8);
        long submask1 = num & mask1;
        long submask2 = num & mask2;

        num = (~mask2 & num) | (submask1 << 1);
        num = (~mask1 & num) | (submask2 >> 1);

        string a = Convert.ToString(num, 2);
        Console.WriteLine("Result: {0}", num);


        //long num = int.Parse(Console.ReadLine());

        //uint mask1 = (1 << 3) | (1 << 4) | (1 << 5);
        //uint mask2 = (1 << 24) | (1 << 25) | (1 << 26);
        //long submask1 = num & mask1;
        //long submask2 = num & mask2;

        //num = (~mask2 & num) | (submask1 << 21);
        //num = (~mask1 & num) | (submask2 >> 21);

        //Console.WriteLine("Result: {0}", num);
    }
}
