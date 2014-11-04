using System;

class ZeroSubset
{
    static void Main()
    {
        int[] arr = new int[5];
        int currentSum = 0;

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                currentSum = currentSum + arr[j];

                if (arr[i] + currentSum == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", arr[i], arr[j]);
                }
            }
        }
    }
}
