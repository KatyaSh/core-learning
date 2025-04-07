public class Client : Person
{
    public bool Vip { get; set; }

    public Client(string firstName, string lastName, int age, bool vip) : base(age, firstName, lastName)
    {
        this.Vip = vip;
    }

    public void TakeLoan(bool desireToTakeLoan)
    {
        if (desireToTakeLoan)
        {
            Console.WriteLine("you can take a loan");
        }
        else
        {
            Console.WriteLine("you don't want to take a loan");
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", this is Vip client: {Vip}";
    }
}
