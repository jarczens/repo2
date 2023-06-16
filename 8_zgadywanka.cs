using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pomyśl o liczbie z przedziału od 1 do 20.");
        Console.WriteLine("Program będzie próbował odgadnąć tę liczbę.");

        int x = 1;
        int y = 20;
        int z = 0;

        while (true)
        {
            z = (x + y) / 2;
            Console.Write($"Czy twoja liczba to {z}? (-1: za mała, 1: za duża, 0: zgadłeś): ");

            int odpowiedz;
            string input = Console.ReadLine();

            if (!int.TryParse(input, out odpowiedz))
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Spróbuj ponownie.");
                continue;
            }

            if (odpowiedz == 1)
            {
                y = z + 1;
            }
            else if (odpowiedz == -1)
            {
                x = z - 1;
            }
            else if (odpowiedz == 0)
            {
                Console.WriteLine($"Komputer odgadł twoją liczbę: {z}!");
                break;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Spróbuj ponownie.");
            }
        }
    }
}
