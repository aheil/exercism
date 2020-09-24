using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    private enum Color : int
    {
        Black = 0,
        Brown = 1,
        Red = 2,
        Orange = 3,
        Yellow = 4,
        Green = 5,
        Blue = 6,
        Violet = 7,
        Grey = 8,
        White = 9
    }

    static Dictionary<string, Color> colors = new Dictionary<string, Color>()
    {
        {"black", Color.Black},
        {"brown", Color.Brown},
        {"red", Color.Red},
        {"orange", Color.Orange},
        {"yellow", Color.Yellow},
        {"green", Color.Green},
        {"blue", Color.Blue},
        {"violet", Color.Violet},
        {"grey", Color.Grey},
        {"white", Color.White}
    };

    public static int ColorCode(string color) => (int)colors.GetValueOrDefault(color.ToLower());

    public static string[] Colors() => colors.Keys.ToArray<string>();
   
}