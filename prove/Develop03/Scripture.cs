using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private static List<(Reference, string)> scriptureList = new List<(Reference, string)>
    {
        (new Reference("John", 3, 16), 
            "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),

        (new Reference("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),

        (new Reference("Mosiah", 2, 17), 
            "When ye are in the service of your fellow beings ye are only in the service of your God.")
    };

    public Scripture()
    {
        Random random = new Random();
        var selected = scriptureList[random.Next(scriptureList.Count)];

        this.reference = selected.Item1;
        this.words = selected.Item2.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        return reference.GetDisplayText() + " - " + string.Join(" ", words.Select(w => w.GetDisplayText()));
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
