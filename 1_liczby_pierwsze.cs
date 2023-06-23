using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Podaj liczbę n, aby wyświetlić pożądaną ilość liczb naturalnych w kolejności od najmniejszej do największej: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int number = 2;

        Console.WriteLine($"Twoje liczby pierwsze to:");

        while (count < n)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                count++;
            }

            number++;
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}