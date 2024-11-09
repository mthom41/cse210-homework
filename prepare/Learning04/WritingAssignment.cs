class WritingAssignment:Assignment
{
    private string _title;
    public WritingAssignment(string name, string topic, string title)
    {
        _studentName = name;
        _topic = topic;
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
