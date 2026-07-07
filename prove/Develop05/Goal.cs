using System;

public abstract class Goal
{
    
    private string ga_type;
    private string ga_name;
    private string ga_description;
    private int ga_points;

    public Goal(string type, string name, string description, int points)
    {
        ga_type = type;
        ga_name = name;
        ga_description = description;
        ga_points = points;
    }
    public string Gettype()
    {
        return ga_type;
    }
    public string GetName()
    {
        return ga_name;
    }
    public string GetDescription()
    {
        return ga_description;
    }
    public int GetPoints()
    {
        return ga_points;
    }

    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
}