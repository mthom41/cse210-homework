class Assignment
{
    protected string _studentName;
    protected string _topic;

    public string GetSummary()
    {
        string str = $"{_studentName} - {_topic}";
        return str;
    }
}