using System;

public class WritingAssignment: Assingment
{
    private string ga_title;

    public WritingAssignment(string StudentName, string topic, string Title) : base(StudentName, topic)
    {
        ga_title = Title;
    }

    public string GetWritingInformation()
    {
        string name = GetStudentName();

        return $"{ga_title} by {name}";
    }
}