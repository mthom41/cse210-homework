class ReflectionActivity:Activity
{
    private List<string> _initialPrompts = [
    "Think of a time when you stood up for someone else.", 
    "Think of a time when you did something really difficult.", 
    "Think of a time when you helped someone in need.", 
    "Think of a time when you did something truly selfless."
    ];
    private List<string> _secondaryPrompts = [
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What did you learn about yourself through this experience?"
    ];
    Random rand = new Random();
    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        _duration = 32;
    }
    public void Begin()
    {
        Console.Clear();
        StartupMessage();
        // break into 16s chunks
        int unevenTime = _duration%16;
        int cyclecount = Convert.ToInt32((_duration-unevenTime)/16);
        int index;
        for(int i=1; i <= cyclecount; i++)
        {
            index = rand.Next(0, _initialPrompts.Count-1);
            Console.WriteLine(_initialPrompts[index]);
            _spinner.Display(8);
            index = rand.Next(0, _secondaryPrompts.Count-1);
            Console.WriteLine(_secondaryPrompts[index]);
            _spinner.Display(8);
        }
        // final chunk, if there's any time left.
        if(unevenTime > 0)
        {
            index = rand.Next(0, _initialPrompts.Count-1);
            Console.WriteLine(_initialPrompts[index]);
            _spinner.Display(Convert.ToInt32(unevenTime/2));
            index = rand.Next(0, _secondaryPrompts.Count-1);
            Console.WriteLine(_secondaryPrompts[index]);
            _spinner.Display(Convert.ToInt32(unevenTime/2));
        }
        FinishMessage();
    }
}