using System;
using System.Runtime.ConstrainedExecution;

public static class Gigasecond
{
    private const long GIGASECOND = 1000000000;

    public static DateTime Add(DateTime moment) => moment.AddSeconds(GIGASECOND);

}