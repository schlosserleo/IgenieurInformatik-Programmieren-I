namespace Programmieren_I.Uebungen;

public static class Uebung10
{
    public static void Testo()
    {
        var a = new Punkt
        {
            X = 1,
            Y = 1,
            Z = 0    
        };
        var b = new Punkt()
        {
            X = 2,
            Y = 2,
            Z = 0
        };
        Console.WriteLine(a.AbstandZu(b));
        Console.WriteLine(Punkt.AbstandZwischen(a, b));
        Console.WriteLine($"Punkkt a: {a.ToString()}\nPunkt b: {b.ToString()}");
    }
}