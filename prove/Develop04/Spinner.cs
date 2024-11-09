class Spinner
{
    private List<string> _sprites = new List<string>();
    private int _framerate;
    public Spinner()
    {
        _sprites = ["O","o","."," ",".","o"];
        _framerate = 5; 
    }
    public Spinner(List<string> sprites, int framerate)
    {
        _sprites = sprites;
        _framerate = framerate;
    }
    public void Display(int duration)
    {
        int framecounter = duration*_framerate;
        for(int i=1; i<=framecounter; i++)
        {
            Console.Write(_sprites[i%6]);
            Thread.Sleep(Convert.ToInt32(1000/_framerate));
            Console.Write("\b \b");
        }
    }
}