using System;
using System.Collections.Generic;
using System.Text;

public class Scripture
{
    private Reference ga_reference;
    private List<Word> ga_words;

    public Scripture(Reference reference, string text)
    {
        ga_reference = reference ?? throw new ArgumentNullException(nameof(reference));
        ga_words = new List<Word>();

        var tokens = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (var i in tokens)
        {
            ga_words.Add(new Word(i));
        }
    }

    public string GetDisplayText()
    {
        var sb = new StringBuilder();
        sb.AppendLine(ga_reference.GetDisplayText());
        sb.AppendLine();

        for (int i = 0; i < ga_words.Count; i++)
        {
            sb.Append(ga_words[i].GetDisplayText());
            if (i < ga_words.Count - 1)
                sb.Append(" ");
        }
        return sb.ToString();
    }

    public void HideRandomwords(int count, Random rng)
    {
        if (count <= 0) return;

        var visibleIndexes = new List<int>();
        for (int i = 0; i < ga_words.Count; i++)
        {
            if (!ga_words[i].IsHidden())
                visibleIndexes.Add(i);
        }

        if ( visibleIndexes.Count == 0) return;

        int hidecount = Math.Min(count, visibleIndexes.Count);
        for (int x = 0; x < hidecount; x++)
        {
            int pick = rng.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[pick];

            ga_words[wordIndex].Hide();

            visibleIndexes.RemoveAt(pick);
        }
    }

    public bool isFullyHidden()
    {
        foreach (var w in ga_words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}