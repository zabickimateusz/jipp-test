using System;
using System.Linq;

namespace JiPP;

internal static class Program
{
    private static readonly Catalog _katalog = new();
    private static readonly Basket _koszyk = new();

    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("""
                === SKLEP Z GRAMI (JiPP) ===
                1. Pokaż gry
                2. Dodaj do koszyka
                3. Usuń z koszyka
                4. Pokaż koszyk
                5. Finalizuj zakup
                0. Zakończ
                """);

            switch (Console.ReadLine())
            {
                case "1":
                    Interfejs.PokazGry(_katalog);
                    break;
                case "2":
                    DodajDoKoszyka();
                    break;
                case "3":
                    UsunZKoszyka();
                    break;
                case "4":
                    Interfejs.PokazKoszyk(_koszyk);
                    break;
                case "5":
                    Finalizuj();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Nie rozpoznano opcji.\n");
                    break;
            }
        }
    }

    private static void DodajDoKoszyka()
    {
        Interfejs.PokazGry(_katalog);
        var id = Interfejs.PytajInt("ID gry: ");
        var qty = Interfejs.PytajInt("Ilość:   ");
        var gra = _katalog.Znajdz(id);

        if (gra is null || qty <= 0)
        {
            Console.WriteLine("Błędne dane.\n");
            return;
        }

        Console.WriteLine(_koszyk.Dodaj(gra, qty)
            ? "✅ Dodano!\n"
            : "Brak tylu sztuk na stanie.\n");
    }

    private static void UsunZKoszyka()
    {
        Interfejs.PokazKoszyk(_koszyk);
        var id = Interfejs.PytajInt("ID gry do usunięcia: ");
        _koszyk.Usun(id);
    }

    private static void Finalizuj()
    {
        if (!_koszyk.Pozycje.Any())
        {
            Console.WriteLine("Koszyk pusty.\n");
            return;
        }

        Interfejs.PokazKoszyk(_koszyk);
        Console.Write("Kupujesz? (t/n): ");
        if (Console.ReadLine()?.Trim().ToLower() == "t")
        {
            _koszyk.Opróżnij();
            Console.WriteLine("🛒 Dziękujemy za zakupy!\n");
        }
    }
}
