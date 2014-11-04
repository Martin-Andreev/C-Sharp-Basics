using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Decimal: ");
        int decimalNum = int.Parse(Console.ReadLine());
        List<char> outputNumber = new List<char>();

        if (decimalNum == 0)
        {
            Console.WriteLine(0);
        }

        else
        {
            while (decimalNum > 0)
            {
                switch (decimalNum % 16)
                {
                    case 0:
                        outputNumber.Add('0'); break;
                    case 1:
                        outputNumber.Add('1'); break;
                    case 2:
                        outputNumber.Add('2'); break;
                    case 3:
                        outputNumber.Add('3'); break;
                    case 4:
                        outputNumber.Add('4'); break;
                    case 5:
                        outputNumber.Add('5'); break;
                    case 6:
                        outputNumber.Add('6'); break;
                    case 7:
                        outputNumber.Add('7'); break;
                    case 8:
                        outputNumber.Add('8'); break;
                    case 9:
                        outputNumber.Add('9'); break;
                    case 10:
                        outputNumber.Add('A'); break;
                    case 11:
                        outputNumber.Add('B'); break;
                    case 12:
                        outputNumber.Add('C'); break;
                    case 13:
                        outputNumber.Add('D'); break;
                    case 14:
                        outputNumber.Add('E'); break;
                    case 15:
                        outputNumber.Add('F'); break;
                    default: break;
                }
                decimalNum = decimalNum / 16;
            }
            outputNumber.Reverse();

            Console.Write("Hexadecimal: ");
            foreach (var digit in outputNumber)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }
    }
}
