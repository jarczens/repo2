using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("podaj promien kola oraz dwa punkty (x,y), aby sprawdzic czy punkt o podanych wspolrzednych znajduje sie w obrebie kola o srodku 0,0");
        Console.WriteLine("podaj promien kola");
        double r;
        
        r = inputValue();
        Console.WriteLine("podaj 2 wspolrzedne punktu x,y");
        double x, y;
        
        x = inputValue();
        y = inputValue();
        if (x > r || y > r)
        {
            Console.WriteLine("podany punkt nie znajduje sie w obrebie kola");
        }
        else
        {
            Console.WriteLine("podany punkt znajduje sie w obrebie kola");
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
