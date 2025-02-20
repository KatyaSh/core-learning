public class BankAccount
{
    private static Random random = new Random();
    public double Konto { get; set; }
    public readonly string AccountNumber;

    public BankAccount()
    {
        Konto = 0.0;
        AccountNumber = GenerateBankAccountNumber();
    }

    private string GenerateBankAccountNumber()
    {
        return $"{random.Next(1000, 9999)}-{random.Next(1000, 9999)}-{random.Next(1000, 9999)}-{random.Next(1000, 9999)}";
    }

    public double AddDeposite(double money)
    {
        return this.Konto += money;
    }

    public double WithdrowMoney(double money)
    {
        if (this.Konto - money < 0.0)
        {
            Console.WriteLine("you don't have enaught money on your Konto");
            return this.Konto;
        }
        else
        {
            Console.WriteLine($"Get you {money}");
            return this.Konto -= money;
        }
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"your bank number: {AccountNumber}");
    }

    public void DisplayAccountMoneyInfo()
    {
        Console.WriteLine($"you have: {this.Konto} on you account");
    }
}
