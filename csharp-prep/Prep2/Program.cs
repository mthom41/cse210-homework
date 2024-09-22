using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float grade_value = int.Parse(grade);
        string letter_grade = "F";
        if (grade_value >= 90)
        {
            letter_grade = "A";
        }
        else if (grade_value < 90 && grade_value >= 80)
        {
            letter_grade = "B";
        }
        else if (grade_value < 80 && grade_value >= 70)
        {
            letter_grade = "C";
        }
        else if (grade_value < 70 && grade_value >= 60)
        {
            letter_grade = "D";
        } 
        Console.WriteLine($"Your letter grade is {letter_grade}.");
        if (grade_value >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but you'll get it next time!");
        }
    }
}