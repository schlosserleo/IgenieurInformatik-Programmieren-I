// ReSharper disable MemberCanBePrivate.Global
namespace Programmieren_I.Uebungen;

public static class ZusaetzlicheUebung9
{
    public static void PrimzahlenOderDasSiebDesEratosthenes()
    {
        var getUserInputLoop= true;
        uint userInput = 0;
        while(getUserInputLoop)
        {
            Console.WriteLine("Bitte obere Grenze n (<= 100.000) für Berechnung der Primzahlen eingeben:");
            if (!uint.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Eingabe Fehlerhaft!\nSoll die Eingabe nochmal Versucht werden?(j/n)");
                getUserInputLoop = Console.ReadLine() == "j";
            }
            else
            {
                getUserInputLoop = false;
            }
        }
        var primeNumbers = CalculatePrimeNumbers(userInput);
        foreach (var i in primeNumbers)
        {
            Console.Write($"{i} ");
        }
    }
    
    // ReSharper disable once ReturnTypeCanBeEnumerable.Global
    public static uint[] CalculatePrimeNumbers(uint number)
    {
        var result = new List<uint>();
        var gestrichen = new bool[number + 2]; //: array [2..N] of boolean

        for (var i = 2; i <= number; i++)
        {
            gestrichen[i] = false;
        }

        for (uint i = 2; i <= Math.Sqrt(number); i++)
        {
            if (gestrichen[i]) continue;
            result.Add(i);
            for (var j = i * i; j <= number; j += i)
            {
                gestrichen[j] = true;
            }
        }

        for (var i = (uint)Math.Sqrt(number) + 1; i <= number; i++)
            if (!gestrichen[i])
            {
                result.Add(i);
            }
        return result.ToArray();
    }
}