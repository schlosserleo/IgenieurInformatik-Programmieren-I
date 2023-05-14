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
        var b = new Punkt
        {
            X = 2,
            Y = 2,
            Z = 0
        };
        var va = new Vektor
        {
            X = 1,
            Y = 1,
            Z = 1
        };
        var vb = new Vektor
        {
            X = 2,
            Y = 2,
            Z = 2
        };
        Console.WriteLine($"Testing Punkt.cs\n" +
                          $"Punkt a: {a.ToString()}\n" +
                          $"Punkt b: {b.ToString()}\n" +
                          $"Abstand von a zu b (object method): {a.AbstandZu(b)}\n" +
                          $"Abstand von b zu a (class method): {Punkt.AbstandZwischen(b, a)}\n\n" +
                          $"Testing Vektor.cs\n" +
                          $"Vektor a: {va.ToString()}\n" +
                          $"Vektor b: {vb.ToString()}\n" +
                          $"Skalarprodukt von Vektor a und b (object method): {va.BerechneSkalarprodukt(vb)}\n" +
                          $"Skalarprodukt von Vektor b und a (class method: {Vektor.BerechneSkalarprodukt(vb, va)}");
    }
}