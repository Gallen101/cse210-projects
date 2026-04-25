using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastNumber = grade % 10;
        string sign = "";

        if (letter != "A" && letter != "F")
        {
            if (lastNumber >= 7)
            {
                sign = "+";
            }
            else if (lastNumber >= 7)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 93)
        {
            if (lastNumber < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the course");
        }
        else
        {
            Console.WriteLine("Dont give up! You can do better next time!");
        }
    } 
}