namespace Programmieren_I.Uebungen;

internal static class ZusaetzlicheUebung4
{
    public static void Zinsberechnung()
    {
        var answers = GetAnswers();
        double.TryParse(answers[0], out var startKapital);
        double.TryParse(answers[1], out var zinSatzInProzent);
        int.TryParse(answers[2], out var laufZeit);
        Console.WriteLine(BerechneZinsGewinn(startKapital, zinSatzInProzent, laufZeit));
    }

    private static List<string?> GetAnswers()
    {
        var answers = new List<string?>();
        var questions = new List<string?> { "das Startkapital in EUR", "den Zinssatz in %", "die Laufzeit in Jahren" };
        foreach (var i in questions)
        {
            Console.WriteLine($"Bitte geben sie {i} ein:");
            answers.Add(Console.ReadLine());
        }

        return answers;
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public static double BerechneZinsGewinn(double startKapital, double zinsSatzInProzent, int laufZeit)
    {
        var endbetrag = startKapital;
        for (var i = 0; i < laufZeit; i++) endbetrag += endbetrag * (zinsSatzInProzent / 100);
        return Math.Round(endbetrag - startKapital, 2);
    }
}