using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Size of the array: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arr = new int[size];

        ArrayInput(arr);

        NumbersAscedingOrder(arr);
    }

    private static void NumbersAscedingOrder(int[] arr)
    {
        int minNum;
        int tempNum;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            minNum = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minNum])
                {
                    minNum = j;
                }
            }
            tempNum = arr[i];
            arr[i] = arr[minNum];
            arr[minNum] = tempNum;
        }

        Console.Write("The numbers in ascending order: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    private static void ArrayInput(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
}