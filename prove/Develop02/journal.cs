using System;
using System.Security.Cryptography.X509Certificates;
public class Journal
{
    public List<string> _entries = new List<string>();

    public void displayEntries()
    {
        foreach (string entry in _entries){
            Console.WriteLine(entry);

        }
        {
            public void addEntry()
            {
                Entry entry = new Entry();
                string _entry = entry.entryPackager();
                _entries.Add(_entry);
                
            }
            public void saveEntries()
            {
                if (!File.Exists(_fileName))
                {
                    using (StreamWriter outputFile = new StreamWriter(_fileName))
                    {
                        outputFile.WriteLine("<NAME>");
                        foreach (string entry in _entries)
                        {
                            outputFile.WriteLine(entry);
                        }
                    }

                }
                else{
                    using (StreamWriter outputFile = new StreamWriter(_fileName, true))
                    {
                        foreach(string entry in _entries)
                        {
                            outputFile.WriteLine(entry);
                        }
                    }
                }
            }
            private string getFileName()
            {
                Console.WriteLine("What is the name of file");
                string _fileName = Console.ReadLine();
                return _fileName;
            }
            Public void loadEntries()
            {
                string _fileName = getFileName();
                if (File.Exists(file_name))
                {
                    using (StreamReader inputFile = new StreamReader(_fileName))
                    {
                        string line;
                        while ((line = inputFile.ReadLine()) != null)
                        {
                            _entries.Add(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                    loadEntries();
                }
            }

        }
    }
}