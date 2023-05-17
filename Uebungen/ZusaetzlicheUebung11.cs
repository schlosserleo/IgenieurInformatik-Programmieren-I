namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung11
{
    public static void ZahlenSortieren()
    {
        var generator = new ZufallszahlenGenerator(100, 0, 100000);
        var zufallsListe = generator.ErzeugeZufallszahlen();
        foreach (var i in zufallsListe) Console.Write($"{i}, ");
    }
}