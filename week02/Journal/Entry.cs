using System;


public class Entry
{
    public String Date
    {
        get;
        set;
    }
    public String PromptsText
    {
        get;
        set;
    }
    public String EntryText
    {
        get;
        set;
    }

    public void Display()
    {
        Console.WriteLine($"{Date} - {PromptsText}:");
        Console.WriteLine(EntryText);
    }
}