using System;

class Program
{
    static double Silnia(int liczba)
    {
        double wynik = 1;
        for (int a = 2; a <= liczba; a++)
        {
            wynik *= a;
        }
        return wynik;
    }

    static double Funkcja(double x, int n)
    {
        double wynik = 0;
        for (int a = 0; a <= n; a++)
        {
            double b = Math.Pow(x, a) / Silnia(a);
            wynik += b; 
        }
        return wynik;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Podaj ile wynosi x: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę wyrazów: ");
        int n = int.Parse(Console.ReadLine());

        double wartosc = Funkcja(x, n);

        Console.WriteLine("Wartość funkcji e do potęgi " + x + " dla podanej ilości wyrazów wynosi: " + wartosc);
        Console.ReadLine();
    }
}
