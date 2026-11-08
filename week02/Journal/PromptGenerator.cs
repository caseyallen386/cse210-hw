using System;
using System.Collections.Generic;

public class PromptGenerator
{
    
    List<string> _prompts = new List<string>();
    

    public void loadPrompts()
    {
        
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("If you could go back and tell yourself something what would it be?");
        _prompts.Add("Did you meet anyone new today?");
        _prompts.Add("What did you pray about this morning?");



        

    }

    public string getRandomPrompt()
    {
        Random _randNumb = new Random();
        int numb = _randNumb.Next(_prompts.Count);


        return _prompts[numb];
    }


}