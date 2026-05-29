using System;
using System.Text;

public class Word
{
    private string ga_text;
    private bool ga_isHidden;

    public Word(string text)
    {
        ga_text = text ?? "";
        ga_isHidden = false;
    }

    public bool IsHidden()
    {
        return ga_isHidden;
    }
    public void Hide()
    {
        ga_isHidden = true;
    }

    private int Countletters()
    {
        int count = 0;
        foreach (char c in ga_text)
        {
            if (char.IsLetter(c))
                count++;
        }
        return count;
    }
    public string GetDisplayText()
    {
        if (!ga_isHidden)
            return ga_text;
            
        var sb = new StringBuilder();
        foreach (char c in ga_text)
        {
            if (char.IsLetter(c))
                sb.Append("_");
            else
                sb.Append(c);
        }
        return sb.ToString();
    }
}