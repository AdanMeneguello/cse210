public class Reference
{
    // Private fields for reference data
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse; // null means single verse

    // Single-verse constructor
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse; 
        _endVerse = null;
    }

    // Verse range constructor
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Return "Book Chapter:Verse" or "Book Chapter:Start-End"
    public string GetDisplayText()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse.Value}"
            : $"{_book} {_chapter}:{_startVerse}";
    }
}
