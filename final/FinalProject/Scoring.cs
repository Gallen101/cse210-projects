using System;

public abstract class Scoring
{
    public abstract int CalculateScore(int numguesses, List<string> letters, string word);

    public abstract void ShowScore();
}