using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj dwie liczby, zeby wykonac dzialanie");
        int a, b;
        
        a = (int) inputValue();
        b = (int) inputValue();
        Console.Write("Wpisz liczbe, aby wykonac dzialanie:" + (char) 13 + "1 - dodawanie" + (char) 13 + "2 - odejmowanie" + (char) 13 + "3 - mnozenie" + (char) 13 + "4 - dzielenie");
        double c;
        
        c = inputValue();
        while (c <= 0)
        {
            Console.WriteLine("Miales podac liczbe miedzy 1-4 debilu");
            c = inputValue();
        }
        while (c > 4)
        {
            Console.WriteLine("Miales podac liczbe miedzy 1-4 debilu");
            c = inputValue();
        }
        if (c == 1)
        {
            Console.WriteLine("Wynik dodawania to: " + (a + b));
        }
        if (c == 2)
        {
            Console.WriteLine("Wynik odejmowania to: " + (a - b));
        }
        if (c == 3)
        {
            Console.WriteLine("Wynik mnozenia to: " + a * b);
        }
        while (b == 0)
        {
            Console.WriteLine("Wynik dzielenia to: " + a + "/0");
            Console.WriteLine("Uruchom program ponownie, aby wykonac nastepne dzialanie");
            a = (int) inputValue();
        }
        if (c == 4)
        {
            Console.WriteLine("Wynik dzielenia to: " + (double) a / b);
        }
    }
    
    public static void stop(int stop)
    {
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
