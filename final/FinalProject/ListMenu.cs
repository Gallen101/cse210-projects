using System;

public class ListMenu : Menu
{
    private new string ga_menu = $@"
                List Options
===========================================
Your list Options are:
1. Colors
2. Sports
3. Seasons
4. Back to Game Menu
===========================================
Which list would you like to use?  ";

    public override void DisplayMenu()
    {
        Console.Write(ga_menu);
    }
    public override void MenuChoice()
    {
        while (ga_action != 4)
        {
            Hangman game = new Hangman();
            ga_action = Userchoice();
            switch (ga_action)
            {
                case 1:
                    ga_fileName = "colors.txt";
                    game.StartGame(ga_fileName);
                    break;
                case 2:
                    ga_fileName = "sports.txt";
                    game.StartGame(ga_fileName);
                    break;
                case 3:
                    ga_fileName = "seasons.txt";
                    game.StartGame(ga_fileName);
                    break;
                case 4:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}