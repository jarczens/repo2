using System;

class MinMaxElements
{
    static void Main()
    {
        Console.Write("Podaj liczby oddzielone spacjami: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');
        int[] arr = Array.ConvertAll(numbers, int.Parse);

        int min = FindMinimum(arr);
        int max = FindMaximum(arr);

        Console.WriteLine($"Najmniejszy element: {min}");
        Console.WriteLine($"Największy element: {max}");
    }

    static int FindMinimum(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }

    static int FindMaximum(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}