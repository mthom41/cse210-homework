using System;

class Program
{
    static void Main(string[] args)
    {
        // variable initialization

        List<int> numbers = new List<int>();
        int new_num = 1;
        int mysum = 0;
        float average;
        int max = 0;

        // get list from user

        Console.WriteLine("Enter a list of integers. Type 0 when finished.");
        
        while(new_num != 0)
        {
            Console.WriteLine("Enter your number: ");
            string ninput = Console.ReadLine();
            new_num = int.Parse(ninput);
            numbers.Add(new_num);
        }

        // calculate results

        foreach(int num in numbers)
        {
            mysum += num;
            if (num > max)
            {
                max = num;
            }
        }

        average = mysum/numbers.Count;
        Console.WriteLine($"Sum: {mysum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");

    }
}