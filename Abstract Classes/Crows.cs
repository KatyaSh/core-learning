public class Crows : Birds
{
    private int _size;
    public int Size
    {
        get { return _size; }

        set
        {
            if (value > 10)
            {
                _size = value;
            }

            else
            {
                Console.WriteLine("This crow is too small and cannot fly. Size was set as 10");
                _size = 10;
            }
        }
    }

    public override double WingSpan { get; set; }

    public Crows(int size, string name, int flyDistance, double wingSpan) : base(name, flyDistance)
    {
        Size = size;
        WingSpan = wingSpan;
    }

    public override void MakeSound()
    {
        Console.WriteLine("kar-kar");
    }

    public void WhatEat() => Console.WriteLine("Crows eat everything");

    public new void BirdInfo() => Console.WriteLine($"Bird name: {Name}, Wing Span: {WingSpan} cm, Fly distance: {FlyDistance} km, size: {Size} cm v holke");
}