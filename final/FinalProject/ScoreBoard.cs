using System;

public class ScoreBoard
{
    private Scoring scoreingRules;

    public ScoreBoard(Scoring scoringRules)
    {
        scoreingRules = scoringRules;
    }

    public void DisplayScore(int numGuesses, List<string> letters, string word)
    {
        int score = scoreingRules.CalculateScore(numGuesses, letters, word);

        scoreingRules.ShowScore();
    }
}