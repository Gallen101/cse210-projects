using System;

public class ComplexScore : Scoring
{
    private int score;
    private int len;
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        len = word.Length;
        if (len <= 7)
        {
            score = numGuesses * 2;
        }
        else if (len > 7 & len <= 9)
        {
            score = numGuesses * 3;
        }
        else
        {
            score = numGuesses * 4;
        }
        return score;
    }

    public override void ShowScore()
    {
        Console.WriteLine($"Your complex word score is: {score} ");
    }
}