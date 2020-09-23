using System;
using System.Runtime.ConstrainedExecution;

public static class TwoFer
{
    private const string PARAM_TEXT = "One for {0}, one for me.";

    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.

    public static string Speak(string name = "you")
    {
        return String.Format(PARAM_TEXT, name);
    }
}
