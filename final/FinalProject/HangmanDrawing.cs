using System;

public class HangmanDrawing
{
    public void ShowHangman(int ga_wrongGuessCount)
    {
        if (ga_wrongGuessCount == 1)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("    ===");
        }
        else if (ga_wrongGuessCount == 2)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O    |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("    ===");
        }
        else if (ga_wrongGuessCount == 3)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O    |");
            Console.WriteLine(" |    |");
            Console.WriteLine("      |");
            Console.WriteLine("    ===");
        }
        else if (ga_wrongGuessCount == 4)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O    |");
            Console.WriteLine("/|    |");
            Console.WriteLine("      |");
            Console.WriteLine("    ===");
        }
        else if (ga_wrongGuessCount == 5)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O    |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("      |");
            Console.WriteLine("    ===");
        }
        else if (ga_wrongGuessCount == 6)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O    |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("/     |");
            Console.WriteLine("    ===");
        }
        else if (ga_wrongGuessCount == 7)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O    |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("/ \\  |");
            Console.WriteLine("    ===");
        }

    }
}