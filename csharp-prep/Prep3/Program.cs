using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // declarations
        Random rand = new Random();
        int mynumb = rand.Next(1,11);
        bool success = false;
        int tries = 0;
        string guess; 

        // primary loop
        while (success == false)
        {
            tries++;
            Console.WriteLine("Can you guess what my number is? (1-10)");
            guess = Console.ReadLine();
            int realguess = int.Parse(guess); 
            if (realguess == mynumb)
            {
                success = true;
                Console.WriteLine($"Congratulations! The number was {mynumb}.");
                Console.WriteLine($"You succeeded in {tries} guesses.");
            }
            else if (realguess < mynumb)
            {
                Console.WriteLine("You're low.");
            }
            else if (realguess > mynumb)
            {
                Console.WriteLine("You're high.");
            }
            else
            {
                Console.WriteLine("???");
            }
        }

    }
}