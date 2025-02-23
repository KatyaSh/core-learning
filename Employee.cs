public class Employee : Person
{
    public bool IsEmployeeOfMonth { get; set; }
    public bool isFired { get; set; }

    public Employee(string firstName, string lastName, int age, bool isEmployeeOfMonth) : base(age, firstName, lastName)
    {
        this.IsEmployeeOfMonth = isEmployeeOfMonth;
        this.isFired = false;
    }

    public void QuitFromBank(bool desireToQuit)
    {
        if (desireToQuit)
        {
            Console.WriteLine("you can quit");
        }
        else
        {
            Console.WriteLine("you don't want to quit");
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", Employee of Month: {IsEmployeeOfMonth}, is fired: {isFired}, this is Employee";
    }
}

