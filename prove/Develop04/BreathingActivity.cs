using System;

public class BreathingActivity : Activity

{
    public BreathingActivity()
        : base("Breathing Activity", "This acticity will hlep you relax by guiding you through breathing in and out slowly. Please clear your mind and focus on your breathing.")
    {
        
    }   

    protected override void PerformActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(ga_timeSeconds);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in ..");
            ShowCountdown(4);

            Console.WriteLine("Breathe out ..");
            ShowCountdown(5);

            Console.WriteLine();
        }


    } 
}