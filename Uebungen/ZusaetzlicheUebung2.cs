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
        if (name == null) return;
        var len = name.Length + 9;
        var symbol = answers[1];
        if (symbol == null) return;
        var fullline = new string(Convert.ToChar(symbol), len);
        var emptyline = new string(Convert.ToChar(" "), len);

        Console.WriteLine(symbol + fullline + symbol);
        Console.WriteLine(symbol + emptyline + symbol);
        Console.WriteLine($"{symbol} Hallo {name}! {symbol}");
        Console.WriteLine(symbol + emptyline + symbol);
        Console.WriteLine(symbol + fullline + symbol);
    }
}