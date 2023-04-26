namespace Programmieren_I.Uebungen;

internal static class ZusaetlicheUebung2
{
    public static void Logikaufgabe()
    {
        GebeUmrahmteBegruessungAus(ErfasseDaten());
    }

    private static List<string?> ErfasseDaten()
    {
        var answers = new List<string?>();
        Console.WriteLine("Bitte geben Sie Ihren Vor- und Nachnamen ein:");
        answers.Add(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie das Zeichen für den Rahmen ein:");
        answers.Add(Console.ReadLine());
        return answers;
    }

    private static void GebeUmrahmteBegruessungAus(IReadOnlyList<string?> answers)
    {
        var name = answers[0];
        var symbol = answers[1];
        var fullline = "";
        var emptyline = "";
        if (name != null)
            for (var i = 0; i < name.Length + 9; i++)
            {
                fullline += symbol;
                emptyline += " ";
            }

        Console.WriteLine(symbol + fullline + symbol);
        Console.WriteLine(symbol + emptyline + symbol);
        Console.WriteLine($"{symbol} Hallo {name}! {symbol}");
        Console.WriteLine(symbol + emptyline + symbol);
        Console.WriteLine(symbol + fullline + symbol);
    }
}