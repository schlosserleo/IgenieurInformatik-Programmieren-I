// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace Programmieren_I.Uebungen;

public class Linie
{
    public Linie(Punkt startPunkt = null!,
        Punkt endPunkt = null!) // = null nur benötigt damit Übung 10 noch funktioniert
    {
        StartPunkt = startPunkt;
        EndPunkt = endPunkt;
    }

    public Punkt StartPunkt { get; set; }

    public Punkt EndPunkt { get; set; }

    // ReSharper disable once MemberCanBePrivate.Global
    public double Laenge => Punkt.AbstandZwischen(StartPunkt, EndPunkt);

    public Linie VerschiebeUmVektor(Vektor verschiebeVektor)
    {
        var tempStartPunktAlsVektor = StartPunkt.AlsVektor();
        var tempEndPunktAlsVektor = EndPunkt.AlsVektor();

        var verschobenerStartPunkt = tempStartPunktAlsVektor.Addiere(verschiebeVektor).AlsPunkt();
        var verschobenerEndPunkt = tempEndPunktAlsVektor.Addiere(verschiebeVektor).AlsPunkt();

        return new Linie(verschobenerStartPunkt, verschobenerEndPunkt);
    }

    public override string ToString()
    {
        return
            $"({StartPunkt.X}, {StartPunkt.Y}, {StartPunkt.Z}), ({EndPunkt.X}, {EndPunkt.Y}, {EndPunkt.Z}), {Laenge}";
    }
}