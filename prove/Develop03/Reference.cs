public class Reference
{
    private string _book;
    private int _chap;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chap, int startVerse)
    {
        _book = book;
        _chap = chap;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    public Reference(string book, int chap, int startVerse, int endVerse)
    {
        _book = book;
        _chap = chap;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == _startVerse)
            return $"{_book} {_chap}:{_startVerse}";
        else
            return $"{_book} {_chap}:{_startVerse}-{_endVerse}";
    }
}
