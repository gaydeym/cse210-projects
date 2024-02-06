public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();

            using (StreamReader reader = new StreamReader(file))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split('|');

                    if (fields.Length == 3)
                    {
                        string date = fields[0];
                        string promptText = fields[1];
                        string entryText = fields[2];

                        Entry entry = new Entry
                        {
                            _date = date,
                            _promptText = promptText,
                            _entryText = entryText
                        };

                        _entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("The specified file does not exist.");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,PromptText,EntryText");

            foreach (Entry entry in _entries)
            {
                string csvLine = $"{entry._date}|{entry._promptText}|{entry._entryText}";
                writer.WriteLine(csvLine);
            }
        }
    }
}