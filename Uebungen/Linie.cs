// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace Programmieren_I.Uebungen;

public class Linie
{
    public Punkt StartPunkt { get; set; } = null!;

    public Punkt EndPunkt { get; set; } = null!;

    // ReSharper disable once MemberCanBePrivate.Global
    public double Laenge => Punkt.AbstandZwischen(StartPunkt, EndPunkt);

    public override string ToString()
    {
        return
            $"({StartPunkt.X}, {StartPunkt.Y}, {StartPunkt.Z}), ({EndPunkt.X}, {EndPunkt.Y}, {EndPunkt.Z}), {Laenge}";
    }
}