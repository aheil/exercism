using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var a = input.ToCharArray();
        Array.Reverse(a);
        return new string(a);
    }
}