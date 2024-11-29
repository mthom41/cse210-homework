class EternalGoal:Goal{
    public override void Create()
    {
        _type = "Eternal";
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What's the description of your goal?");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth per completion?");
        string pts = Console.ReadLine();
        _pointValue = Convert.ToInt32(pts);
    }
    public override int RecordEvent(){
        Console.WriteLine("Select an option to record your event:");
        Console.WriteLine("1. I completed this goal.\n2. Exit\n#>");
        string input = Console.ReadLine();
        if (input == "1"){
            Console.WriteLine($"Great job! You earned {_pointValue} points!");
            _completions++;
            return _pointValue;
        }
        else if (input == "2"){
            return 0;
        }
        else{
            Console.WriteLine("Invalid input. No event recorded.");
            Thread.Sleep(2000);
            return 0;
        }
    }
    public override void DisplayGoal(){
        Console.WriteLine($"[∞] - {_name} ({_description}) - {_completions} completions");
    }
    public override int GetPoints()
    {
        return _pointValue*_completions;
    }
}