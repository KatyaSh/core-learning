using System.Xml.Linq;

public class Person
{
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(int age, string firstName, string lastName)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}, Age: {Age}";
    }
}
