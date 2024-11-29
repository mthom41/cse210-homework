using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager _manager = new GoalManager();
        bool _continue = true;
        Console.WriteLine("Welcome to goal manager! Remember to load your goals first if you have saved them previously.");
        while( _continue == true){
            Console.WriteLine("1. New Goal \n2. Record Event \n3. Display Goals \n4. Save Goals \n5. Load Goals \n6. Quit");
            string ans = Console.ReadLine();
            if(ans == "1"){
                _manager.AddGoal();
            }
            else if(ans == "2"){
                _manager.RecordEvent();
            }
            else if(ans == "3"){
                _manager.DisplayGoals();
            }
            else if(ans == "4"){
                _manager.SaveGoals();
            }
            else if(ans == "5"){
                _manager.LoadGoals();
            }
            else if(ans == "6" || ans == "q" || ans == "quit"){
                _continue = false;
                continue;
            }
            else{
                Console.WriteLine("Input not recognized.");
            }
        }
    }
}