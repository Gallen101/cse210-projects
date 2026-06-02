using System;

public class MathAssingment: Assingment
{
    private string ga_textbookSection;
    private string ga_problems;

    public MathAssingment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        ga_textbookSection = textbookSection;
        ga_problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return $"Section {ga_textbookSection} Problems {ga_problems}";
    }
}