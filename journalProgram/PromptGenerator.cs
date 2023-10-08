using System.Security.Cryptography.X509Certificates;

public class PromptGenerator{
    Random random = new Random();
    public List<string> myPrompts = new List<string>(){
        "1",
        "2",
        "3"
    };
    public string getRandomPrompt(){

        int randomIndex = random.Next(0, myPrompts.Count);
        string prompt = myPrompts[randomIndex];
        return prompt;
    }
}