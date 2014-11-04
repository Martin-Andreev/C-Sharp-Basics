using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Binary: ");
        string binaryNumber = Console.ReadLine();

        char[] arr = binaryNumber.ToCharArray();
        Array.Reverse(arr);

        double decimalNumber = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '1')
            {
                decimalNumber += Math.Pow(2, i);
            }
        }
        Console.WriteLine("Decimal: " + decimalNumber);
    }
}
