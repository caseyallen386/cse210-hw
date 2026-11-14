using System;
// using System.Text;

public class Scripture
{

    // I chose to write the word class as a private class inside the scripture class
    // because there is no other part of the program that needs to access it directly
    // nor do I think that any other part of the program should.

    /// <summary>
    ///  The word class is used by the scripture class to manage the scripture text 
    /// </summary>
    private class Word
    {
        private string _word;
        private bool _isHidden = false;


        public Word(string word)
        {
            _word = word;
        } 

        public void Hide()
        {
            _isHidden = true;
        }

        public void Show()
        {
            _isHidden = false;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {


            if(_isHidden)
            {
                return new string('_', _word.Length);
            } 
            else
            {
                return _word;
            }

            
        }
    }



    private List<Word> _text = new List<Word>();

    private HashSet<int> _hiddenWords = new HashSet<int>();
    Reference _reference;

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;

        foreach (string word in scripture.Split(" "))
        {
            _text.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {

        // I thought about using StringBuilder but I decided that this way was simpler and 
        // gave the out come with out having to add my own logic to not add an empmty space 
        // at the end of the paragraph.
        List<string> displayText = new List<string>();
        // string wordtext;


        foreach (Word word in _text)
        {
            
            displayText.Add(word.GetDisplayText());
        }

        return String.Join(" ", displayText);
    }

    public void HideRandomWords(int numbToHide = 4)
    {
        

        Random random = new Random();
        int randomIndex; 

        for (int i = 0; i < numbToHide; i++)
        {

            if (_hiddenWords.Count < _text.Count)
            {
                do
                {
                    randomIndex = random.Next(_text.Count);
                } while (_hiddenWords.Contains(randomIndex));

                _hiddenWords.Add(randomIndex);

                _text[randomIndex].Hide();
            }


        }
    }

    public bool IsCompletelyHidden()
    {

        List<bool> completelyHidden = new List<bool>();

        foreach (Word word in _text)
        {
            if (word.IsHidden())
            {
                completelyHidden.Add(true);
            }
            else
            {
                completelyHidden.Add(false);
            }
        }

    
        if (completelyHidden.Contains(false))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void ShowAll()
    {
        foreach (Word word in _text)
        {
            word.Show();
        }
    }

}