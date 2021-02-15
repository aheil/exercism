using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> uniqueMultiplies = new HashSet<int>();

        foreach (var m in multiples)
        {
            if (m == 0)
                continue;

            for (int i = 1; i * m < max; i++)
            {
                uniqueMultiplies.Add(i * m);
            }
        }

        return uniqueMultiplies.Sum();
    }
}