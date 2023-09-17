using System;

class Program
{
    static void Main(string[] args)
    {
        /* parte 1: only conditional
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        Console.Write("What is the guess number? ");
        string guess = Console.ReadLine();
        int M = int.Parse(magic);
        int G = int.Parse(guess);
        if (M > G)
        
        {
            Console.Write("Higher");
        }
        else if (G>M)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        /* part 2 loops
        
        {
            Console.Write("What is the magic number?");
            string M = Console.ReadLine();
            int M = int.Parse(M);
            Console.Write ("What is the guess number?");
            string G = Console.ReadLine();
            int G = int.Parse(G);
        }
        
        while (M != G)

            
            Console.Write("What is the guess number?");
            string guess = Console.ReadLine();
            
            int G = int.Parse(guess);

        }
        /*while (M > G)
        if (G > M)
        {
            Console.WriteLine("Higher");
        }
        else if (G < M)
        {
            Console.WriteLine("Lower");
        }
        else 
        {
            Console.WriteLine("YOu guessed it!");
        }*/
        Random randomGenerator = new Random();
        int M = randomGenerator.Next(1,101);
        int G = -1;
        while (G != M)
        {
            Console.Write("What is your number guess?");
            G = int.Parse(Console.ReadLine());
            if(M > G)
            {
                Console.WriteLine("Higher!");
            }
            else if (M < G)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");
            }

        }





    }
}
