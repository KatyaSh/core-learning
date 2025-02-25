public class Sparrow : IBird, IFly, IMakeSound
{
    public string Name { get; set; }

    public Sparrow(string name) => Name = name;

    public void MakeNest() => Console.WriteLine("Sparrow makes nest under the roof");

    public void Sound() => Console.WriteLine("Sparrow says: Chick-chirick");

    public void BirdInfo() => Console.WriteLine($"Bird name: {Name}");

    public void Fly() => Console.WriteLine("sparrow can't fly very high");
}