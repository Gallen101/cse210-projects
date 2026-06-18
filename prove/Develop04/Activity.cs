using System;

public abstract class Activity
{
    protected string ga_name;
    protected string ga_description;
    protected int ga_timeSeconds;

    public Activity(string name, string description)
    {
        ga_name = name;
        ga_description = description;
    }

    public void Run()
    {
        DisplayStartMessage();
        GetTimeFromUser();
        PrepareToStart();
        PerformActivity();
        DisplayEndMessage();
    }

    protected void DisplayStartMessage()
    {
        Console.WriteLine($"=== {ga_name} ===\n");
        Console.WriteLine(ga_description);
        Console.WriteLine();
    }
    protected void GetTimeFromUser()
    {
        while(true)
        {
            Console.Write("Enter activity time in seconds (e.g. 30): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                ga_timeSeconds = seconds;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        Console.WriteLine();
    }

    protected void PrepareToStart()
    {
        Console.WriteLine("\nGet Ready!");
        ShowSpinner(3);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine($"\nYou have finished the {ga_name} for {ga_timeSeconds} seconds.\n");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int timeSeconds)
    {
        string spinner = @"|/-\";
        DateTime endTime = DateTime.Now.AddSeconds(timeSeconds);
        int idx = 0;

        while(DateTime.Now < endTime)
        {
            Console.Write(spinner[idx]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            idx = (idx + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected abstract void PerformActivity();
}