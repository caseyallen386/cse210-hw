using System;



public class JournalMenu
{
    private List<String> _options = new()
    {
        "Write",
        "Display",
        "Load",
        "Save",
        "Quit"
    };



    public void Display()
    {
        for(int i = 0; i < _options.Count; i++)
        {
            
            Console.WriteLine($"{i + 1 }: {_options[i]}");
        }

        Console.WriteLine("What would you like to do?");
    }

    public int GetUserChoice()
    {
        var input = Console.ReadLine();
        

        if (int.TryParse(input, out int numbChoice ))
        {
            return numbChoice - 1;    
        }
        else
        {
            return _options.FindIndex(option => option.Contains(input, StringComparison.OrdinalIgnoreCase));   
        }
    
    }
}