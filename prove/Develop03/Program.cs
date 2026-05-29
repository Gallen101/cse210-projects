using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all your heart and lean not on your own understanding;"
                    + " in all your ways submit to him, and he will make your paths straight."
            )
        };

        var rng = new Random();
        var item = scriptures[rng.Next(scriptures.Count)];
        const int wordsToHide = 4;

        while(true)
        {
            Console.Clear();
            Console.WriteLine(item.GetDisplayText());
            if (item.isFullyHidden())
            {
                Console.WriteLine("All thw words are hidden. Nice job mate.");
                break;
            }

            Console.WriteLine("Press ENTER to hide some more words, or type quit to exit program");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodnight my friend");
                break;
            }

            item.HideRandomwords(wordsToHide, rng);
        }
    }
}