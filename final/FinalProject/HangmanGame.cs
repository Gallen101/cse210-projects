using System;
using System.Xml.Serialization;

public class Hangman
{
    private string ga_letterGuessed;
    private Player player;
    private HangmanDrawing hangmanDrawing;
    private WordGenerator randomWord;
    private PrintLine printLine;
    private ScoreBoard simpleScore = new ScoreBoard(new SimpleScore());
    private ScoreBoard complexScore = new ScoreBoard(new ComplexScore());
    private ScoreBoard scrabbleScore = new ScoreBoard(new ScrabbleScore());

    public Hangman()
    {
        player = new Player();
        hangmanDrawing = new HangmanDrawing();
        randomWord = new WordGenerator();
        printLine = new PrintLine();
    }

    public void StartGame(string fileName)
    {
        Console.Clear();
        SelectRandomWord(fileName);
        do
        {
            Console.Clear();
            ShowTitle();
            ShowHangman();
            ShowLettersGuessedRight();
            ShowLettersGuessedWrong();
            ShowNumberOfGuesses();
            ShowPlayerScore();
            PromptPlayerForLetter();
            CheckPlayerGuess();
        } while (!player.GameOver());

        GameOver();
        PlayAgain();
    }
    private void SelectRandomWord(string filename)
    {
        player.ga_randomWord = randomWord.GetRandomWord(filename);
    }
    private void DisplayRandomWord()
    {
        Console.WriteLine("\n{0}", player.ga_randomWord);
    }
    private void PromptPlayerForLetter()
    {
        do
        {
            Console.Write("Guess a letter >> ");
            string guess = Console.ReadLine();
            ga_letterGuessed = guess.Substring(0,1);
        }while (player.CheckIfGuessed(player, ga_letterGuessed));
        player.ga_letterGuess.Add(ga_letterGuessed);
    }

    private void CheckPlayerGuess()
    {
        player.CheckLatestGuess(ga_letterGuessed);
        player.ShowRandomWord();
    }

    private void PlayAgain()
    {
        Console.WriteLine($"\nWould you like to play again?, please press enter to continue.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }

    private void ShowNumberOfGuesses()
    {
        Console.WriteLine($"\nGuesses Left = {player.ga_wrongGuessCount}/7\n");
    }
    private void ShowHangman()
    {
        hangmanDrawing.ShowHangman(player.ga_wrongGuessCount);
    }
    private void ShowLettersGuessedRight()
    {
        Console.WriteLine($"\n{player.ga_showRandomWord}\n");
    }
    private void ShowLettersGuessedWrong()
    {
        Console.WriteLine($"\n{player.ga_wrongGuesses}\n");
    }
    private void ShowTitle()
    {
        Console.WriteLine($"=== Lets Play Hangman ===\n");
    }
    private void ShowPlayerScore()
    {
        if (!player.PlayerLost())
        {
            simpleScore.DisplayScore(player.ga_correctGuessCount, player.ga_rightGuess, player.ga_randomWord);
            scrabbleScore.DisplayScore(player.ga_correctGuessCount, player.ga_rightGuess, player.ga_randomWord);
            complexScore.DisplayScore(player.ga_correctGuessCount, player.ga_rightGuess, player.ga_randomWord);
        }
        else
        {
            simpleScore.DisplayScore(0, player.ga_empty, player.ga_randomWord);
            scrabbleScore.DisplayScore(0, player.ga_empty, player.ga_randomWord);
            complexScore.DisplayScore(0, player.ga_empty, player.ga_randomWord);
        }
    }

    private void GameOver()
    {
        Console.Clear();
        if (player.GameOver() && player.PlayerWon())
        {
            Console.WriteLine("=== Congratulations You Won! ===");
        }
        else
        {
            Console.WriteLine("=== Sorry, you lost! ===");
        }
        ShowHangman();
        ShowNumberOfGuesses();
        Console.WriteLine($"\nThe word wasa - {player.ga_randomWord}\n");
        ShowPlayerScore();
    }
}