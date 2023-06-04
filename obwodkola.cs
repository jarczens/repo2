using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj pole kola");
        double poleKola;
        
        poleKola = inputValue();
        double obwodKola;
        
        obwodKola = Math.Sqrt(poleKola);
        Console.WriteLine(obwodKola);
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
