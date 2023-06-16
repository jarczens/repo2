using System;
using System.Collections.Generic;

class Program
{
    static List<Tuple<int, int>> ZnajdzLiczby(int targetSum)
    {
        List<Tuple<int, int>> pary = new List<Tuple<int, int>>();
        for (int i = 1; i < targetSum; i++)
        {
            int j = targetSum - i;
            if (j > i)
            {
                pary.Add(new Tuple<int, int>(i, j));
            }
        }
        return pary;
    }

    static void Main(string[] args)
    {
        Console.Write("Wprowadź liczbę");
        int target = int.Parse(Console.ReadLine());

        List<Tuple<int, int>> pary = ZnajdzLiczby(target);

        if (pary.Count > 0)
        {
            Console.WriteLine($"Twoje liczby to:");
            foreach (var para in pary)
            {
                Console.WriteLine($"{para.Item1} + {para.Item2} = {target}");
            }
        }
        else
        {
            Console.WriteLine("Nie znaleziono liczb");
        }
    }
}