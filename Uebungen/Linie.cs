namespace Programmieren_I.Uebungen;

public class Linie
{
    public Punkt StartPunkt { get; set; }

    public Punkt EndPunkt { get; set; }

    public double Laenge => Punkt.AbstandZwischen(StartPunkt, EndPunkt);

    public override string ToString()
    {
        return
            $"({StartPunkt.X}, {StartPunkt.Y}, {StartPunkt.Z}), ({EndPunkt.X}, {EndPunkt.Y}, {EndPunkt.Z}), {Laenge}";
    }
}