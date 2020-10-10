using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class Robot
{
    Random _rnd = new Random();
    static List<string> _usedNames = new List<string>();

    private string _name;

    public Robot()
    {
        _name = InitializeName();
    }

    public string Name => _name;

    public void Reset() => _name = InitializeName();

    private string InitializeName()
    {
        var name = string.Format("{0}{1}{2}{3}{4}",
            GetChar(),
            GetChar(),
            GetDigit(),
            GetDigit(),
            GetDigit()
            );

        return _usedNames.Contains(name) ? InitializeName() : AcceptName(name);
    }
    private string AcceptName(string name)
    {
        _usedNames.Add(name);
        return name;
    }

    private char GetChar() => (char)_rnd.Next('A', 'Z');

    private int GetDigit() => _rnd.Next(0, 9);

}