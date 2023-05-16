namespace Programmieren_I.Uebungen;

public static class Uebung11
{
    public static void KlassenErstellenTeil2()
    {
        var a = new Punkt(1,1,1);
        var b = new Punkt(3,3,3);
        var va = new Vektor(2,2,2);
        var vb = new Vektor(1,1,1);
        var g = new Linie(a, b);
        Console.WriteLine($"Testing Punkt.cs\n" +
                          $"Punkt a: {a}\n" +
                          $"Punkt b: {b}\n" +
                          $"Abstand von a zu b (object method): {a.AbstandZu(b)}\n" +
                          $"Abstand von b zu a (class method): {Punkt.AbstandZwischen(b, a)}\n" +
                          $"Konvertiere a in Vektor: {a.AlsVektor()}\n" +
                          $"Vektor von a zu b (object method): {a.BildeVektor(b)}\n" +
                          $"Vektor von a zu b (class method): {Punkt.BildeVektor(a, b)}\n\n" +
                          
                          $"Testing Vektor.cs\n" +
                          $"Vektor a: {va}\n" +
                          $"Vektor b: {vb}\n" +
                          $"Konvertiere Vektor a in einen Punkt: {va.AlsPunkt()}\n" +
                          $"Addiere Vektor a und b: {va.Addiere(vb)}\n" +
                          $"Subtrahiere Vektor a von b: {vb.Subtrahiere(va)}\n" +
                          $"Multiplziere Vektor a mit 3: {va.MultipliziereSkalar(3)}\n" +
                          $"Skalarprodukt von Vektor a und b (object method): {va.BerechneSkalarprodukt(vb)}\n" +
                          $"Skalarprodukt von Vektor b und a (class method): {Vektor.BerechneSkalarprodukt(vb, va)}\n" +
                          $"Kreuzprodukt von Vektor a und b: {va.BildeKreuzprodukt(vb)}\n\n" +
                          
                          $"Testing Linie.cs\n" +
                          $"Linie g: {g}\n" +
                          $""
    }
}