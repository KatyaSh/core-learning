public class Parrots : Birds
{
    string Color { get; set; }
    public override double WingSpan { get; set; }

    public Parrots(string color, string name, int flyDistance, double wingSpan) : base(name, flyDistance)
    {
        Color = color;
        WingSpan = wingSpan;
    }

    public override void MakeSound()
    {
        Console.WriteLine("I'm papuga and repeating all what you are saying");
    }

    public void WhereLive() => Console.WriteLine("Parrots live on palms");

    public new void BirdInfo() => Console.WriteLine($"Bird name: {Name}, Wing Span: {WingSpan} cm, Fly distance: {FlyDistance} km, Color: {Color}");
}