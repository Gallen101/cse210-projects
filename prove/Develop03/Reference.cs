using System;

public class Reference
{
    
    private string ga_book;
    private int ga_chapter;
    private int ga_startVerse;
    private int? ga_endVerse;

    public Reference(string book, int chapter, int verse)
    {
        ga_book = book ?? throw new ArgumentNullException(nameof(book));
        ga_chapter = chapter;
        ga_startVerse = verse;
        ga_endVerse = null;

    }

    public Reference(string book, int chapter, int startVerse, int endverse)
    {
        if (endverse < startVerse)
            throw new ArgumentException("endverse must be >= startVerse");

        ga_book = book ?? throw new ArgumentNullException(nameof(book));
        ga_chapter = chapter;
        ga_startVerse = startVerse;
        ga_endVerse = endverse;
    }

    public string GetDisplayText()
    {
        if (ga_endVerse.HasValue)
        {
            return $"{ga_book} {ga_chapter}:{ga_startVerse}-{ga_endVerse}";
        
        }
        else
        {
            return $"{ga_book} {ga_chapter}:{ga_startVerse}";
        }
    }
}