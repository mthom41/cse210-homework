class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture()
    {
        _reference = new Reference();
        _reference.Set("Unknown","0","0");
        _words = new List<Word>();
    }
    public Scripture(string script)
    {
        _reference = new Reference();
        _reference.Set("Unknown","0","0");
        _words = new List<Word>();
        ParseWords(script);
    }
    public Scripture(Reference refer, string script)
    {
        _reference = refer;
        _words = new List<Word>();
        ParseWords(script);
    }
    private void ParseWords(string input)
    {
        string[] wordlist = input.Split(' ');
        foreach(string parsed_word in wordlist)
        {
            Word wordObj = new Word(parsed_word);
            _words.Add(wordObj);
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.Get());
        foreach(Word wrd in _words)
        {
            Console.Write(wrd.Get() + " ");
        }
    }

    public bool Blankify(int quant)
    {
        Random randint = new Random();
        int failcounter = 0;
        for(int i=0; i<quant;)
        {
            if(failcounter >= 250)
            {
                return false;
            }
            int blank_candidate = randint.Next(0, _words.Count());
            if(_words[blank_candidate].CheckBlank() == false)
            {
                _words[blank_candidate].MakeBlank();
                i++;
            }
            else
            {
                failcounter++;
                continue;
            }
        }
        return true;
    }
    


}
