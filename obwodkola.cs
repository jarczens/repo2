using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj pole kola, aby obliczyc jego obwod");
        double poleKola;
        
        poleKola = inputValue();
        double promienKola;
        
        promienKola = Math.PI * Math.Sqrt(poleKola);
        double obwodKola;
        
        obwodKola = 2 * Math.PI * promienKola;
        Console.WriteLine("Obwod kola wynosi " + obwodKola + " ;)");
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
