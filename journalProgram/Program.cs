using System;
class Program
{
    
    static void Main(string[] args)
    
    {
        Journal myJournal = new Journal("Alvaro"); 
        // Console.WriteLine(myJournal.entries);.
        Console.WriteLine("Welcome to your Journal Program");
        bool programRunning = true;
        
        while (programRunning == true)
        {
            Console.WriteLine("Please select your option");
            Console.WriteLine("Write");
            Console.WriteLine("Display");
            Console.WriteLine("Load");
            Console.WriteLine("Save");
            Console.WriteLine("Quit");
            Console.WriteLine("What is your option");
            string userChoice = Console.ReadLine();
            
            if (userChoice =="1")
            {
                
                Entry NewEntry = new Entry();
                Console.WriteLine(NewEntry.Prompt);
                string Answer = Console.ReadLine();
                NewEntry.setEntry(Answer);
                myJournal.AddEntry(NewEntry);

                
                

            }
            else if (userChoice == "2")
            {
                for (int i = 0; i < myJournal.entries.Count; i++)
                {
                    Console.WriteLine("-----");
                    Console.WriteLine(myJournal.entries[i].Date);
                    Console.WriteLine(myJournal.entries[i].entry);
                }
            }
            else if (userChoice == "3")
            {
                
            }
        }

    }

    
}
