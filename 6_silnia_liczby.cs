using System;

class Program
{
    static int x(int number)
    {
        int result = 1;
        int i = 1;
        while (result <= number)
        {
            if (result == number)
            {
                return i;
            }
            i++;
            result *= i;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        int num = int.Parse(Console.ReadLine());

        int wynik = x(num);

        if (wynik != -1)
        {
            Console.WriteLine($"{num} jest silnią liczby {wynik}.");
        }
        else
        {
            Console.WriteLine($"{num} nie jest silnią żadnej liczby.");
        }
    }
}