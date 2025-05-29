using System.Collections.Generic;
using System.Linq;
using MySqlConnector;

namespace JiPP;

internal class Catalog
{
    private readonly List<Game> _gry = new();

    public Catalog()
    {
        using var c = Database.Get();
        c.Open();
        using var cmd = new MySqlCommand(
            "SELECT id, tytul, cena, stan FROM gry ORDER BY id", c);
        using var r = cmd.ExecuteReader();
        while (r.Read())
            _gry.Add(new Game(r.GetInt32(0), r.GetString(1),
                r.GetDecimal(2), r.GetInt32(3)));
    }

    public IEnumerable<Game> Wszystkie() => _gry;
    public Game? Znajdz(int id) => _gry.FirstOrDefault(g => g.Id == id);
}