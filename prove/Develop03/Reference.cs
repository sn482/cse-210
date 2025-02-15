class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endVerse = verse;
    }

    // Constructor for multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return endVerse > startVerse ? $"{book} {chapter}:{startVerse}-{endVerse}" : $"{book} {chapter}:{startVerse}";
    }
}
