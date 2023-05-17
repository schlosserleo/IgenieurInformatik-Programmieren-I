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
        var numLine = string.Empty;
        var maxNumLength = zahlen[^1].ToString().Length;
        var lineCount = 0;

        foreach (var item in zahlen.Select((value, i) => new { i, value }))
        {
            var value = item.value;
            var i = item.i + 1;
            numLine += value.ToString().PadLeft(maxNumLength) + " ";
            if (i % 4 != 0) continue;

            Console.WriteLine(numLine);
            lineCount++;
            if (lineCount == Console.WindowHeight - 2)
            {
                Console.WriteLine("Bitte Enter für die nächste Seite drücken");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }

                lineCount = 0;
            }

            numLine = string.Empty;
        }
    }
}