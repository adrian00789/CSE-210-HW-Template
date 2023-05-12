using System;
using System.Collections.Generic;
using System.IO;

public class Journal // Journal class
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    //Add entry function
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    //Display journal function
    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    //Save file function
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
    }
    //Load file function
    public void LoadFile(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
                string dateLine = reader.ReadLine();
                string promptLine = reader.ReadLine();
                string responseLine = reader.ReadLine();
                string additionalInfoLine = reader.ReadLine(); 
                string emptyLine = reader.ReadLine();

                DateTime date = DateTime.Parse(dateLine.Substring(6));
                string prompt = promptLine.Substring(8);
                string response = responseLine.Substring(10);
                string additionalInfo = additionalInfoLine.Substring(16); 

                entries.Add(new Entry(prompt, response, additionalInfo) { Date = date });
            
        }
    }
}