using System.IO;
class GoalManager{
    private int _points = 0;
    private List<Goal> _goals = new List<Goal>();
    public void AddGoal(){
        Goal goal;
        Console.WriteLine("Which type of goal do you want to create?\n1. Basic\n2. Checklist\n3. Eternal\n4. Quit");
        string ans = Console.ReadLine();
        if(ans == "4"){
            Console.WriteLine("Did not add goal.");
            return;
        }
        else if(ans == "1"){
            goal = new Goal();
            goal.Create();
            _goals.Add(goal);
        }
        else if(ans == "2"){
            goal = new ChecklistGoal();
            goal.Create();
            _goals.Add(goal);
        }
        else if(ans == "3"){
            goal = new EternalGoal();
            goal.Create();
            _goals.Add(goal);
        }
        
    }
    public void RecordEvent(){
        Console.WriteLine("Which goal would you like to record an event for?");
        for(int i=0; i<_goals.Count(); i++){
            Console.Write($"{i+1}");
            _goals[i].DisplayGoal();
        }
        Console.Write(">>");
        int response = Convert.ToInt32(Console.ReadLine());
        _points += _goals[response-1].RecordEvent();
    }
    public void SetPoints(){
        foreach(Goal g in _goals){
            _points += g.GetPoints();   
        }
    }
    public void DisplayGoals(){
        Console.WriteLine("====== Goals ======");
        foreach(Goal g in _goals){
            g.DisplayGoal();
        }
        Console.WriteLine("Total Points: " + _points.ToString());
    }
    public void SaveGoals(){
        Console.WriteLine("Filename for save data?");
        string filename = Console.ReadLine();
        using(StreamWriter outputfile = new StreamWriter(filename)){
            foreach(Goal g in _goals){
                outputfile.WriteLine(g.SaveGoalData());
            }
            Console.WriteLine($"All goals saved to {filename}");
        }
    }
    public void LoadGoals(){
        Console.WriteLine("This will clear all goals. Continue?(y/n)");
        string ans = Console.ReadLine();
        if(ans == "y"){
            _goals.Clear();
            Console.WriteLine("File to read from?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            Goal newGoal;
            foreach (string line in lines){
                string[] parsedLine = line.Split(":");
                if(parsedLine[0] == "Basic"){
                    newGoal = new Goal();
                }
                else if(parsedLine[0] == "Checklist"){
                    newGoal = new ChecklistGoal();
                } 
                else if(parsedLine[0] == "Eternal"){
                    newGoal = new EternalGoal();
                }
                else{
                    Console.WriteLine("File not recognized. Aborting...");
                    return;
                }
                newGoal.LoadGoalData(line);
                _points += newGoal.GetPoints();
                _goals.Add(newGoal);
            }
            Console.WriteLine($"Goals successfully loaded from {filename}");
            DisplayGoals();
        }
        else{
            Console.WriteLine("Aborting...");
            return;
        }
        
    }
}