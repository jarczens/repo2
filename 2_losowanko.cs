using System;

class EvenNumberGenerator
{
    static void Main()
    {
        Console.Write("Podaj ilość liczb parzystych do wylosowania z przedziału [-8, 8]: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int count = 0;

        Console.Write("Wylosowane liczby parzyste (wersja 1): ");
        while (count < n)
        {
            int number = random.Next(-8, 9);
            if (number % 2 == 0)
            {
                Console.Write(number);
                count++;
                if (count < n)
                {
                    Console.Write(", ");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Liczba losowań : {count}");

        count = 0;
        Console.Write("Wylosowane liczby parzyste (wersja 2): ");
        while (count < n)
        {
            int number = random.Next(-4, 5) * 2;
            Console.Write(number);
            count++;
            if (count < n)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Liczba losowań : {count}");
    }
}