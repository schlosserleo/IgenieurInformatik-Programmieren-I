using Programmieren_I.Uebungen;

namespace Programmieren_I;

internal static class ProgrammierenI
{
    private static void Main()
    {
        Console.WriteLine("Sie haben folgende Programme zur Auswahl(Eingabe nach Schema: 1/2/2z/3z)");
        PrintAppList();
        var shortAppName = GetUserInput();
        var lineInTxtFile = GetLine(shortAppName);
        Console.WriteLine($"Starte {BuildAppName(lineInTxtFile, GetLineContent(lineInTxtFile))}\n" +
                          $"{GetDotLine(lineInTxtFile)}");
        LaunchApp(shortAppName);
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
            appListLocation = "/home/leo/coding/Programmieren I/Uebungen/uebungsnamen.txt";
            appLinesLocation = "/home/leo/coding/Programmieren I/python scripts/applines.txt";
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

    private static void LaunchApp(string shortAppName)
    {
        switch (shortAppName)
        {
            case "1":
                Uebung1.Anfaenge();
                break;
            case "1z":
                ZusaetzlicheUebung1.Rechner();
                break;
            case "2":
                Uebung2.Eingaben();
                break;
            case "2z":
                ZusaetlicheUebung2.Logikaufgabe();
                break;
            case "3":
                Uebung3.Typen();
                break;
            case "3z":
                ZusaetzlicheUebung3.AusgabeAlsBinärUndHexadezimalZahl();
                break;
            case "4":
                Uebung4.MathematischeFunktionen();
                break;
            case "4z":
                ZusaetzlicheUebung4.Zinsberechnung();
                break;
            case "5":
                Uebung5.AnsweisungenUmsetzen();
                break;
            case "5z":
                ZusaetzlicheUebung5.Fakultaet();
                break;
            case "6":
                Uebung6.ReihenBerechnen();
                break;
            case "6z":
                ZusaetzlicheUebung6.NewtonVerfahren();
                break;
            case "7":
                Uebung7.Textanalyse();
                break;
            case "7z":
                ZusaetzlicheUebung7.TextanalyseMitCollections();
                break;
            case "8":
                Uebung8.DatumBestimmen();
                break;
            case "8z":
                ZusaetzlicheUebung8.IterationUndRekursion();
                break;
            case "9":
                Uebung9.MethodenParameter();
                break;
            case "9z":
                ZusaetzlicheUebung9.PrimzahlenOderDasSiebDesEratosthenes();
                break;
            case "10":
                Uebung10.Testo();
                break;
            default:
                Console.WriteLine("Keine valide Eingabe.\nBitte geben sie eine Programmnummer aus der Liste ein");
                break;
        }
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