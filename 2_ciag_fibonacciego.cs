using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int liczba, a, b, c, d;
        
        Console.WriteLine("Podaj numer, aby wywolac kolejno wyrazy ciagu Fibonacciego");
        liczba = (int) inputValue();
        a = 0;
        b = 1;
        d = 0;
        while (d < liczba)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
            d = d + 1;
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
