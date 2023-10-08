using System;
public class PromptGeneration
{
    public List<string>_prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?"
        "What was the best part of my day?"
        "How did I see the hand of the Lord in my life today?"
        "What was the strongest emotion I felt today?"
        "If I had one thing I could do over today, what would it be?" 
        "What is the best memory of today?"
        "Some verse from the canonical books that struck me today?"
    };
    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts [index];
    }


        

    }
}


