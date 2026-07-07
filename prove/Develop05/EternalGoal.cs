using System;

public class EternalGoal : Goal
{
    private string ga_type = "Eternal Goal:";
    private bool ga_status;

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        ga_status = false;
    }
    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
       ga_status = status; 
    }

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{ga_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {ga_status}");
    }
    public override string LoadGoal()
    {
         return ($"{ga_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {ga_status}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
 }