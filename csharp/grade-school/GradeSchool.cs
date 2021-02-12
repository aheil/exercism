using System.Collections.Generic;

public class GradeSchool
{
    SortedDictionary<int, SortedSet<string>> _roster = new SortedDictionary<int, SortedSet<string>>();

    public void Add(string student, int grade)
    {
        if (!_roster.ContainsKey(grade))
            _roster.Add(grade, new SortedSet<string>());

        _roster.GetValueOrDefault(grade).Add(student);
    }

    public IEnumerable<string> Roster()
    {
        var roster = new List<string>();

        foreach (var grade in _roster.Keys)
            roster.AddRange(this.Grade(grade));

        return roster;        
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _roster.GetValueOrDefault(grade, new SortedSet<string>());
    }
}