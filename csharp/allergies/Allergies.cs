using System;
using System.Collections.Generic;

public enum Allergen : int
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    int _mask = 0;

    public Allergies(int mask) => _mask = mask;

    public bool IsAllergicTo(Allergen allergen) => ((int)allergen & _mask) == (int)allergen;

    public Allergen[] List()
    {
        var list = new List<Allergen>();

        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
                list.Add(allergen);
        }

        return list.ToArray();
    }
}