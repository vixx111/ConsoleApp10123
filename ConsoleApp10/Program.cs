public class Soldier
{
    public string LastName { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }

    public Soldier(string lastName, double height, double weight)
    {
        LastName = lastName;
        Height = height;
        Weight = weight;
    }

    public double CalculateQuality()
    {
        return Height * Weight;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Soldier: {LastName}, Height: {Height}, Weight: {Weight}, Quality (Q): {CalculateQuality()}");
    }
}
