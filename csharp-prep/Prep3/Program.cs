using System;

class Program
{
    static void Main(string[] args)
    {

        string playgame = "yes";

        while (playgame.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            Console.WriteLine($"The magic number is {number}.");

            int guess = 0;
            int guessnumber = 0;

            while (guess != number)
            {
                guessnumber += 1;

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You Guessed it!!");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"You guessed {guessnumber} times."); 
             
            Console.WriteLine();

            Console.Write("Would you like to play again (Yes/No)? ");
            playgame = Console.ReadLine();

        }



    }
}