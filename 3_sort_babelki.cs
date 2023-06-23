using System;

class BubbleSort
{
    static void Main()
    {
        Console.Write("Podaj liczby oddzielone spacjami: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');
        int[] arr = Array.ConvertAll(numbers, int.Parse);


        BubbleSortAlgorithm(arr);
        PrintArray(arr);
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}