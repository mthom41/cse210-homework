class WaitTimer
{
    public void CountDown(int duration)
    {
        duration++;
        for(int i=1; i < duration; i++)
        {
            Console.Write($"{duration - i}...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
        }
    }
}