using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating things
        Journal journal1 = new Journal();
        bool repeat = true;
        string option = "1";

        while(repeat == true)
        {
            Console.WriteLine("Options: \n1. Make Entry \n2. Read all Entries \n3. Exit \n>");
            option = Console.ReadLine();
            if (option == "1")
            {
                journal1.CreateEntry();
            } 
            else if (option == "2")
            {
                journal1.DisplayEntries();
            } 
            else if (option == "3")
            {
                repeat = false;
                Console.WriteLine("Goodbye!");
            } 
            else
            {
                Console.WriteLine("Unknown option - please submit either 1, 2, or 3.");
            }
        }
    }
}