using System;

public class ChecklistGoal : Goal
{
    
    private string ga_type = "Check List Goal:";
    private int ga_numberTimes;
    private int ga_bonusPoints;
    private bool ga_status;
    private int ga_count;


    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base(type, name, description, points)
    {
        ga_status = false;
        ga_numberTimes = numberTimes;
        ga_bonusPoints = bonusPoints;
        ga_count = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(type, name, description, points)
    {
        ga_status = status;
        ga_numberTimes = numberTimes;
        ga_bonusPoints = bonusPoints;
        ga_count = count;
    }

    public int GetTimes()
    {
        return ga_numberTimes;
    }
    public void SetTimes()
    {
        ga_count = ga_count + 1;
    }
    public int GetCount()
    {
        return ga_count;
    }
    public void SetCount()
    {
        
    }
    public int GetBonusPoints()
    {
        return ga_bonusPoints;
    }
    public Boolean Finished()
    {
        return ga_status;
    }

    public override void ListGoal(int i)
    {
        if(Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }
    }
    public override string SaveGoal()
    {
        return ($"{ga_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {ga_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {ga_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}"); 
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (ga_count == ga_numberTimes)
        {
            ga_status = true;
            points = points + ga_bonusPoints;

            Console.WriteLine($"Congratulations! You have earned {points} points!");

        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }
}