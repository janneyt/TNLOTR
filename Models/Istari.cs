public class Istari
{
    private string Name {get; set; } 
    private string Color { get; set;}
    private int Wisdom { get; set;}
    private int Corruption { get; set;}
    private int Willpower { get; set;}

    public Istari(string name, string color)
    {
        Name = name;
        Color = color;
        Wisdom = 0;
        Corruption = 0;
        Willpower = 0;
    }
}
