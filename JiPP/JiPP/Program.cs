using System;
using System.Linq;
using MySqlConnector;

namespace JiPP;

internal static class Program
{
    private static int? _userId;
    private static readonly Catalog _katalog = new();
    private static readonly Basket _koszyk = new();

    private static void Main()
    {
        Login();               // opcjonalne logowanie

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
                case "1": Interfejs.PokazGry(_katalog); break;
                case "2": DodajDoKoszyka(); break;
                case "3": UsunZKoszyka(); break;
                case "4": Interfejs.PokazKoszyk(_koszyk); break;
                case "5": Finalizuj(); break;
                case "0": return;
                default: Console.WriteLine("??\n"); break;
            }
        }
    }

    private static void Login()
    {
        Console.Write("Logowanie? (t/n): ");
        if (Console.ReadLine()?.Trim().ToLower() != "t") return;

        Console.Write("login: "); var login = Console.ReadLine();
        Console.Write("hasło: "); var haslo = Console.ReadLine();

        using var c = Database.Get(); c.Open();
        using var cmd = new MySqlCommand(
            "SELECT id FROM uzytkownicy WHERE login=@l AND haslo=@h", c);
        cmd.Parameters.AddWithValue("@l", login);
        cmd.Parameters.AddWithValue("@h", haslo);
        var id = cmd.ExecuteScalar();
        if (id is null) Console.WriteLine("Błędne dane – tryb gościa.\n");
        else { _userId = Convert.ToInt32(id); Console.WriteLine("OK!\n"); }
    }

    private static void DodajDoKoszyka()
    {
        Interfejs.PokazGry(_katalog);
        var id = Interfejs.PytajInt("ID gry: ");
        var qty = Interfejs.PytajInt("Ilość:   ");
        var gra = _katalog.Znajdz(id);

        if (gra is null || qty <= 0)
            Console.WriteLine("Błędne dane.\n");
        else
            Console.WriteLine(_koszyk.Dodaj(gra, qty)
                ? "✅ Dodano!\n" : "Brak na stanie.\n");
    }

    private static void UsunZKoszyka()
    {
        Interfejs.PokazKoszyk(_koszyk);
        var id = Interfejs.PytajInt("ID gry do usunięcia: ");
        _koszyk.Usun(id);
    }

    private static void Finalizuj()
    {
        if (!_koszyk.Pozycje.Any()) { Console.WriteLine("Pusto.\n"); return; }

        Interfejs.PokazKoszyk(_koszyk);
        Console.Write("Kupujesz? (t/n): ");
        if (Console.ReadLine()?.Trim().ToLower() != "t") return;

        ZapiszZakup();                         // aktualizacja DB
        _koszyk.Opróżnij();
        Console.WriteLine("🛒 Dzięki!\n");
    }

    private static void ZapiszZakup()
    {
        using var c = Database.Get(); c.Open();
        using var tr = c.BeginTransaction();

        // przykład: tylko aktualizacja stanu + prosty log
        foreach (var p in _koszyk.Pozycje)
        {
            using var up = new MySqlCommand(
                "UPDATE gry SET stan=@s WHERE id=@id", c, tr);
            up.Parameters.AddWithValue("@s", p.Game.Stan);
            up.Parameters.AddWithValue("@id", p.Game.Id);
            up.ExecuteNonQuery();
        }

        using var log = new MySqlCommand(
            "INSERT INTO historia (uzytkownik_id, suma) VALUES (@u, @s)",
            c, tr);
        log.Parameters.AddWithValue("@u", _userId);
        log.Parameters.AddWithValue("@s", _koszyk.Razem());
        log.ExecuteNonQuery();

        tr.Commit();
    }
}
