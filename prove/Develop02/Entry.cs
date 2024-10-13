using System.ComponentModel.DataAnnotations;

public class Entry
{
    public int _prompt;
    public string _entryTime;
    public string _response;
    public List<string> _promptList = new List<string>
    {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    public void MakeEntry()
    {
        Random rnd = new Random();
        _prompt = rnd.Next(0,_promptList.Count);
        Console.WriteLine($"Your prompt: {_promptList[_prompt]}\n");
        _response = Console.ReadLine();
        DateTime now = DateTime.Now;
        _entryTime = now.ToShortDateString();
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Entry time: {_entryTime}");
        Console.WriteLine($"Prompt: {_promptList[_prompt]}");
        Console.WriteLine($"Response: {_response}");
    }

    public string FormatEntry()
    {
        string text = "";
        text += $"Entry Time: {_entryTime}//";
        text += $"Prompt: {_promptList[_prompt]}//";
        text += $"Response: {_response}";
        return text;
    }
}