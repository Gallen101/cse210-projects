using System;

public class Dictionary
{
    private List<string> ga_dictionary = new List<string>();

    public List<string> GetList(string file)
    {
        LoadWords(file);
        return ga_dictionary;
    }
    public void AddWord(string word)
    {
        ga_dictionary.Add(word);
    }

    public void LoadWords(string file)
    {
        string[] readText = File.ReadAllLines(file);

        foreach (string line in readText)
        {
            string entries = line;
            AddWord(entries);
        }
    }
}