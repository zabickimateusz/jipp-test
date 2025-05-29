namespace JiPP;

internal class BasketItem
{
    public Game Game { get; }
    public int Ilosc { get; private set; }

    public BasketItem(Game game, int ilosc)
    {
        Game = game;
        Ilosc = ilosc;
    }

    public void Dodaj(int ilosc) => Ilosc += ilosc;

    public decimal Wartosc => Game.Cena * Ilosc;
}