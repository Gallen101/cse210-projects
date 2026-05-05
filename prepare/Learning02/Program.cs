using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        
        job1._jobTitle = "Computer Engineer";
        job1._company = "Micron";
        job1._startYear = 2030;
        job1._endyear = 2060;

        job1.Display();

        Job job2 = new Job();
        
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endyear = 2023;

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Grant Allen";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();        
    }
}