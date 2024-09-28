using System;
using System.Globalization;

class Program
{
    // Define functions
    static void displaywelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptname()
    {
        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    static int promptnumber()
    {
        Console.WriteLine("What's your favorite number?");
        string numm = Console.ReadLine();
        int num = int.Parse(numm);
        return num;
    }

    static int squarenumber(int numb)
    {
        int squared = numb*numb;
        return squared;
    }

    static void displayresult(string name, int num)
    {
        int number = squarenumber(num);
        Console.WriteLine($"{name}, your number squared is {number}.");
    }
    //main
    static void Main(string[] args)
    {
        displaywelcome();
        string name = promptname();
        int number = promptnumber();
        displayresult(name, number);

    }
}