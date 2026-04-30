using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int NumbersInput = 1;

        Console.WriteLine("Enter a list of numbers, then type 0 when finished.");

        while (NumbersInput != 0)
        {
            
            Console.Write("Enter number: ");
            NumbersInput = int.Parse(Console.ReadLine());
            if (NumbersInput != 0)
            {
              numbers.Add(NumbersInput);  
            }
            else{}
            

        }
        int sum = 0;
        float average = 0;
        int largest = 0;

        foreach (int numb in numbers)
        {
            sum += numb;
            average += numb;

            if (numb > largest)
            {
                largest = numb;
            }
            else{}

        }
        Console.WriteLine($"The sum is: {sum} ");
        Console.WriteLine($"The average is: {average/numbers.Count}");
        Console.WriteLine($"the largest number is: {largest}");
    }
}