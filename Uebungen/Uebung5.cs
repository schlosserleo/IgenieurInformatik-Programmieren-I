namespace Programmieren_I.Uebungen;

internal static class Uebung5
{
    public static void AnsweisungenUmsetzen()
    {
        var now = int.Parse(Console.ReadLine() ?? string.Empty);
        var answers = GetAnswers();
        var vorName = answers[0];
        var nachName = answers[1];
        var begruessung = ErmittleBegruessung(now);
        Console.WriteLine($"{begruessung} {vorName} {nachName}!");
    }

    private static List<string?> GetAnswers()
    {
        var questions = new List<string> { "Vornamen", "Nachnamen" };
        var answers = new List<string?>();
        foreach (var i in questions)
        {
            Console.WriteLine($"Bitte geben Sie Ihren {i} ein:");
            answers.Add(Console.ReadLine());
        }

        return answers;
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public static string ErmittleBegruessung(int stunde)
    {
        if (stunde is >= 5 and < 11)
            return "Guten Morgen";
        if (stunde is >= 11 and < 17)
            return "Guten Tag";
        if (stunde is >= 17 and < 23)
            return "Guten Abend";
        if (stunde is >= 23 and < 24 or >= 0 and < 5)
            return "Gute Nacht";
        return "";
    }
}