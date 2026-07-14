using System;
using System.Data;

public abstract class Menu
{

   public string ga_menu { get; set; }
   protected string ga_userInput { get; set; }
   protected int ga_userChoice;
   protected int ga_action;
   protected string ga_fileName { get; set; }

   public abstract void DisplayMenu();
   public int Userchoice()
    {
        DisplayMenu();

        ga_userInput = Console.ReadLine();
        ga_userChoice = 0;

        try
        {
            ga_userChoice = int.Parse(ga_userInput);
        }
        catch (FormatException)
        {
            ga_userChoice = 0;
        }
        catch ( Exception exception)
        {
            Console.WriteLine($"Unexpected error: {exception.Message}");
        }
        return ga_userChoice;
    } 
    public abstract void MenuChoice();
}