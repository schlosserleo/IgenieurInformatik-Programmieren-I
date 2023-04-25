using Programmieren_I.Uebungen;

namespace Programmieren_I;

public static class Globals
{
	public const string ApplistLocation = "/home/leo/coding/Programmieren I/Uebungen/uebungsnamen.txt";
}
internal static class ProgrammierenI
{
	private static void Main()
	{
		Console.WriteLine("Sie haben folgende Programme zur Auswahl(Eingabe nach Schema: 1/2/2z/3z)");
		PrintAppList();
		var shortAppName = GetUserInput();
		var lineInTxtFile = GetLine(shortAppName);
		
		Console.WriteLine($"Starte {BuildAppName(lineInTxtFile, GetLineContent(lineInTxtFile))}");
		switch (shortAppName)
		{
			case "1":
				Uebung1.Anfaenge();
				break;
			case "1z":
				ZusaetzlicheUebung1.Rechner();
				break;
			case "2":
				//starts 2
				break;
			default:
				Console.WriteLine("Keine valide Eingabe.\nBitte geben sie eine Programmnummer aus der Liste ein");
				break;
		}
	}
	private static string GetUserInput()
	{
		var selection = Console.ReadLine() ?? throw new InvalidOperationException();
		return selection;
	}
	private static string? GetLineContent(int targetline)
	{
		var linecontent = "";
		var sr = new StreamReader(Globals.ApplistLocation);
			for (int i = 0; i <= targetline; i++)
			{
				if (i+1 == targetline)
				{
					linecontent = sr.ReadLine();
				}
				else
				{
					sr.ReadLine();
				}
			}
			sr.Close();
			return linecontent;
	}

	private static int GetLine(string shortappname)
	{
		if (int.TryParse(shortappname, out var linenumber))
		{
			linenumber = (linenumber *2 ) -1;
		}
		else
		{
			linenumber += (int)char.GetNumericValue(shortappname[0]) * 2;
		}
		return linenumber;
	}

	private static string BuildAppName(int linenumber, string? linecontent)
	{
		var result = "";
		if ((linenumber+1) % 2 != 0)
		{
			result += $"Zusätzliche Übung {(linenumber+1) / 2} - {linecontent}";
		}
		else
		{
			result += $"Übung {(linenumber+1) / 2} - {linecontent}";
		}

		return result;
	}

	private static void PrintAppList()
	{
		var i = 1;
		var sr = new StreamReader(Globals.ApplistLocation);
		var line = sr.ReadLine();
		while (line != null)
		{
			Console.WriteLine(BuildAppName(i, line));
			line = sr.ReadLine();
			i++;
		}
	}
}