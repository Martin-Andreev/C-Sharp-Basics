using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Hexadecimal: ");
        string hexa = Console.ReadLine();
        string upperHexa = hexa.ToUpper();
        int hexaNum = 0;
        int reminder = 0;
        int symbolValue = 0;

        for (int i = upperHexa.Length - 1; i >= 0; i--)
        {
            char symbol = upperHexa[i];
            if (char.IsNumber(symbol))
            {
                symbolValue = symbol - '0';
            }
            else
            {
                switch (symbol)
                {
                    case 'A': symbolValue = 10; break;
                    case 'B': symbolValue = 11; break;
                    case 'C': symbolValue = 12; break;
                    case 'D': symbolValue = 13; break;
                    case 'E': symbolValue = 14; break;
                    case 'F': symbolValue = 15; break;
                    default:
                        Console.WriteLine("{0} is nvalid hex symbol", symbol);
                        break;
                }
            }

            hexaNum = hexaNum + symbolValue * (int)(Math.Pow(16, reminder));
            reminder++;
        }
        Console.WriteLine("Decimal: " + hexaNum);
    }
}
