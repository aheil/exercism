using System;
using System.Net.Mail;

public class SpaceAge
{
    private static double _earthSeconds = 31557600.0;

    private struct OribtalPeriopd
    {
        public const double Mercury = 0.2408467;
        public const double Venus = 0.61519726;
        public const double Mars = 1.8808158;
        public const double Jupiter = 11.862615;
        public const double Saturn = 29.447498;
        public const double Uranus = 84.016846;
        public const double Neptune = 164.79132;
    }

    private double _earthAge;

    public SpaceAge(int seconds)
    {
        _earthAge = (double)seconds / _earthSeconds;
    }

    public double OnEarth()
    {
        return _earthAge;
    }

    public double OnMercury()
    {
        return this.OnEarth() / OribtalPeriopd.Mercury;
    }

    public double OnVenus()
    {
        return this.OnEarth() / OribtalPeriopd.Venus;
    }

    public double OnMars()
    {
        return this.OnEarth() / OribtalPeriopd.Mars;
    }

    public double OnJupiter()
    {
        return this.OnEarth() / OribtalPeriopd.Jupiter;
    }

    public double OnSaturn()
    {
        return this.OnEarth() / OribtalPeriopd.Saturn;
    }

    public double OnUranus()
    {
        return this.OnEarth() / OribtalPeriopd.Uranus;
    }

    public double OnNeptune()
    {
        return this.OnEarth() / OribtalPeriopd.Neptune;
    }
}