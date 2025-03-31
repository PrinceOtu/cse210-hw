using System;

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string word)
    {
        text = word;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetDisplayValue()
    {
        return isHidden ? new string('_', text.Length) : text;
    }
}