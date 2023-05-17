namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung11
{
    public static void ZahlenSortieren()
    {
        var generator = new ZufallszahlenGenerator(100, 0, 100000);
        var zufallsListe = generator.ErzeugeZufallszahlen();
        GebeArrayAus(zufallsListe);
        //Console.WriteLine(Console.WindowHeight);
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public static void GebeArrayAus(int[] zahlen)
    {
        var j = 2;
        foreach (var i in zahlen)
        {
            var maxLines = Console.WindowHeight;
            if (j == maxLines)
            {
                Console.WriteLine("Bitte Enter für die nächste Seite drücken");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }

                j = 1;
            }

            Console.WriteLine($"{i}, ");
            j++;
        }
    }
}