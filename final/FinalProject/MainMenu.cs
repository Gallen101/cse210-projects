using System;

public class MainMenu : Menu
{
    
    private new string ga_menu = $@"
            Main Menu Options
===========================================
Please choose one of the following options:
1. Play Hangman
2. How to Play
3. Quit
===========================================
Choose an option from the menu:  ";

    private string ga_welcomeMessage = @"
===========================================
===                                     ===
===         Welcome to Hangman          ===
===                                     ===
===========================================";

    private string ga_endingMessage = @"
===========================================
===                                     ===
===    Thank you for Playing Hangman    ===
===                                     ===
===========================================";

    public override void DisplayMenu()
    {
        Console.Write(ga_menu);
    }
    public override void MenuChoice()
    {
        Menu gamemenu = new Game();

        PrintWelcomeMessage();

        while (ga_action != 3)
        {
            ga_action = Userchoice();
            switch (ga_action)
            {
                case 1:
                    Console.Clear();
                    gamemenu.MenuChoice();
                    break;

                case 2:
                    GameInstructions info = new GameInstructions();
                    info.HowToPlay();
                    break;

                case 3:
                    PrintEndingMessage();
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
    private void PrintWelcomeMessage()
    {
        Console.Clear();
        Console.Write($"{ga_welcomeMessage}\n");
    }
    private void PrintEndingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{ga_endingMessage}\n");
    }
}