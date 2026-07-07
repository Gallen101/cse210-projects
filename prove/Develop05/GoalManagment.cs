using System;
using System.IO;

public class GoalManagement
{
    private List<Goal> ga_goals = new List<Goal>();
    private int ga_totalPoints;

    public GoalManagement()
    {
        ga_totalPoints = 0;
    }
    public void AddGoal(Goal goal)
    {
        ga_goals.Add(goal);
    }
    public int GetTotalPoints()
    {
        return ga_totalPoints;
    }
    public void Addpoints(int points)
    {
        ga_totalPoints += points;
    }
    public void AddBonus(int bonusPoints)
    {
        ga_totalPoints += bonusPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        ga_totalPoints = totalPoints;
    }
    public List<Goal> GetGoalsList()
    {
        return ga_goals;
    }

    public void ListGoals()
    {
        if (ga_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            foreach(Goal goal in ga_goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }
    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplish? ");
        int select = int.Parse(Console.ReadLine()) - 1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        Addpoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(ga_goals);

        Console.WriteLine($"\n--- You have {GetTotalPoints()} points! ---\n");
    }
    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());
            foreach(Goal goal in ga_goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of you goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            readText = readText.Skip(1).ToArray();

            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");


                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
                if (entries[0] == "Negative Goal:")
                {
                    NegativeGoal nGoal = new NegativeGoal(type, name, description, points, status);
                    AddGoal(nGoal);
                }
            }
        }
    }
}