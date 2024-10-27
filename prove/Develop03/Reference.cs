class Reference
{
    private string _book;
    private string _chapter;
    private string _verseRange;

    public void Set(string book, string chapter, string verses)
    {
        _book = book;
        _chapter = chapter;
        _verseRange = verses;
    }

    public string Get()
    {
        string reff = _book + " " + _chapter + ":" + _verseRange;
        return reff;
    }
}