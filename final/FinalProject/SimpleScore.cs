using System;

public class SimpleScore : Scoring
{
    private int score;
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        score = numGuesses;
        return score;
    }

    public override void ShowScore()
    {
        Console.WriteLine($"Your simple word score is: {score} ");
    }
}