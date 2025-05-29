namespace JiPP;

internal class Game
{
    public int Id { get; }
    public string Tytul { get; }
    public decimal Cena { get; }
    public int Stan { get; private set; }

    public Game(int id, string tytul, decimal cena, int stan)
    {
        Id = id;
        Tytul = tytul;
        Cena = cena;
        Stan = stan;
    }

    // pilnuje, by nie zejść poniżej zera
    public bool Zabierz(int ilosc)
    {
        if (ilosc <= 0 || ilosc > Stan) return false;
        Stan -= ilosc;
        return true;
    }

    public void Zwroc(int ilosc) => Stan += ilosc;
}