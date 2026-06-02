using System;

public class Assingment
{
    private string ga_studentName;
    private string ga_topic;


    public Assingment(string StudentName, string Topic)
    {
        ga_studentName = StudentName;

        ga_topic = Topic;   
    }

    public string GetStudentName()
    {
        return ga_studentName;
    }

    public string GetTopic()
    {
        return ga_topic;
    }

    public string GetSummary()
    {
        return ga_studentName + " - " + ga_topic;
    }
}