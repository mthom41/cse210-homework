class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected bool _isComplete = false;
    protected int _pointValue;
    protected int _completions = 0;
    public virtual void Create()
    {
        _type = "Basic";
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What's the description of your goal?");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        string pts = Console.ReadLine();
        _pointValue = Convert.ToInt32(pts);
    }
    public virtual int RecordEvent()
    {
        if(_isComplete == false)
        {
            Console.WriteLine("Select an option to record your event:");
            Console.Write("1. I completed this goal.\n2. Exit\n#>");
            string input = Console.ReadLine();
            if (input == "1")
            {
                _isComplete = true;
                _completions=1;
                Console.WriteLine($"Great job! You earned {_pointValue} points!");
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
    public virtual void DisplayGoal(){
        if(_isComplete){
            Console.Write("[X]");
        } 
        else {
            Console.Write("[ ]");
        }
        Console.WriteLine($" - {_name} ({_description})");
    }
    public virtual int GetPoints(){
        if(_isComplete){
            return _pointValue;
        } 
        else{
            return 0;
        }
    }
    public virtual string SaveGoalData(){
        string dataLine = _type + ":" + _name + "," + _description + "," + _pointValue.ToString() + "," + _completions.ToString() + "," + _isComplete.ToString();
        return dataLine;
    }
    public virtual void LoadGoalData(string dataInput){
        string[] mainData = dataInput.Split(':');
        string[] details = mainData[1].Split(',');
        _type = mainData[0];
        _name = details[0];
        _description = details[1];
        _pointValue = Convert.ToInt32(details[2]);
        _completions = Convert.ToInt32(details[3]);
        _isComplete = Convert.ToBoolean(details[4]);
    }
}