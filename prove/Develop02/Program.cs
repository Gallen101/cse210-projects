using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int menuNumber = 0;

        Journal myjournal = new Journal();
        PromptPrinter promptPrinter = new PromptPrinter();

        while(menuNumber != 5)
        {
            Console.WriteLine("Please select one of the following choices:\n 1) Write \n 2) Display \n 3) Save \n 4) Load \n 5) Quit");
            Console.Write("What would you like to do? ");
            menuNumber = int.Parse(Console.ReadLine());

            if(menuNumber == 1)
            {
                string prompt = promptPrinter.GetRandom();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response:");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._time = DateTime.Now.ToShortDateString();
                newEntry._prompt = prompt;
                newEntry._entry = response;

                myjournal.AddEntry(newEntry);

            }

            else if(menuNumber == 2)
            {
                myjournal.DisplayAll();
            }
            
            else if(menuNumber == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myjournal.SaveToFile(filename);
            }

            else if(menuNumber == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myjournal.LoadFromFile(filename);
            }

            else if(menuNumber == 5)
            {
                Console.WriteLine("ByeBye!");
            }
            else
            {
                Console.WriteLine("Please choose a valid selection.");
            }


        }
    }
}
