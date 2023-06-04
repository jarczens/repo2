using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj długości boków trójkąta, aby sprawdzić czy utworzona z nich figura może być trójkątem równobocznym");
        double a, b, c;
        
        a = inputValue();
        while (a <= 0)
        {
            Console.WriteLine("Długość boku nie może być mniejsza lub równa 0");
            a = inputValue();
        }
        b = inputValue();
        while (b <= 0)
        {
            Console.WriteLine("Długość boku nie może być mniejsza lub równa 0");
            b = inputValue();
        }
        c = inputValue();
        while (c <= 0)
        {
            Console.WriteLine("Długość boku nie może być mniejsza lub równa 0");
            c = inputValue();
        }
        double wynik;
        
        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Powstała figura jest trójkątem równobocznym!");
        }
        else
        {
            Console.WriteLine("Powstała figura nie jest trójkątem równobocznym!");
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
