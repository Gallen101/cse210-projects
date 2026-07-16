using System;

public class WordGenerator
{
    private string ga_randomWord;
    private int ga_index;

    public string GetRandomWord(string file)
    {
        Random random = new Random();
        Dictionary dictionary = new Dictionary();

        List<string> calledList = dictionary.GetList(file);

        ga_index = random.Next(calledList.Count);
        ga_randomWord = calledList[ga_index];

        return ga_randomWord;
    }
    public int GetRandomWordCount()
    {
        return ga_randomWord.Length;
    }
}