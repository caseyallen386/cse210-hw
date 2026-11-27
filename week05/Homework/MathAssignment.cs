using System;


public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textBookSection = section;
        _problems = problems;
    }

    public string GetHomework()
    {
        return $"{base.GetSummary()}\n{_textBookSection} - {_problems}";
    }
}