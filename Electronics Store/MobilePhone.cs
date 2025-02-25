public class MobilePhone : Device, ITakePhoto
{
    public MobilePhone(string model, double price, string brand) : base(model, price, brand) { }

    public override void Charge() => Console.WriteLine("Mobile Phone is charged by means of C type charger");

    public override void TurnOn() => Console.WriteLine("To turn on the phone, press the side Button and hold for 3 sec");

    public override void TurnOff() => Console.WriteLine("To turn off the phone, press the side Button together with sound button, and hold for 3 sec");

    public void TakePhoto()
    {
        Console.WriteLine("Turn on your camera and take a photo");
    }

    public override void DeviceInfo() => Console.WriteLine($"Mobile Phone model: {Model}, Brand: {Brand}, price: {Price}$");
}