using System;

class Program
{
    static void Main(string[] args)
    {
        Welcomemessage();

        string username = UserName();
        int usernumber = UserNumber();

        int squarednumber = squarenumber(usernumber);

        int birthyear;
        UserbirthYear(out birthyear);


        ShowResult(username, squarednumber, birthyear);

    }

    static void Welcomemessage()
    {
        Console.WriteLine("Welcoe to the program!");
    }
    
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void UserbirthYear(out int birthyear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());

    }

    static int squarenumber(int number)
    {
        int square = number *number;
        return square;
    }

    static void ShowResult(string name, int square, int birthyear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthyear} years old this year");

    }
}