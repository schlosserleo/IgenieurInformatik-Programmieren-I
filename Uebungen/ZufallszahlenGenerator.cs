namespace Programmieren_I.Uebungen;

public class ZufallszahlenGenerator
{
    public ZufallszahlenGenerator(int anzahl, int untergrenze, int obergrenze)
    {
        Anzahl = anzahl;
        Untergrenze = untergrenze;
        Obergrenze = obergrenze;
    }

    private int Anzahl { get; }

    private int Untergrenze { get; }

    private int Obergrenze { get; }

    // ReSharper disable once ReturnTypeCanBeEnumerable.Global
    // ReSharper disable once MemberCanBePrivate.Global
    public int[] ErzeugeZufallszahlen()
    {
        var rnd = new Random();
        var result = new int[Anzahl];

        if (Anzahl <= 0 || Untergrenze >= Obergrenze) return null!;
        for (var i = 0; i < Anzahl; i++) result[i] = rnd.Next(Untergrenze, Obergrenze);

        Array.Sort(result);

        return result;
    }
}