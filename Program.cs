using Programmieren_I.Uebungen;

namespace Programmieren_I;

internal static class ProgrammierenI
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Sie haben folgende Programme zur Auswahl:");
            PrintAppList();
            var shortAppName = GetUserInput();

            if (LaunchApp(shortAppName))
                break;

            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Programmnummer aus der Liste ein.");
        }
    }

    private static string OsFileLoc(string namesOrLines)
    {
        string appListLocation;
        string appLinesLocation;
        if (OperatingSystem.IsWindows())
        {
            appListLocation = "C:\\Users\\gamer\\RiderProjects\\Programmieren-I\\Uebungen\\uebungsnamen.txt";
            appLinesLocation = "C:\\Users\\gamer\\RiderProjects\\Programmieren-I\\python scripts\\applines.txt";
        }
        else
        {
            appListLocation = "/home/leo/coding/Programmieren-I/Uebungen/uebungsnamen.txt";
            appLinesLocation = "/home/leo/coding/Programmieren-I/python scripts/applines.txt";
        }

        return namesOrLines == "Names" ? appListLocation : appLinesLocation;
    }

    private static string GetUserInput()
    {
        Console.Write("Eingabe nach Schema: 1/2/2z/3z: ");
        var selection = Console.ReadLine() ?? throw new InvalidOperationException();
        return selection;
    }

    private static string? GetLineContent(int targetline)
    {
        var linecontent = "";
        var sr = new StreamReader(OsFileLoc("Names"));
        for (var i = 0; i <= targetline; i++)
            if (i + 1 == targetline)
                linecontent = sr.ReadLine();
            else
                sr.ReadLine();
        sr.Close();
        return linecontent;
    }

    private static int GetLine(string shortappname)
    {
        if (int.TryParse(shortappname, out var linenumber))
            linenumber = linenumber * 2 - 1;
        else
            linenumber += (int)char.GetNumericValue(shortappname[0]) * 2;
        return linenumber;
    }

    private static string BuildAppName(int linenumber, string? linecontent)
    {
        var result = "";
        if ((linenumber + 1) % 2 != 0)
            result += $"Zusätzliche Übung {(linenumber + 1) / 2} - {linecontent}";
        else
            result += $"Übung {(linenumber + 1) / 2} - {linecontent}";

        return result;
    }

    private static void PrintAppList()
    {
        var i = 1;
        var sr = new StreamReader(OsFileLoc("Names"));
        var line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(BuildAppName(i, line));
            line = sr.ReadLine();
            i++;
        }
    }

    private static bool LaunchApp(string shortAppName)
    {
        var appDictionary = new Dictionary<string, Action>
        {
            { "1", Uebung1.Anfaenge },
            { "1z", ZusaetzlicheUebung1.Rechner },
            { "2", Uebung2.Eingaben },
            { "2z", ZusaetlicheUebung2.Logikaufgabe },
            { "3", Uebung3.Typen },
            { "3z", ZusaetzlicheUebung3.AusgabeAlsBinärUndHexadezimalZahl },
            { "4", Uebung4.MathematischeFunktionen },
            { "4z", ZusaetzlicheUebung4.Zinsberechnung },
            { "5", Uebung5.AnsweisungenUmsetzen },
            { "5z", ZusaetzlicheUebung5.Fakultaet },
            { "6", Uebung6.ReihenBerechnen },
            { "6z", ZusaetzlicheUebung6.NewtonVerfahren },
            { "7", Uebung7.Textanalyse },
            { "7z", ZusaetzlicheUebung7.TextanalyseMitCollections },
            { "8", Uebung8.DatumBestimmen },
            { "8z", ZusaetzlicheUebung8.IterationUndRekursion },
            { "9", Uebung9.MethodenParameter },
            { "9z", ZusaetzlicheUebung9.PrimzahlenOderDasSiebDesEratosthenes },
            { "10", Uebung10.KlassenErstellenTeil1 },
            { "10z", ZusaetzlicheUebung10.BisektionsVerfahren },
            { "11", Uebung11.KlassenErstellenTeil2 },
            { "11z", ZusaetzlicheUebung11.ZahlenSortieren }
        };

        if (!appDictionary.TryGetValue(shortAppName, out var appAction)) return false;
        var lineInTxtFile = GetLine(shortAppName);
        Console.WriteLine($"Starte {BuildAppName(lineInTxtFile, GetLineContent(lineInTxtFile))}\n" +
                          $"{GetDotLine(lineInTxtFile)}");
        appAction.Invoke();
        return true;
    }

    private static string? GetDotLine(int targetline)
    {
        var linecontent = "";
        var sr = new StreamReader(OsFileLoc("Lines"));
        for (var i = 0; i <= targetline; i++)
            if (i + 1 == targetline)
                linecontent = sr.ReadLine();
            else
                sr.ReadLine();
        sr.Close();
        return linecontent;
    }
}