namespace Programmieren_I.Uebungen;

internal static class Uebung2
{
    public static void Eingaben()
    {
        var questions = new List<string>
            { "Ihren Vornamen", "Ihren Nachnamen", "Ihre Straße", "Ihre PLZ", "Ihre Stadt" };
        var answers = new List<string?>();
        foreach (var i in questions)
        {
            Console.WriteLine($"Bitte geben Sie {i} ein:");
            answers.Add(Console.ReadLine());
        }

        Console.WriteLine($"{answers[0]} {answers[1]}");
        Console.WriteLine(answers[2]);
        Console.WriteLine($"{answers[3]} {answers[4]}");
    }
}