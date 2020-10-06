using System;
using System.Linq;
using System.Net.Mail;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand == null || secondStrand == null || firstStrand.Length != secondStrand.Length)
            throw new ArgumentException();

        if (firstStrand == string.Empty)
            return secondStrand == string.Empty ? 0 : throw new ArgumentException();

        return firstStrand.Where((c, i) => c != secondStrand[i]).Count();
    }
}