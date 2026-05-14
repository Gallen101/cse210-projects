using System;

public class Entry
{
    public string _entry;
    public string _prompt;
    public string _time;

    public void display()
    {
        Console.WriteLine($"Date: {_time}, Prompt: {_prompt}, Entry: {_entry}");  
    }

}