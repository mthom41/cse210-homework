class Journal
{
    public List<Entry> _entries = new List<Entry>{};

    public void CreateEntry()
    {
        Entry newentry = new Entry();
        newentry.MakeEntry();
        _entries.Add(newentry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count > 0)
        {
            foreach(Entry entry in _entries)
            {
                Console.WriteLine("\n");
                entry.DisplayEntry();
            }
        } else {
            Console.WriteLine("Journal is empty :(");
        }
        
    }
}