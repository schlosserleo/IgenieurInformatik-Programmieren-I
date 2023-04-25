namespace Programmieren_I.Uebungen;

internal static class ZusaetzlicheUebung1
{
    public static void Rechner()
    {	
        var answers = FrageNachDaten();
        BerechneUndGebeErgebnisAus(answers);
    }
    static List<string?> FrageNachDaten()
    {
        var answers = new List<string?>();
        var questions = new List<string>() {"die erste Ganzzahl", "den Operator [+,-,*]", "die zweite Ganzzahl"};
        foreach (var i in questions) {
            Console.WriteLine("Bitte geben Sie "+i+" ein:");
            answers.Add(Console.ReadLine());
        }
        return answers;
    }
    static void BerechneUndGebeErgebnisAus(List<string?> answers)
    {
        var numberOne = ErmittleGanzzahl(answers[0]);
        var numberTwo = ErmittleGanzzahl(answers[2]);
        var userOperator = answers[1];

        if (userOperator == "+")
        {
            var result = numberOne + numberTwo;
            Console.WriteLine("Die Summe von "+numberOne+" + "+numberTwo+" = "+result);
        }
        else if (userOperator == "-")
        {
            var result = numberOne - numberTwo;
            Console.WriteLine("Die Differenz von "+numberOne+" - "+numberTwo+" = "+result);
        }
        else if (userOperator == "*")
        {
            var result = numberOne * numberTwo;
            Console.WriteLine("Das Produkt von "+numberOne+" * "+numberTwo+" = "+result);
        }
        else
        {
            Console.WriteLine("Ich weiß nicht, was ich berechnen soll.");
        }
    }
    static int ErmittleGanzzahl(string? number)
    {
        int.TryParse(number, out var result);
        return result;
    }
}