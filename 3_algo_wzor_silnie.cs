using System;

class Program
{
    static int obliczSilnie(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        int silnia = 1;
        for (int i = 1; i <= number; i++)
        {
            silnia *= i;
        }
        return silnia;
    }

    static double z(int x, int y)
    {
        int silniaX = obliczSilnie(x);
        int silniaY = obliczSilnie(y);

        double result = (silniaX - silniaY) / (double)silniaY;
        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę x (większą lub równą 5): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę y (większą lub równą 5): ");
        int y = int.Parse(Console.ReadLine());

        if (x >= 5 && y >= 5)
        {
            double wynik = z(x, y);
            Console.WriteLine("Wynik równania (x! - y!) / y! to: " + wynik);
        }
        else
        {
            Console.WriteLine("Podano niewłaściwe liczby. Liczby x i y muszą być większe lub równe 5.");
        }
    }
}