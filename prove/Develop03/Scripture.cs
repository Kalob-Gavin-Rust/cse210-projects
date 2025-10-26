using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public int HideRandomWords(int count)
    {
        Random rand = new Random();
        int hidden = 0;

        while (hidden < count && !IsCompletelyHidden())
        {
            int index = rand.Next(_words.Count);
            Word chosen = _words[index];

            if (!chosen.IsHidden())
            {
                chosen.Hide();
                hidden++;
            }
        }
        return hidden;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public void GetText()
    {
        List<string> rendered = new List<string>();

        foreach (Word word in _words)
        {
            rendered.Add(word.GetRenderedWord());
        }

        string text = string.Join(" ", rendered);
        Console.WriteLine($"{_reference.GetDisplayText()} {text}");
    }
}
