using Programmieren_I.Uebungen;

namespace Programmieren_I;

internal static class ProgrammierenI
{
    private static void Main()
    {
        int lineInTxtFile;
        while (true)
        {
            Console.WriteLine("Sie haben folgende Programme zur Auswahl(Eingabe nach Schema: 1/2/2z/3z)");
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

    /*private static bool LaunchApp(string shortAppName)
    {
        switch (shortAppName)
        {
            case "1":
                Uebung1.Anfaenge();
                return true;
            case "1z":
                ZusaetzlicheUebung1.Rechner();
                return true;
            case "2":
                Uebung2.Eingaben();
                return true;
            case "2z":
                ZusaetlicheUebung2.Logikaufgabe();
                return true;
            case "3":
                Uebung3.Typen();
                return true;
            case "3z":
                ZusaetzlicheUebung3.AusgabeAlsBinärUndHexadezimalZahl();
                return true;
            case "4":
                Uebung4.MathematischeFunktionen();
                return true;
            case "4z":
                ZusaetzlicheUebung4.Zinsberechnung();
                return true;
            case "5":
                Uebung5.AnsweisungenUmsetzen();
                return true;
            case "5z":
                ZusaetzlicheUebung5.Fakultaet();
                return true;
            case "6":
                Uebung6.ReihenBerechnen();
                return true;
            case "6z":
                ZusaetzlicheUebung6.NewtonVerfahren();
                return true;
            case "7":
                Uebung7.Textanalyse();
                return true;
            case "7z":
                ZusaetzlicheUebung7.TextanalyseMitCollections();
                return true;
            case "8":
                Uebung8.DatumBestimmen();
                return true;
            case "8z":
                ZusaetzlicheUebung8.IterationUndRekursion();
                return true;
            case "9":
                Uebung9.MethodenParameter();
                return true;
            case "9z":
                ZusaetzlicheUebung9.PrimzahlenOderDasSiebDesEratosthenes();
                return true;
            case "10":
                Uebung10.KlassenErstellenTeil1();
                return true;
            case "10z":
                ZusaetzlicheUebung10.BisektionsVerfahren();
                return true;
            case "11":
                Uebung11.KlassenErstellenTeil2();
                return true;
            case "11z":
                ZusaetzlicheUebung11.ZahlenSortieren();
                return true;
            default:
                Console.WriteLine("Keine valide Eingabe.\nBitte geben sie eine Programmnummer aus der Liste ein");
                return false;
        }
    }*/
    private static bool LaunchApp(string shortAppName)
    {
        var appDictionary = new Dictionary<string, Action>
        {
            { "1", Uebung1.Anfaenge },
            { "1z", ZusaetzlicheUebung1.Rechner },
            { "2", Uebung2.Eingaben },
            { "2z", ZusaetlicheUebung2.Logikaufgabe },
            // Weitere Zuordnungen hier hinzufügen
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