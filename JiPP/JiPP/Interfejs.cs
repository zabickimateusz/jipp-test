using System;
using System.Linq;

namespace JiPP;

internal static class Interfejs
{
    public static void PokazGry(Catalog katalog)
    {
        Console.WriteLine("\n--- Oferta ---");
        foreach (var g in katalog.Wszystkie())
            Console.WriteLine($"{g.Id,2}. {g.Tytul,-20} | {g.Cena,7:0.00} PLN | stan: {g.Stan}");
        Console.WriteLine();
    }

    public static void PokazKoszyk(Basket koszyk)
    {
        Console.WriteLine("\n--- Koszyk ---");
        foreach (var p in koszyk.Pozycje)
            Console.WriteLine($"{p.Game.Tytul,-20} x{p.Ilosc} = {p.Wartosc,7:0.00} PLN");
        Console.WriteLine($"RAZEM: {koszyk.Razem(),7:0.00} PLN\n");
    }

    public static int PytajInt(string tekst)
    {
        Console.Write(tekst);
        return int.TryParse(Console.ReadLine(), out var v) ? v : -1;
    }
}