public class Penguin : IBird, IMakeSound
{
    public string Name { get; set; }

    public Penguin(string name) => Name = name;

    public void MakeNest() => Console.WriteLine("Penguin does not make nest");

    public void Sound() => Console.WriteLine(" Penguin says: honk-honk-honk");

    public void BirdInfo() => Console.WriteLine($"Bird name: {Name}");
}