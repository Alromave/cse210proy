using System;

class Program
{
    static void Main(string[] args)
    {
        //To practice conditional
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int G = int.Parse(grade);
        if (G >= 90)
        {
            Console.WriteLine("A");
        }
        else if (G >= 80)
        {
            Console.WriteLine("B");
        }
        else if (G >= 70)
        {
            Console.WriteLine("C");
        }
        else if (G >= 60)
        {
            Console.WriteLine("D");
        }

        else{
            Console.WriteLine("F");
        }
        if (G >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else 
        {
            Console.WriteLine("Sorry, better luck next time");
        }

    }
}