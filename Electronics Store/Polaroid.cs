public class Polaroid : Device, ITakePhoto, IPrint
{
    public Polaroid(string model, double price, string brand) : base(model, price, brand) { }

    public override void Charge() => Console.WriteLine("To charge Polaroid, insert the charging cable into the Micro USB slot");

    public override void TurnOn() => Console.WriteLine("To turn on the Polaroid,  flip the toggle on");

    public override void TurnOff() => Console.WriteLine("To turn off the Polaroid,  flip the toggle off");

    public void TakePhoto()
    {
        Console.WriteLine("Press the shutter button to take your photo");
    }

    public void Print()
    {
        Console.WriteLine("Polaroid prints your photo right after it capturing");
    }

    public override void DeviceInfo() => Console.WriteLine($"Polaroid model: {Model}, Brand: {Brand}, price: {Price}$");
}