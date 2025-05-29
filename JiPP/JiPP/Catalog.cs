using System.Collections.Generic;
using System.Linq;

namespace JiPP;

internal class Catalog
{
    private readonly List<Game> _gry = new()
    {
        new(1, "Cyberpunk 2077", 149.99m, 5),
        new(2, "Wiedźmin 3",      79.99m,10),
        new(3, "Elden Ring",     219.99m, 4),
        new(4, "Hades",           59.99m, 7),
        new(5, "Stardew Valley",  42.99m,12),
    };

    public IEnumerable<Game> Wszystkie() => _gry;
    public Game? Znajdz(int id) => _gry.FirstOrDefault(g => g.Id == id);
}