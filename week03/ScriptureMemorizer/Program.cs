using System;
/// <summary>
/// I made the word class as a private class inside the scripture class because it doesn't need or should be used 
/// by any other part of the program. 
/// 
/// I also used a hash set to keep track of all the indexes of words that had already been chosen so that it would 
/// chose new indexes.
/// 
/// I also added show all method that would set all the words is hidden attribute to false.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        
        //Assign variable in instance classes
        
        bool quit = false;
        string input = "";

        string scriptureText = "When the Lord shall have washed away the filth of the daughters of Zion, and shall have purged the blood of Jerusalem from the midst thereof by the spirit of judgment and by the spirit of burning And the Lord will create upon every dwelling-place of mount Zion, and upon her assemblies, a cloud and smoke by day and the shining of a flaming fire by night; for upon all the glory of Zion shall be a defence.";

        Reference reference = new Reference("2 Nephi", 14, 4, 5);

        Scripture scripture = new Scripture(reference, scriptureText);

        

        // The programs runs intil the user types quit
        while (!quit)
        {
            //Clear the console
            Console.Clear();
            
            //Display the scripture full or hidden
            Console.Write($"{reference.GetDisplayText()} ");
            Console.WriteLine( scripture.GetDisplayText());
            
            Console.WriteLine("Press enter or type quit");
            input = Console.ReadLine();
            quit = input.Equals("quit", StringComparison.OrdinalIgnoreCase);

            if (!quit)
            {
                if (scripture.IsCompletelyHidden())
                {
                    
                    quit = true;
                }
                else
                {
                    scripture.HideRandomWords();
                }
                

            }
        }
        scripture.ShowAll();
        Console.Write($"{reference.GetDisplayText()} ");
        Console.WriteLine( scripture.GetDisplayText());
    }
}