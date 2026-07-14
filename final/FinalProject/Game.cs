using System;

public class Game : Menu
{
    
    private new string ga_menu = $@"
                Game Options
============================================
Please choose one of the following options:
1. Pick a word topic
2. Random Words
3. Back to Main Menu
=============================================
Choose an option from the menu:  ";


    public override void DisplayMenu()
    {
        Console.Write(ga_menu);
    }
    public override void MenuChoice()
    {
        //Menu listMenu = new ListMenu(); 

        while (ga_action != 3)
        {
            ga_action = Userchoice();
            switch(ga_action)
            {
                case 1:
                ga_fileName = "words.txt";
                //Hangman game = new Hangman();
                //Game.StartGame(ga_fileName);
                break;
                case 2:
                    Console.Clear();
                    //listMenu.MenuChoice();
                    break;
                case 3: 
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine($"\nSorry that option is not valid.");
                    break;
            }
        }  
    }
}