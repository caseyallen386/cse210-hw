using System;
using System.ComponentModel.Design;
/* 
    in the Journal class I added the ability to save to the previous save without entering a new file name

    I also checked to make sure that there will be a file name entered if the user doesn't enter one at first

    I added a menu class to manage the menu and in the menu class I added some validation that allows the user 
    to enter in either a number or the word and it will still choose the option.

*/
class Program
{
    static void Main(string[] args)
    {

        bool quit = false;

        DateTime theCurrentTime;

        PromptGenerator prompts = new PromptGenerator();
        prompts.loadPrompts();
        
        JournalMenu menu = new JournalMenu();
        Journal journal = new Journal();
        
        String prompt;
        String journalEntry;

        Console.WriteLine("Welcome to the Journal Program!");

        while (!quit)
        {
            menu.Display();
            int menuChoice = menu.GetUserChoice();
            // 4 should be the index quit
            switch(menuChoice)
            {
                //write
                case 0:

                    theCurrentTime = DateTime.Now;
                    prompt = prompts.getRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    journalEntry = Console.ReadLine();

                    journal.AddEntry(journalEntry, prompt, theCurrentTime.ToShortDateString());
                    break;
                

                // Display
                case 1:

                    journal.DisplayAll();
                    break;


                // Load
                case 2:

                    Console.Write("Please enter the filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;


                // save
                case 3:
                    Console.Write("Please enter the filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;

                //quit
                case 4:
                    quit = true;
                    break;

            }
        }
        
    }
}