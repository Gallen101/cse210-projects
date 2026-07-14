using System;

public class GameInstructions
{
    private string ga_howToPlay = $@"
    How To Play Hangman
    ==========================================================
    The Game
    Hangman is a simple word-guessing game. The computer thinks of a secret word, 
    and the player tries to guess it one letter at a time. Each wrong guess draws 
    part of a stick-figure “hangman,” and the guesser must solve the word before 
    the drawing is completed.

    The guesser suggests letters; correct letters are revealed in their positions.

    Incorrect letters add a body part to the hangman (head, body, arms, legs).

    The game ends when the word is fully guessed (win) or the hangman drawing is complete (loss).

    You only get 7 incorrect guesses.
    ==========================================================
    
    Now that you have read the Hangman rules, give the game a try!

    === Press Enter to return to the main menu ===";

    public void HowToPlay()
    {
        Console.Clear();

        Console.Write(ga_howToPlay);
        
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
}