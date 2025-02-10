namespace Library
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual void PrintInfo() => Console.WriteLine($"Name: {FirstName}, LastName: {LastName}, Age: {Age}");
    }

    public class Employee : Person
    {
        public string Position { get; set; }

        public Employee(string firstName, string lastName, int age, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Position: {Position}");
        }
    }
}
