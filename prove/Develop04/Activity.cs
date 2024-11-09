class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected WaitTimer _timer = new WaitTimer();
    protected Spinner _spinner = new Spinner();

    public Activity()
    {
        _name = "name";
        _description = "default desc";
    }
    public void StartupMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds would you like this activity to last?");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void FinishMessage()
    {
        Console.WriteLine($"Good work!");
        Thread.Sleep(2000);
        Console.WriteLine($"You performed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(2500);
    }
    public void DisplayTimer(int duration)
    {
        _timer.CountDown(duration);
    }
    public void Pause(int duration)
    {
        _spinner.Display(duration);
    }
}