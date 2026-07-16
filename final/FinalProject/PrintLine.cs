using System;
using System.Text;

public class PrintLine
{
    public void GetLines(string randomWord)
    {
        Console.Write("\r");
        foreach (char c in randomWord)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\u005f ");
        }
    }
}