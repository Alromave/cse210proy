using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        user.ReadCSVData();

        Console.WriteLine("Welcome to the Journal Program!");
        
        while (journalRunning == true)
        {
            if (userChoice == "1")
            {
                journal.addEntry();
            }
            else if (userChoice == "2")
            {
                jornal.displayEntries();
            }
            else if (userChoice == "3")
            {
                journal.loadEntries();
            }
            else if (userChoice == "4")
            {
                journal.saveEntries();
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Bye");

            }
            else
            {
                Console.WriteLine("Fail, try again")
            }


        
        
        


    }
    static string DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string userChoice  = Console.ReadLine();
        return userChoice;
    }
}