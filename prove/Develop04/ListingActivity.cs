using System;

public class ListingActivity : Activity
{
    private readonly List<string> ga_prompts = new List<string>()
    {
        "Who are people that you have helped this week",
        "Who are some of your personal heros",
        "When have you felt the holy ghost this month",
        "What are some of your personal strengths",
        "What is the name of someone you appreciate"
    };

    public ListingActivity() : base("listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    protected override void PerformActivity()
    {
        Random rnd = new Random();
        string prompt = ga_prompts[rnd.Next(ga_prompts.Count)];

        Console.WriteLine("Prompt:");
        Console.WriteLine("--->" + prompt);
        Console.WriteLine("\nYou have a few seconds to think before listing again.");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(ga_timeSeconds);
        List<string> items = new List<string>();

        while(DateTime.Now < endTime)
        {
            Console.Write(" > ");
            string input = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input.Trim());
            }
        }
        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}