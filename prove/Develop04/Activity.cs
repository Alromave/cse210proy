public class Activity
{
    
    public string Name {get; set;}
    public string Description {get; set:}
    public int Duration {get; set: }


    public Activity (string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }
    public virtual void Theactivity()
    {
       
        Console.WriteLine("Welcome to Mindfulness Program. Enjoy it");
        Console.WriteLine($"Activity:{Name}");
        Console.WriteLine(Description);
    }
}
