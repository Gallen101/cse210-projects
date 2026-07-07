using System;

public class NegativeGoal : Goal
{
    // Attributes
    private string ga_type = "Negative Goal:";
    private bool ga_status;

    // Constructors
    public NegativeGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        ga_status = false;
    }
    public NegativeGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        ga_status = status;
    }
    public Boolean Finished()
    {
        return ga_status;
    }

    // Methods
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
       Console.WriteLine($"Bummer! You have Lost {GetPoints()} points!");
    }

}