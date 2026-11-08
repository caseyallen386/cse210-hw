using System;
using System.IO;
using System.Security.Principal;


/* 
    in the Journal class I added the ability to save to the previous save without entering a new file name

    I also checked to make sure that there will be a file name entered if the user doesn't enter one at first

*/

public class Journal
{
    
    private List<Entry> _entries =  new List<Entry>();
    private String _saveLocation
    {
        get; set;
    }


    public void AddEntry(String journalEntry, String thePrompt, String date)
    {
        Entry newEntry = new Entry();
        newEntry.Date = date;
        newEntry.PromptsText = thePrompt;
        newEntry.EntryText = journalEntry;
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(String file = null)
    {
        
        if (string.IsNullOrEmpty(file) && _saveLocation == null)
        {
            bool fileLocation = false;

            while (!fileLocation)
            {
                Console.Write("Please enter a filename: ");
                file = Console.ReadLine();
                if (!string.IsNullOrEmpty(file))
                {
                    fileLocation = true;
                }
            }
            
            _saveLocation = file;
        }
        else if (string.IsNullOrEmpty(file) && _saveLocation != null)
        {
            file = _saveLocation;
        }

        try
        {
            using (StreamWriter saveFile = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    saveFile.WriteLine($"{entry.Date}|~|{entry.PromptsText}|~|{entry.EntryText}");
                }
            }
        }
        catch (System.Exception)
        {
            
            throw;
        }

        
    }

    // 0 date 1 prompt 2 entrytext
    public void LoadFromFile(String file)
    {

        _saveLocation = file;
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|~|");

            AddEntry(parts[2], parts[1], parts[0]);
        }
    }
}