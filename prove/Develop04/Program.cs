using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize things
        Console.WriteLine("Welcome to the mindfulness activity!");
        BreathingActivity breathe = new BreathingActivity();
        ReflectionActivity reflect = new ReflectionActivity();
        ListingActivity lisst = new ListingActivity();
        string input = "";
        bool minding = true; 
        // main loop
        while(minding)
        {
            Console.WriteLine("Choose your activity:\n1. Breathing\n2. Reflection\n3. Listing\n4. Quit");
            input = Console.ReadLine();
            if(input == "1")
            {
                breathe.Begin();
            } 
            else if(input == "2")
            {
                reflect.Begin();
            }
            else if(input == "3")
            {   
                lisst.Begin();                
            }
            else if((input == "4") || (input == "quit"))
            {
                minding = false;
                continue;
            }
        }
    }
}