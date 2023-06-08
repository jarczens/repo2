using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj 4 liczby, aby dodac do siebie utworzone z nich ulamki");
        double a, b, c, d, e;
        
        a = inputValue();
        b = inputValue();
        c = inputValue();
        d = inputValue();
        while (b == 0)
        {
            Console.WriteLine("Brak rozwiazania");
        }
        while (d == 0)
        {
            Console.WriteLine("Brak rozwiazania");
        }
        double mianownik;
        
        if (b == d)
        {
            mianownik = b;
        }
        else
        {
            mianownik = b * d;
        }
        double licznik1;
        
        if (b == d)
        {
            licznik1 = a + c;
            while (b == d)
            {
                Console.WriteLine("x to:" + licznik1);
                Console.WriteLine("y to:" + mianownik);
                Console.WriteLine("zamknij program, aby podac nastepne liczby");
                e = inputValue();
            }
        }
        else
        {
            licznik1 = a * d;
        }
        double licznik2;
        
        licznik2 = c * b;
        double x;
        
        x = licznik1 + licznik2;
        Console.WriteLine("x to:" + x);
        Console.WriteLine("y to:" + mianownik);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
