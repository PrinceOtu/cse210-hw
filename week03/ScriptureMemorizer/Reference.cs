using System;

public class Reference
{
    public string Book { get; private set; }
    public string ChapterAndVerses { get; private set; }

    public Reference(string book, string chapterAndVerses)
    {
        Book = book;
        ChapterAndVerses = chapterAndVerses;
    }

    public string GetReference()
    {
        return $"{Book} {ChapterAndVerses}";
    }
}