using System.Collections.Generic;
using System.Linq;

namespace JiPP;

internal class Basket
{
    private readonly Dictionary<int, BasketItem> _pozycje = new();

    public IEnumerable<BasketItem> Pozycje => _pozycje.Values;

    public bool Dodaj(Game gra, int ilosc)
    {
        if (!gra.Zabierz(ilosc)) return false;

        if (_pozycje.TryGetValue(gra.Id, out var p))
            p.Dodaj(ilosc);
        else
            _pozycje[gra.Id] = new BasketItem(gra, ilosc);

        return true;
    }

    public void Usun(int idGry)
    {
        if (_pozycje.Remove(idGry, out var p))
            p.Game.Zwroc(p.Ilosc);
    }

    public decimal Razem() => _pozycje.Values.Sum(p => p.Wartosc);

    public void Wyczysc()
    {
        foreach (var p in _pozycje.Values)
            p.Game.Zwroc(p.Ilosc);
        _pozycje.Clear();
    }

    public void Opróżnij()
    {
        _pozycje.Clear();          
    }
}