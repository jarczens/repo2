using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, wynik;
        
        wynik = 1;
        a = (int) inputValue();
        if (a > 0)
        {
        }
        else
        {
            Console.WriteLine("podaj liczbe naturalna");
            a = (int) inputValue();
        }
        b = (int) inputValue();
        if (b > 0)
        {
        }
        else
        {
            Console.WriteLine("podaj liczbe naturalna");
            b = (int) inputValue();
        }
        while (b > 0)
        {
            wynik = wynik * a;
            b = b - 1;
        }
        Console.WriteLine(wynik);
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
