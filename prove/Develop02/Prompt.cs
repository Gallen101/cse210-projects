using System;

public class PromptPrinter
{
    public List<string> prompts = new List<string>
    {
        "If your pet could talk, what would they complain about first?",
        "Describe your morning routine as if it were an Olympic sport. What would the commentators say?",
        "Whats the worst advice youve ever received?",
        "Whats one thing you love about yourself?",
        "How would your friends describe you in three words",
                
    };

    public string GetRandom()
    {
        Random randomGenerator = new Random();

        int index = randomGenerator.Next(prompts.Count);

        return prompts[index];
    }
}