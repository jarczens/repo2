using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj kwotę, którą chcesz wpłacić na konto: ");
        double kapitalPoczatkowy = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie w skali roku: ");
        double oprocentowanie = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        double oprocentowanieMiesieczne = oprocentowanie / 12 / 100; 

        double kapitalKoncowy = kapitalPoczatkowy * Math.Pow(1 + oprocentowanieMiesieczne, liczbaMiesiecy); 

        double podatekBelki = 0.19 * (kapitalKoncowy - kapitalPoczatkowy); 

        double kapitalKoncowyPoPodatku = kapitalKoncowy - podatekBelki; 

        double kapitalKoncowyZaokraglony = Math.Round(kapitalKoncowyPoPodatku, 1); 

        Console.WriteLine("Suma którą zaoszczędziłeś (po uwzględnieniu podatku Belki) to : " + kapitalKoncowyZaokraglony);
        Console.ReadLine();
    }
}
