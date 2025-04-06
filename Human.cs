public abstract class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected Human() { }

    protected Human(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
    }
}