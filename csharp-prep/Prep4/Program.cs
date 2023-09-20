using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernumber = -1;
        while (usernumber != 0)
        {
            Console.Write("Write a number, if you put 0 then the list finished ");
            string userAnswer = Console.ReadLine();
            usernumber = int.Parse(userAnswer);
            if (usernumber != 0)
            {
                numbers.Add(usernumber);
                
            }
            
        }
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        // the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        //the maximum
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");



        
    }
}