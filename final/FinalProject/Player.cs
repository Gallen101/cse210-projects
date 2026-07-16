using System;
using System.Text;

public class Player
{
    public string ga_randomWord { get; set; }
    public string ga_showRandomWord { get; set; }
    public string ga_guessedLetter { get; set; }
    public List<string> ga_letterGuess { get; set; }
    public List<string> ga_wrongGuess { get; set; }
    public List<string> ga_rightGuess { get; set; }
    public List<string> ga_empty { get; set; }
    public string ga_guesses { get; set; }
    public string ga_wrongGuesses { get; set; }
    public int ga_wrongGuessCount;
    public int ga_correctGuessCount;
    public int ga_numberWordsGuess;
    public int ga_score;

    public Player()
    {
        ga_randomWord = string.Empty;
        ga_showRandomWord = string.Empty;
        ga_guessedLetter = string.Empty;
        ga_letterGuess = new List<string>();
        ga_wrongGuess = new List<string>();
        ga_rightGuess = new List<string>();
        ga_empty = new List<string>();
        ga_guesses = string.Empty;
        ga_wrongGuesses = string.Empty;
        ga_wrongGuessCount = 0;
        ga_correctGuessCount = 0;
        ga_numberWordsGuess = 0;
        ga_score = 0;
    }

    public bool PlayerWon()
    {
        return (ga_correctGuessCount == ga_randomWord.Length);
    }
    public bool PlayerLost()
    {
        return (ga_wrongGuessCount == 7);
    }
    public bool GameOver()
    {
        return ((ga_wrongGuessCount == 7) == (ga_correctGuessCount == ga_randomWord.Length));
    }
    public void ShowRandomWord()
    {
        StringBuilder sb = new StringBuilder();
        bool correctLetter = false;

        for (int i = 0; i < ga_randomWord.Length; i++)
        {
            correctLetter = false;
            foreach (string l in ga_letterGuess)
            {
                if (ga_randomWord[i].ToString().Equals(l))
                {
                    correctLetter = true;
                }
            }
            if (!correctLetter)
            {
                sb.Append("_ ");
            }
            else
            {
                sb.Append(ga_randomWord[i].ToString()).Append(" ");
            }
        }
        //ShowRandomWord = sb.ToString();

    }

    public void CheckLatestGuess(string newGuess)
    {
        bool correctLetter = false;
        StringBuilder sb = new StringBuilder();
        string word = ga_randomWord;
        ga_letterGuess.Add(newGuess);
        for (int i = 0; i < ga_randomWord.Length; i++)
        {
            if (ga_randomWord[i].ToString().Equals(newGuess))
            {
                ga_correctGuessCount++;
                correctLetter = true;
                ga_rightGuess.Add(newGuess);
            }
        }
        // User was wrong
        if (!correctLetter)
        {
            ga_wrongGuessCount++;
            ga_wrongGuess.Add(newGuess);
        }

        sb.Append("Wrong Guesses: [ ");
        foreach (string l in ga_wrongGuess)
        {
            sb.Append(l).Append(" ");
        }
        sb.Append("]");
        ga_wrongGuesses = sb.ToString();

    }

    public bool CheckIfGuessed(Player player, string newGuess)
    {
        if (player.ga_letterGuess.Contains(newGuess))
        {
            return true;
        }
        return false;
    }

}
