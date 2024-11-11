class BreathingActivity:Activity
{
    private string _inhaleMessage;
    private string _exhaleMessage;
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _inhaleMessage = "Breath in..";
        _exhaleMessage = "Breathe out..";
        _duration = 30;
    }

    public void Begin()
    {
        Console.Clear();
        StartupMessage();
        //Breaks time into 8 second cycles
        int unevenTime = _duration%8;
        int cyclecount = Convert.ToInt32((_duration-unevenTime)/8);
        for(int i=1; i <= cyclecount; i++)
        {
            Console.WriteLine(_inhaleMessage);
            _timer.CountDown(4);
            Console.WriteLine(_exhaleMessage);
            _timer.CountDown(4);
        }
        // last shorter cycle
        if(unevenTime > 0)
        {
            Console.WriteLine(_inhaleMessage);
            _timer.CountDown(unevenTime);
        }
        FinishMessage();
    }
}