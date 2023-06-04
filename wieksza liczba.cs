using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj dwie liczby, aby sprawdzić która jest większa");
        double x, y;
        
        x = inputValue();
        y = inputValue();
        double wynik;
        
        if (x > y)
        {
            Console.WriteLine("Większa liczba to " + x);
        }
        else
        {
            Console.WriteLine("Większa liczba to " + y);
        }
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
