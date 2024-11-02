class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems)
    {
        _studentName = name;
        _topic = topic;
        _textbookSection = section;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        string str = $"Section: {_textbookSection} Problems:{_problems}";
        return str;
    }
}