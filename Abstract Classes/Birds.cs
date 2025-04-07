public abstract class Birds
{
    protected string Name { get; set; }
    protected int FlyDistance { get; set; }
    public abstract double WingSpan { get; set; }
    protected Birds(string name, int flyDistance)
    {
        Name = name;
        FlyDistance = flyDistance;
    }

    public abstract void MakeSound();

    public void BirdInfo()
    {
        Console.WriteLine($"Name: {Name}, Fly distance: {FlyDistance} km");
    }   
}