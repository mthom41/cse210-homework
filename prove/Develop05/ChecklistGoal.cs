class ChecklistGoal:Goal{
    private int _bonus;
    private int _completionThreshold;
    public override void Create()
    {
        _type = "Checklist";
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What's the description of your goal?");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is each completion of this goal worth?");
        string pts = Console.ReadLine();
        _pointValue = Convert.ToInt32(pts);
        Console.WriteLine("How many completions to earn the bonus?");
        pts = Console.ReadLine();
        _completionThreshold = Convert.ToInt32(pts);
        Console.WriteLine("How many bonus points this goal worth on completion?");
        pts = Console.ReadLine();
        _bonus = Convert.ToInt32(pts);
    }
    public override int RecordEvent()
    {
        if(_isComplete == false)
        {
            Console.WriteLine("Select an option to record your event:");
            Console.WriteLine("1. I completed this goal.\n2. Exit\n#>");
            string input = Console.ReadLine();
            if (input == "1")
            {
                _completions++;
                Console.WriteLine($"Great job! You earned {_pointValue} points!");
                Console.WriteLine($"You have completed this goal {_completions}/{_completionThreshold} times.");
                if(_completions == _completionThreshold){
                    Console.WriteLine($"You have earned the bonus! Enjoy {_bonus} more points.");
                    _isComplete = true;
                    return _pointValue + _bonus;
                    // since this only happens the final completion, we don't 
                    // need to tally the total of the earlier goal completions.
                    // we'll do that in the GetPoints method.
                }
                return _pointValue;
            }
            else if (input == "2")
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Invalid input. No event recorded.");
                Thread.Sleep(2000);
                return 0;
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            Thread.Sleep(2000);
            return 0;
        }
    }
    public override void DisplayGoal()
    {
        if(_isComplete){
            Console.Write("[X]");
        } 
        else {
            Console.Write("[ ]");
        }
        Console.WriteLine($" - {_name} ({_description}) - {_completions}/{_completionThreshold} completions");
    }
    public override int GetPoints(){
        if(_isComplete){
            return _bonus + (_completions*_pointValue);
        }
        else{
            return _pointValue*_completions;
        }
    }
    public override string SaveGoalData()
    {
        string output = base.SaveGoalData();
        output += "," + _bonus.ToString() + "," + _completionThreshold.ToString();
        return output;
    }
    public override void LoadGoalData(string dataInput)
    {
        string[] mainData = dataInput.Split(':');
        string[] details = mainData[1].Split(',');
        _type = mainData[0];
        _name = details[0];
        _description = details[1];
        _pointValue = Convert.ToInt32(details[2]);
        _completions = Convert.ToInt32(details[3]);
        _isComplete = Convert.ToBoolean(details[4]);
        _bonus = Convert.ToInt32(details[5]);
        _completionThreshold = Convert.ToInt32(details[6]);
    }
}