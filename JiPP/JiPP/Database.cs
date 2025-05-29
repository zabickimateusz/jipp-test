using MySqlConnector;

namespace JiPP;

internal static class Database
{
    private const string ConnStr =
        "Server=192.168.0.101;Database=sklep;User ID=jipp;Password=haslo;";

    public static MySqlConnection Get() => new(ConnStr);
}