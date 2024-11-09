class ListingActivity:Activity
{
    private List<string> _prompts = [
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    ];
    Random rand = new Random();
    private List<string> _responses = new List<string>();
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 45;
    }
    public void Begin()
    {
        Console.Clear();
        StartupMessage();
        _responses.Clear();
        // set an end time
        DateTime start_time = DateTime.Now;
        DateTime end_time = start_time.AddSeconds(_duration+4);
        int index = rand.Next(0, _prompts.Count-1);
        // pick a prompt
        Console.WriteLine(_prompts[index]);
        Console.WriteLine("List as many items as possible in the time you selected!");
        _timer.CountDown(4);
        // go!
        bool contin = true;
        string new_entry = "";
        while(contin)
        {
            Console.WriteLine("Add a list item: ");
            new_entry = Console.ReadLine();
            _responses.Add(new_entry);
            DateTime now = DateTime.Now;
            if(now > end_time)
            {
                contin = false;
            }
        }
        Console.WriteLine($"You listed {_responses.Count} things!");
        FinishMessage();
    }
}