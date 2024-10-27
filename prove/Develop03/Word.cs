class Word
{
    private string _string;
    private bool _isBlank;
    private string _blankString;

    public Word()
    {
        _string = "";
        _isBlank = false;
        _blankString = "";
    }
    public Word(string arg)
    {
        _string = arg;
        _isBlank = false;
        _blankString = "";
        for(int i = 0; i < _string.Length; i++)
        {
            _blankString += "_";
        } 
    }

    public string Get()
    {
        if(_isBlank)
        {
            return _blankString;
        } else {
            return _string;
        }
    }

    public void MakeBlank()
    {
        _isBlank = true;
    }

    public bool CheckBlank()
    {
        return _isBlank;
    }
}