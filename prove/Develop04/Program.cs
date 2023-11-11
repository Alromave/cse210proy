using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activiy");
        Console.WriteLine("2. Start reflecting actividy");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4.Quit");
        Console.WriteLine("Select a choice from the menu:");
        string red = Console.ReadLine();
        if (red == "1")
        {
            Console.WriteLine("Breathing");

        }
        else if (red == "2")
        {
            Console.WriteLine("reflecting");
        }
        else if (red == "3")
        {
            Console.WriteLine("listing");
        }
        else if (red == "4")
        {
            Console.WriteLine("Quit");
        }
        else
        {
            Console.WriteLine("Your choice is wrong, try again");
        }

    }
}