using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup vars and objects
        Reference myref = new Reference();
        myref.Set("Alma", "37", "6");
        string script_string = "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.";
        Scripture myscripture = new Scripture(myref, script_string);
        bool quit = false;

        //main loop
        while(quit == false)
        {
            Console.Clear();
            myscripture.Display();
            Console.WriteLine("\nPress enter to continue, or type quit to quit.");
            string console_input = Console.ReadLine();
            if(console_input == "quit")
            {
                quit = true;
            }
            else
            {
                //recall that blankify returns false if it cannot successfully make new blanks
                if(myscripture.Blankify(3))
                {
                    continue;
                }
                else
                {
                    quit = true;
                    Console.Clear();
                    myscripture.Display();
                }
            }
        }
    }
}