using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        return $"{reference.GetReference()}\n" + 
               string.Join(" ", words.Select(word => word.GetDisplayValue()));
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        var wordsToHide = words.Where(word => !word.IsHidden()).OrderBy(x => random.Next()).Take(3);
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }
}