using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Assingment assingment = new Assingment("Samuel Bennett", "Multiplication");
        string summary = assingment.GetSummary();
        Console.WriteLine(summary);

        Console.WriteLine();

        MathAssingment math = new MathAssingment("Robertp Rodriguez", "Fractions", "7.3", "8-19");
        string summary2 = math.GetSummary();
        string homework = math.GetHomeworkList();
        Console.WriteLine(summary2);
        Console.WriteLine(homework);

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War 2");
        string summary3 = writing.GetSummary();
        string title = writing.GetWritingInformation();
        Console.WriteLine(summary3);
        Console.WriteLine(title);
    }
}